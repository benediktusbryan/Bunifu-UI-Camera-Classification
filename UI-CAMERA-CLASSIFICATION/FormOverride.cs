using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHELL_HIKROBOT0
{
    public partial class FormOverride : Form
    {
        private FormMain _formMain;

        public FormOverride(FormMain formMain)
        {
            InitializeComponent();
            _formMain = formMain;
        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            if (bunifuDropdown1.Text != "" && bunifuDropdown1.Text != null)
            {
                _formMain.setSKUTypeOverride(bunifuDropdown1.Text);
                this.Close();
            }
            else
            {
                bunifuSnackbar1.Show(this, "Choose SKU Type First!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 1000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter);
            }
        }
    }
}
