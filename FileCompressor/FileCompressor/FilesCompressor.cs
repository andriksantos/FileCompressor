using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SevenZip;
namespace FileCompressor
{
    public partial class FIleCompressor : Form
    {
        public FIleCompressor()
        {
            InitializeComponent();
        }

        private void FIleCompressor_Load(object sender, EventArgs e)
        {
            ShadowFIleCompressor.SetShadowForm(this);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExtractBrowseDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtExtractDirectory.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnxtractBrowseArchive_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtExtractArchive.Text = openFileDialog1.FileName;
        }

        private void BtnExtraction_Click(object sender, EventArgs e)
        {
            SevenZipExtractor.SetLibraryPath(Application.StartupPath + "\\7z.dll");
            using (SevenZipExtractor tmp = new SevenZipExtractor(txtExtractArchive.Text))
            {
                tmp.ExtractArchive(txtExtractDirectory.Text);
            }
            MessageBox.Show("Extraction Finished ...");
        }
    }
}
