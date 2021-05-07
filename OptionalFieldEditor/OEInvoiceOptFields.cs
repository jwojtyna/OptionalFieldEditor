using OptionalFieldEditor.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OptionalFieldEditor.DataSet;

namespace OptionalFieldEditor
{
    public class OEInvoiceOptFields
    {
        private readonly OEINVDOTableAdapter adapter;
        private readonly OptionalFieldsTableAdapter optAdapter;

        public static string LastError { get; set; }
        private OEINVDORow origRow;
        public DataTable Items => adapter.GetData();
        public DataTable Detail => optAdapter.GetDataOptionalFieldDatabyInvoice();


        public OEInvoiceOptFields()
        {
            adapter = new OEINVDOTableAdapter();
            optAdapter = new OptionalFieldsTableAdapter();
        }

        public DataTable GetByInvUniq(decimal invUniq)
        {
            //var table = adapter.GetData();
            var table = optAdapter.GetDataOptionalFieldDatabyInvoice();

            table.DefaultView.RowFilter = "INVUNIQ = " + invUniq;
            return table;
        }

        public OEINVDORow FindByInvUniq(decimal INVUNIQ, short LINENUM, string OPTFIELD)
        {

            var table = adapter.GetData().FindByINVUNIQOPTFIELDLINENUM(INVUNIQ, OPTFIELD, LINENUM);
                return table;
        }
        public bool Update(decimal INVUNIQ, short LINENUM, string OPTFIELD, string VALUE)
            //SELECT INVUNIQ, LINENUM, OPTFIELD, AUDTDATE, AUDTTIME, AUDTUSER, AUDTORG, VALUE, TYPE, 
            //LENGTH, DECIMALS, ALLOWNULL, VALIDATE, SWSET
            //FROM OEINVDO
        {
            try
            {
                LINENUM *= 32;

                origRow = adapter.GetData().FindByINVUNIQOPTFIELDLINENUM(INVUNIQ, OPTFIELD, LINENUM);

                //adapter.Update(INVUNIQ, LINENUM, OPTFIELD, origRow.AUDTDATE, origRow.AUDTTIME, origRow.AUDTUSER, origRow.AUDTORG, 
                //    VALUE, origRow.TYPE, origRow.LENGTH, origRow.DECIMALS, origRow.ALLOWNULL, origRow.VALIDATE, origRow.SWSET,
                //    origRow.INVUNIQ, origRow.LINENUM, origRow.OPTFIELD, origRow.AUDTDATE, origRow.AUDTTIME, origRow.AUDTUSER, 
                //    origRow.AUDTORG, origRow.VALUE, origRow.TYPE, origRow.LENGTH, origRow.DECIMALS, origRow.ALLOWNULL, 
                //    origRow.VALIDATE, origRow.SWSET);
                adapter.UpdateOptValue (VALUE, INVUNIQ, LINENUM, OPTFIELD, origRow.INVUNIQ, origRow.LINENUM, origRow.OPTFIELD);
                return true;
            }
            catch (Exception ex)
            {

                LastError = $"Failed To Update Optional Field.  Reason: {ex.Message}";
                return false;
            }
        }

    }
}
