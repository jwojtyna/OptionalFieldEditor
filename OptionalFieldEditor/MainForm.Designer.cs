namespace OptionalFieldEditor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lblFieldLength = new System.Windows.Forms.Label();
            this.lblMessaging = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSaveAll = new System.Windows.Forms.Button();
            this.cmdAddMissing = new System.Windows.Forms.Button();
            this.cboDoc = new System.Windows.Forms.ComboBox();
            this.dgvFields = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.oEINVDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new OptionalFieldEditor.DataSet();
            this.oEINVDOTableAdapter = new OptionalFieldEditor.DataSetTableAdapters.OEINVDOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oEINVDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lblFieldLength);
            this.splitContainer.Panel1.Controls.Add(this.lblMessaging);
            this.splitContainer.Panel1.Controls.Add(this.lblDoc);
            this.splitContainer.Panel1.Controls.Add(this.cmdClose);
            this.splitContainer.Panel1.Controls.Add(this.cmdSaveAll);
            this.splitContainer.Panel1.Controls.Add(this.cmdAddMissing);
            this.splitContainer.Panel1.Controls.Add(this.cboDoc);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dgvFields);
            this.splitContainer.Size = new System.Drawing.Size(1565, 1128);
            this.splitContainer.SplitterDistance = 210;
            this.splitContainer.TabIndex = 0;
            this.splitContainer.TabStop = false;
            // 
            // lblFieldLength
            // 
            this.lblFieldLength.AutoSize = true;
            this.lblFieldLength.Location = new System.Drawing.Point(1299, 79);
            this.lblFieldLength.Name = "lblFieldLength";
            this.lblFieldLength.Size = new System.Drawing.Size(173, 32);
            this.lblFieldLength.TabIndex = 9;
            this.lblFieldLength.Text = "Field Length";
            // 
            // lblMessaging
            // 
            this.lblMessaging.AutoSize = true;
            this.lblMessaging.Location = new System.Drawing.Point(1299, 21);
            this.lblMessaging.Name = "lblMessaging";
            this.lblMessaging.Size = new System.Drawing.Size(153, 32);
            this.lblMessaging.TabIndex = 8;
            this.lblMessaging.Text = "Messaging";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(12, 14);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(113, 32);
            this.lblDoc.TabIndex = 7;
            this.lblDoc.Text = "Invoice:";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(1194, 142);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(359, 45);
            this.cmdClose.TabIndex = 4;
            this.cmdClose.TabStop = false;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdSaveAll
            // 
            this.cmdSaveAll.Location = new System.Drawing.Point(808, 142);
            this.cmdSaveAll.Name = "cmdSaveAll";
            this.cmdSaveAll.Size = new System.Drawing.Size(359, 45);
            this.cmdSaveAll.TabIndex = 3;
            this.cmdSaveAll.TabStop = false;
            this.cmdSaveAll.Text = "&Save";
            this.cmdSaveAll.UseVisualStyleBackColor = true;
            this.cmdSaveAll.Click += new System.EventHandler(this.cmdSaveAll_Click);
            // 
            // cmdAddMissing
            // 
            this.cmdAddMissing.Enabled = false;
            this.cmdAddMissing.Location = new System.Drawing.Point(564, 10);
            this.cmdAddMissing.Name = "cmdAddMissing";
            this.cmdAddMissing.Size = new System.Drawing.Size(359, 45);
            this.cmdAddMissing.TabIndex = 0;
            this.cmdAddMissing.TabStop = false;
            this.cmdAddMissing.Text = "&Add MissingFields";
            this.cmdAddMissing.UseVisualStyleBackColor = true;
            // 
            // cboDoc
            // 
            this.cboDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDoc.FormattingEnabled = true;
            this.cboDoc.Location = new System.Drawing.Point(131, 14);
            this.cboDoc.Name = "cboDoc";
            this.cboDoc.Size = new System.Drawing.Size(427, 39);
            this.cboDoc.TabIndex = 1;
            this.cboDoc.SelectedIndexChanged += new System.EventHandler(this.cboDoc_SelectedIndexChanged);
            this.cboDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDoc_KeyPress);
            this.cboDoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboDoc_KeyUp);
            this.cboDoc.Leave += new System.EventHandler(this.cboDoc_Leave);
            this.cboDoc.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cboDoc_PreviewKeyDown);
            // 
            // dgvFields
            // 
            this.dgvFields.AllowUserToAddRows = false;
            this.dgvFields.AllowUserToDeleteRows = false;
            this.dgvFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFields.Location = new System.Drawing.Point(0, 0);
            this.dgvFields.Name = "dgvFields";
            this.dgvFields.RowHeadersWidth = 102;
            this.dgvFields.RowTemplate.Height = 40;
            this.dgvFields.Size = new System.Drawing.Size(1565, 914);
            this.dgvFields.TabIndex = 2;
            this.dgvFields.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvFields_CellBeginEdit);
            this.dgvFields.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFields_CellFormatting);
            this.dgvFields.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvFields_DataError);
            this.dgvFields.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFields_RowLeave);
            this.dgvFields.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvFields_KeyUp);
            this.dgvFields.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvFields_PreviewKeyDown);
            // 
            // oEINVDOBindingSource
            // 
            this.oEINVDOBindingSource.DataMember = "OEINVDO";
            this.oEINVDOBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oEINVDOTableAdapter
            // 
            this.oEINVDOTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 1128);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Optional Field Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oEINVDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource oEINVDOBindingSource;
        private DataSetTableAdapters.OEINVDOTableAdapter oEINVDOTableAdapter;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvFields;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cboDoc;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdSaveAll;
        private System.Windows.Forms.Button cmdAddMissing;
        private System.Windows.Forms.Label lblMessaging;
        private System.Windows.Forms.Label lblFieldLength;
    }
}