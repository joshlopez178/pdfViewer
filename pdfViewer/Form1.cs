//Created by Josh Lopez on 07/31/2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectBTN_Click(object sender, EventArgs e)
        {
            //adobe reader should be installed on your pc

            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {

                axAcroPDF1.src = fd.FileName;

            }
            else
            {

                MessageBox.Show("Select a File");
            
            }
        }
    }
}
