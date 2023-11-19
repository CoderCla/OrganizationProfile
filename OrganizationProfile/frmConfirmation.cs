using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OrganizationProfile.frmRegistration;

namespace OrganizationProfile
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            /*frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.StudentInformationClass.SetFullName = frmRegistration.FullName(frmRegistration.txtLastName.Text, frmRegistration.txtFirstName.Text, frmRegistration.txtMiddleInitial.Text);
            frmRegistration.StudentInformationClass.SetStudentNo = (int)frmRegistration.StudentNumber(frmRegistration.txtStudentNumber.Text);
            frmRegistration.StudentInformationClass.SetProgram = frmRegistration.cbPrograms.Text;*/
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString(); 
            lblName.Text = StudentInformationClass.SetFullName;
            lblProgram.Text = StudentInformationClass.SetProgram; 
            lblBirthday.Text = StudentInformationClass.SetBirthday; 
            lblGender.Text = StudentInformationClass.SetGender; 
            lblContactNo.Text = StudentInformationClass.SetContactNum.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();

        }
    }
}
