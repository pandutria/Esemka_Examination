using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_Examination
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void disableMenu(bool e)
        {
            if (DataStorage.roleId == 1)
            {
                menuExit.Enabled = e;
                menuLogout.Enabled = e;
                menuUser.Enabled = e;
                menuType.Enabled = e;
                menuRoom.Enabled = e;
                menuViewCase.Enabled = e;
                menuNewCase.Enabled = e;
                menuSchedule.Enabled = e;
            }

            if (DataStorage.roleId == 2)
            {
                menuExit.Enabled = e;
                menuLogout.Enabled = e;
                menuUser.Enabled = !e;
                menuType.Enabled = !e;
                menuRoom.Enabled = !e;
                menuViewCase.Enabled = e;
                menuNewCase.Enabled = e;
                menuSchedule.Enabled = e;

            }
        }

        private void viewCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fvc = new FormViewCase();
            fvc.Show();
            fvc.MdiParent = this;
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            disableMenu(true);
            this.IsMdiContainer = true;

            //label1.Visible = false;
        }

        private void menuUser_Click(object sender, EventArgs e)
        {
            var fu = new FormUser();
            fu.Show();
            fu.MdiParent = this;
        }

        private void menuType_Click(object sender, EventArgs e)
        {
            var ft = new FormType();
            ft.Show();
            ft.MdiParent = this;
        }

        private void menuRoom_Click(object sender, EventArgs e)
        {
            var fr = new FormRoom();
            fr.Show();
            fr.MdiParent = this;
        }

        private void menuNewCase_Click(object sender, EventArgs e)
        {
            var fn = new FormNewCase();
            fn.Show();
            fn.MdiParent = this;
        }

        private void menuSchedule_Click(object sender, EventArgs e)
        {
            var fs = new FormSchedule();
            fs.Show();
            fs.MdiParent = this;
        }
    }
}
