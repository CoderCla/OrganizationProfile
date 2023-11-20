using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class FrmStudentRecord : Form
    {
        public string path;
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
        public void DisplayToList()
        {
            try { 
            openFileDialog1.InitialDirectory = @"C:\Users\Maita Calderon\Documents";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvViewRecord.Items.Add(_getText);
                }
            }
            } catch (FileNotFoundException)
            {
                MessageBox.Show("File not chosen.");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lvViewRecord.Items.Count == 0)
            {
                MessageBox.Show("Fetch data first before uploading.");
                               
            } else
            {
                lvViewRecord.Items.Clear();
                MessageBox.Show("Successfully Uploaded!");
            }
            
        }

        private void btnRegisterReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
