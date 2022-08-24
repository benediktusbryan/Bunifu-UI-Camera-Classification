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
    public partial class FormConfirmation : Form
    {
        private FormMain _formMain;

        public FormConfirmation(FormMain formMain)
        {
            InitializeComponent();
            _formMain = formMain;
        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            _formMain.addressPLCChangeState = "";
            this.Close();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            //FormMain FormMain = new FormMain();
            _formMain.changeStatePLCAddress();
            this.Close();
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            //FormMain FormMain = new FormMain();
            _formMain.addressPLCChangeState = "";
            this.Close();
        }
    }
}
