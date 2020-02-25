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
    public partial class ucUser : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucUser _instance;
        public static ucUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUser();
                return _instance;
            }
        }
        public ucUser()
        {
            InitializeComponent();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void jobsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }
    }
}
