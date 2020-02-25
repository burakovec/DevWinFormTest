using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevWinFormTest
{
    public partial class ucPermission : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucPermission _instance;
        public static ucPermission Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPermission();
                return _instance;
            }
        }
        public ucPermission()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }
    }
}
