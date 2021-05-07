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
    class OEInvoices
    {
        private readonly OEINVHTableAdapter adapter;
        public static string LastError { get; set; }
        OEINVHRow origRow;

        public OEInvoices()
        {
            adapter = new OEINVHTableAdapter();
        }

        public DataTable Documents
        {
            get
            {
                DataTable table = adapter.GetData();
                table.DefaultView.Sort = "INVNUMBER";
                return table;
            }
        }

        public OEINVHRow FindByID(decimal INVUNIQ)
        {
            var table = adapter.FindById(INVUNIQ);
            return (OEINVHRow) table.Rows[0];
        }
    }
}
