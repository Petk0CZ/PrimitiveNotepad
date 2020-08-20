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
using System.Threading;

namespace PrimitiveNotepad
{
    public partial class PrimitiveNotepad : Form
    {
        string initialsavepath = @"C:\\";


        string savepath = @"C:\\";
        public PrimitiveNotepad()
        {
            InitializeComponent();
        }
        //new file
        private void Button1_Click(object sender, EventArgs e)
        {
           if ( MessageBox.Show("Create new file? Unsaved changes will be lost", "New", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                richTextBox1.Text = "";
                savepath = initialsavepath;
                saveb.Enabled = false;
            }
            else
            {
                
            }
        }
        //save file
        private void Saveb_Click(object sender, EventArgs e)
        {
            File.WriteAllText(savepath, richTextBox1.Text);
        }
        //save as
        private void Saveasb_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            
        }
        //Savefile dialog
        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog1.FileName,richTextBox1.Text);
            savepath = saveFileDialog1.FileName;
            saveb.Enabled = true;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
