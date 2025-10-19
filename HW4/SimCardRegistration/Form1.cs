using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCardRegistration
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sex = radioMale.Checked ? "Male" : "Female";

            detailsForm detailsForm = new detailsForm(
                maskedTextBox1.Text,
                txtFirstname.Text,
                txtLastname.Text,
                comboBoxStatus.Text,
                dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                txtLocation.Text,
                sex,
                pictureBox1.Image
            );

            detailsForm.Show();
        }
    }
    }
