using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevWinFormTest
{
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void acUser_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucUser.Instance))
            {
                container.Controls.Add(ucUser.Instance);
                ucUser.Instance.Dock = DockStyle.Fill;
                ucUser.Instance.BringToFront();
            }
            ucUser.Instance.BringToFront();
        }

        private void acPermission_Click(object sender, EventArgs e)
        {
            if (container.Controls.Contains(ucPermission.Instance))
            {
                container.Controls.Add(ucPermission.Instance);
                ucPermission.Instance.Dock = DockStyle.Fill;
                ucPermission.Instance.BringToFront();
            }
            ucPermission.Instance.BringToFront();
        }
    }
}
