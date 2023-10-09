using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile_Agustin
{
    public partial class FrmConfirmation : Form
    {
        public FrmConfirmation()
        {
            InitializeComponent();
        }

        private void FrmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNumber.Text = StudentInformationClass.SetStudentNum.ToString();
            lblName.Text = StudentInformationClass.SetFullname.ToString();
            lblProgram.Text = StudentInformationClass.SetProgram.ToString();
            lblBirthday.Text = StudentInformationClass.SetBirthday.ToString();
            lblGender.Text = StudentInformationClass.SetGender.ToString();
            lblContactNumber.Text = StudentInformationClass.SetContactNum.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
