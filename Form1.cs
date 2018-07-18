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
namespace DataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //CREATE FILE HANDLE FOR INPUT
                StreamReader dataFile;

                //OPENFILE FOR INPUT
                dataFile = File.OpenText(openFileDialog1.FileName);

                string strFormat = "{0, -20}       {1, -15}       {2, -13}      {3, -13}       {4, -45}        {5, -17}     {6, -12}    {7, -2}";

                dataFile.ReadLine();
                
                //LOOP UNTIL END OF THE FILE
                while (dataFile.EndOfStream == false)
                {

                    string[] spec = dataFile.ReadLine().Split(';');
                    listBox1.Items.Add(string.Format(strFormat, spec[0] , spec[1], spec[2], spec[3], spec[4], spec[5], spec[6], spec[7]));
                    
                }
                
                                   
                
                dataFile.Close();

            }

        }

               
            
        
    }
}
