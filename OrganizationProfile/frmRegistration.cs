using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        public frmRegistration()
        {
            InitializeComponent();
        }
        frmConfirmation frm = new frmConfirmation();

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
           
        }
        public class StudentInformationClass
        {
            public static int SetStudentNo = 0;
            public static int SetContactNum = 0;
            public static int SetAge = 0;
            public static string SetProgram = " ";
            public static string SetGender = " ";
            public static string SetBirthday = " ";
            public static string SetFullName = " ";
        }
        public long StudentNumber(string studNum)
        {
            try
            {
                if (Regex.IsMatch(studNum, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(studNum);
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid Student Number.");
                }
            } catch (IndexOutOfRangeException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            /*if (txtStudentNumber.Text == "")
            {
                FormatException("Please enter your student number properly.");
            }
            else
            {
                _StudentNo = long.Parse(studNum);
            }*/
            
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                IndexOutOfRangeException("Invalid contact number.");
            }
            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {   
                ArgumentNullException("Invalid full name.");
            }

            return _FullName;
        }

        public int Age(string age)
        {
            
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            } else
            {
                //OverFlowException("Invalid age.");
                throw new FormatException();
            }

            return _Age;
        }
        public void FormatException(string message)
        {
            MessageBox.Show(message);
        }
        public void ArgumentNullException(string message) 
        { 
            MessageBox.Show(message);
        }
        public void OverFlowException(string message)
        {
            MessageBox.Show(message);
        }
        public void IndexOutOfRangeException(string message)
        {
            MessageBox.Show(message);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = (int)StudentNumber(txtStudentNumber.Text); 
            StudentInformationClass.SetProgram = cbPrograms.Text;
            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNum = (int)ContactNo(txtContactNo.Text); 
            StudentInformationClass.SetAge = Age(txtAge.Text);
            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy- MM-dd");
           
            try
            {
                if (cbPrograms.Text == "")
                {
                    ArgumentNullException("Please choose a program.");
                    
                } else if (cbGender.Text == "")
                {
                    ArgumentNullException("Please choose your respective gender.");
                }

            } catch (ObjectDisposedException ex) 
            {
                MessageBox.Show("Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Please try again.");
            }
            frm.Show();
            string FrmFileName = txtStudentNumber.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName)))
            {

                /* outputFile.WriteLine( "Student No.: " + StudentNumber(txtStudentNumber.Text.ToString())
                     + "\nFull Name: " + FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text));*/
                string[] information = {"Student No: " + txtStudentNumber.Text, "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + ", " +
                     txtMiddleInitial.Text, "Program: " + cbPrograms.Text, "Age: " + txtAge.Text, "Birthday: " + datePickerBirthday.Value.ToString("yyyy-MM-dd"), "Contact No. : " + txtContactNo.Text};
                foreach (string i in information)
                {
                    outputFile.WriteLine(i);

                }
            }
        }

        private void StudNum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
