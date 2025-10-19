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
    public partial class detailsForm : Form
    {
        public detailsForm(string mobile, string firstname, string lastname,
                   string status, string birthday, string location, string sex, Image img)
        {
            InitializeComponent();
            txtMobile.Text = mobile;
            txtFirstname.Text = firstname;
            txtLastname.Text = lastname;
            txtStatus.Text = status;
            txtBirthday.Text = birthday;
            txtLocation.Text = location;
            txtSex.Text = sex;
            pictureBox.Image = img;
        }

        public string Mobile
        {
            get { return txtMobile.Text; }
            set { txtMobile.Text = value; }
        }

        public string Firstname
        {
            get { return txtFirstname.Text; }
            set { txtFirstname.Text = value; }
        }

        public string Lastname
        {
            get { return txtLastname.Text; }
            set { txtLastname.Text = value; }
        }

        public string Status
        {
            get { return txtStatus.Text; }
            set { txtStatus.Text = value; }
        }

        public string Birthday
        {
            get { return txtBirthday.Text; }
            set { txtBirthday.Text = value; }
        }

        public string Location
        {
            get { return txtLocation.Text; }
            set { txtLocation.Text = value; }
        }

        public string Sex
        {
            get { return txtSex.Text; }
            set { txtSex.Text = value; }
        }

        public Image ProfileImage
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

    }
}
