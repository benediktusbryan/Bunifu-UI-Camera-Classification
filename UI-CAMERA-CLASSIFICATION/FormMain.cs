using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SHELL_HIKROBOT0
{
    public partial class FormMain : Form
    {
        public String addressPLCChangeState;
        String brainTestFileName;
        Bitmap brainTestImage;

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            PictureBoxCamera.Image = null;
            PictureBoxBrainTest.Image = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            //Dispose();
            this.Close();
        }

        private void bunifuIconButton3_Click(object sender, EventArgs e)
        {
            if (bunifuPanel1.Size.Width != 233)
            {
                bunifuPanel1.Size = new Size(233, bunifuPanel1.Size.Height);
                IconButtonExpandMenu.Location = new Point(170, IconButtonExpandMenu.Location.Y);
                bunifuPanel2.Visible = true;
            }
            else
            {
                bunifuPanel1.Size = new Size(90, bunifuPanel1.Size.Height);
                IconButtonExpandMenu.Location = new Point(20, IconButtonExpandMenu.Location.Y);
                bunifuPanel2.Visible = false;
            }
        }

        private void bunifuShapes4_Click(object sender, EventArgs e)
        {
            addressPLCChangeState = "W0.01";
            Console.WriteLine(addressPLCChangeState);
            FormConfirmation FormConfirmation = new FormConfirmation(this);
            FormConfirmation.ShowDialog();
        }


        public void changeStatePLCAddress()
        {
            Console.WriteLine(addressPLCChangeState);
            if (addressPLCChangeState == "W0.01")
            {
                if (ShapesTriggerCamera.FillColor != Color.Green)
                {
                    ShapesTriggerCamera.FillColor = Color.Green;
                }
                else
                {
                    ShapesTriggerCamera.FillColor = Color.Gainsboro;
                }
            }
            addressPLCChangeState = "";
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 0;

            bunifuPanel1.Size = new Size(90, bunifuPanel1.Size.Height);
            IconButtonExpandMenu.Location = new Point(20, IconButtonExpandMenu.Location.Y);
            bunifuPanel2.Visible = false;
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 1;

            bunifuPanel1.Size = new Size(90, bunifuPanel1.Size.Height);
            IconButtonExpandMenu.Location = new Point(20, IconButtonExpandMenu.Location.Y);
            bunifuPanel2.Visible = false;

        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 2;

            bunifuPanel1.Size = new Size(90, bunifuPanel1.Size.Height);
            IconButtonExpandMenu.Location = new Point(20, IconButtonExpandMenu.Location.Y);
            bunifuPanel2.Visible = false;

        }

        private void bunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            FormOverride FormOverride = new FormOverride(this);
            FormOverride.ShowDialog();
        }

        public void setSKUTypeOverride(String SKUType)
        {
            LabelSKUType.Text = SKUType;
            CircleProgressConfidenceDashboard.Value = 100;
        }

        private void bunifuTextBox4_Click(object sender, EventArgs e)
        {
            PictureBoxBrainTest.Image = null;
            if (brainTestImage != null)
            {
                brainTestImage.Dispose();
            }
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file_LoadImage in openFileDialog1.FileNames)
                {
                    try
                    {
                        TextBoxDirectoryBrainTest.Text = brainTestFileName = file_LoadImage;
                        brainTestImage = new Bitmap(file_LoadImage);
                        PictureBoxBrainTest.Image = brainTestImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("there is an Error");
                    }
                }
            }
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton26_Click_1(object sender, EventArgs e)
        {
            if (TextBoxDirectoryBrainTest.Text != "" && TextBoxDirectoryBrainTest.Text != null)
            {
                // scoring function
            }
            else
            {
                bunifuSnackbar1.Show(this, "Choose Image First!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 1000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }
        }
    }
}
