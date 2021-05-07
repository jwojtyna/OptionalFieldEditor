using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalFieldEditor
{
    public partial class frmMain : Form
    {

        public event System.Windows.Forms.DataGridViewDataErrorEventHandler DataError;

        private OEInvoiceOptFields optFields;
        private OEInvoices OEInv;
        private bool formLoading;
        private bool TabRegistered = false;

        private decimal INVUNIQ;
        private short LINENUM;
        private string OPTFIELD;
        private string VALUE;



        public frmMain()
        {
            InitializeComponent();
            optFields = new OEInvoiceOptFields();
            OEInv = new OEInvoices();
            formLoading = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            lblMessaging.Text = "";
            lblFieldLength.Text = "";

            cboDoc.DataSource = OEInv.Documents;
            cboDoc.DisplayMember = "INVNUMBER";
            cboDoc.ValueMember = "INVUNIQ";
            cboDoc.SelectedIndex = -1;

            formLoading = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void dgvFields_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFields.IsCurrentCellDirty == true)
            {
                try
                {
                    lblMessaging.Text = "Saving...";
                    lblMessaging.Refresh();
                    Application.DoEvents();

                    INVUNIQ = Convert.ToDecimal(dgvFields.Rows[e.RowIndex].Cells["INVUNIQ"].Value);
                    LINENUM = Convert.ToInt16(dgvFields.Rows[e.RowIndex].Cells["LINENUM"].Value);
                    OPTFIELD = Convert.ToString(dgvFields.Rows[e.RowIndex].Cells["OPTFIELD"].Value);
                    VALUE = Convert.ToString(dgvFields.Rows[e.RowIndex].Cells["VALUE"].EditedFormattedValue);

                    if (VALUE is null)
                    {
                        VALUE = "";
                    }

                    // note: this cuts the string length of VALUE to 60, but it needs to be dynamic based on the
                    // datatype being edited
                    optFields.Update(INVUNIQ, LINENUM, OPTFIELD, VALUE.ToString().Substring(0, 60));
                    lblMessaging.Text = "";
                    lblMessaging.Refresh();
                    Application.DoEvents();
                }
                catch (Exception ex)
                {

                    
                    errProvider.SetError(dgvFields, "Optional Field Update Failed");
                    return;
                }
            }
        }

        private void dgvFields_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

            //MessageBox.Show("Error happened " + anError.Context.ToString());
            errProvider.SetError(dgvFields, "Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                //MessageBox.Show("Commit error");
                errProvider.SetError(dgvFields, "Commit error " + anError.Context.ToString());
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                //MessageBox.Show("Cell change");
                errProvider.SetError(dgvFields, "Cell change " + anError.Context.ToString());
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                //MessageBox.Show("parsing error");
                errProvider.SetError(dgvFields, "parsing error " + anError.Context.ToString());
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                //MessageBox.Show("leave control error");
                errProvider.SetError(dgvFields, "leave control error " + anError.Context.ToString());
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }

        private void dgvFields_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                //MessageBox.Show("Tab");
                TabRegistered = true;
                e.IsInputKey = true;
            }
            if (e.KeyData == (Keys.Tab | Keys.Shift))
            {
                //MessageBox.Show("Shift + Tab");
                e.IsInputKey = true;
            }
        }

        private void cboDoc_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                //MessageBox.Show("Tab");
                //e.IsInputKey = true;
                TabRegistered = true;

                

            }
            if (e.KeyData == (Keys.Tab | Keys.Shift))
            {
                //MessageBox.Show("Shift + Tab");
                e.IsInputKey = true;
            }
        }

        private void cboDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoading)
            {
                //var invUNIQ = Convert.ToDecimal(cboDocument.ComboBox.SelectedValue);

                var invUNIQ = Convert.ToDecimal(cboDoc.SelectedValue);

                dgvFields.DataSource = optFields.GetByInvUniq(invUNIQ);

                //OEINVD.INVUNIQ, OEINVD.LINENUM, OEINVD.ITEM, OEINVD.[DESC], OEINVDO.OPTFIELD, OEINVDO.VALUE

                try
                {
                    if (this.dgvFields.Rows.Count > 0)
                    {
                        this.dgvFields.RowHeadersVisible = false;

                        this.dgvFields.Columns[0].Width = 0;        //INVUNIQ - we need it, but don't need to see it
                        this.dgvFields.Columns[0].Visible = false;
                        this.dgvFields.Columns[0].Frozen = true;

                        this.dgvFields.Columns[1].Width = 100;       //LINEID
                        this.dgvFields.Columns[1].ReadOnly = true;
                        this.dgvFields.Columns[1].Frozen = true;

                        //this.dgvFields.Columns[1].HeaderText = "LINE";

                        this.dgvFields.Columns[2].Width = 150;       //ITEMNO
                        this.dgvFields.Columns[2].ReadOnly = true;
                        this.dgvFields.Columns[2].Frozen = true;

                        this.dgvFields.Columns[3].Width = 100;      //ITEM DESC
                        this.dgvFields.Columns[3].ReadOnly = true;
                        this.dgvFields.Columns[3].Frozen = true;

                        this.dgvFields.Columns[4].Width = 150;          //OPTFIELD
                        this.dgvFields.Columns[4].Frozen = true;

                        this.dgvFields.Columns[5].Width = 50;           //VALUE
                        this.dgvFields.Columns[5].ReadOnly = true;

                        dgvFields.Focus();
                        dgvFields.CurrentCell = dgvFields.Rows[0].Cells["VALUE"];
                    }
                }
                catch (Exception)
                {

                    errProvider.SetError(dgvFields, "Unable to load grid");
                    return;
                }

                


            }
            else
            {
                cboDoc.SelectedIndex = -1;
            }
        }

        private void cmdSaveAll_Click(object sender, EventArgs e)
        {
            //decimal INVUNIQ, short LINENUM, string OPTFIELD, string VALUE
            //optFields.Update()
            lblMessaging.Text = "Saving...";
            for (int rows = 0; rows < dgvFields.Rows.Count - 1; rows++)
            {

                try
                {
                    Application.DoEvents();

                    INVUNIQ = Convert.ToDecimal(dgvFields.Rows[rows].Cells["INVUNIQ"].Value);
                    LINENUM = Convert.ToInt16(dgvFields.Rows[rows].Cells["LINENUM"].Value);
                    OPTFIELD = Convert.ToString(dgvFields.Rows[rows].Cells["OPTFIELD"].Value);
                    VALUE = Convert.ToString(dgvFields.Rows[rows].Cells["VALUE"].Value);

                    // note: this cuts the string length of VALUE to 60, but it needs to be dynamic based on the
                    // datatype being edited
                    optFields.Update(INVUNIQ, LINENUM, OPTFIELD, VALUE.ToString().Substring(0, 60));
                }
                catch (Exception ex)
                {

                    errProvider.SetError(cmdSaveAll, "Optional Field Update Failed");
                    return;
                }


            }
            lblMessaging.Text = "";
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboDoc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cboDoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (TabRegistered == true)
            {
                //SendKeys.Send("{ENTER}");
                if (dgvFields.Rows.Count > 0)
                {
                    dgvFields.Focus();
                    dgvFields.CurrentCell = dgvFields.Rows[0].Cells["VALUE"];
                }

                //dgvFields.BeginEdit(true);
                TabRegistered = false;
            }
        }

        private void dgvFields_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (TabRegistered == true)
            {
                //SendKeys.Send("{ENTER}");
                TabRegistered = false;
            }
        }

        private void dgvFields_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //todo - determine what kind of optional field we are editing and setup the appropriate mask

            //if (e.ColumnIndex == this.dgvFields.Columns["VALUE"].Index &&

            //    e.RowIndex < this.dgvFields.NewRowIndex)
            //{
            //    //add if for type
            //    CellFormat(e);
            //}
        }

        private static void CellFormat(DataGridViewCellFormattingEventArgs formatting)
        {
            //if (formatting.Value != null)
            //{
            //    try
            //    {
            //        DateTime theDate = DateTime.Parse(formatting.Value.ToString());
            //        String dateString = theDate.ToString("dd-MM-yy");
            //        formatting.Value = dateString;
            //        formatting.FormattingApplied = true;
            //    }
            //    catch (FormatException)
            //    {
            //        // Set to false in case there are other handlers interested trying to
            //        // format this DataGridViewCellFormattingEventArgs instance.
            //        formatting.FormattingApplied = false;
            //    }
            //}
        }

        private void dgvFields_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvFields.Columns[e.ColumnIndex].Name == "VALUE")
            {
                CellFormat(e);
            }
        }

        private void cboDoc_Leave(object sender, EventArgs e)
        {

        }
    }
}
