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
            string year;
            year = DateTime.Today.Year.ToString();
            CopyRight.Text = "Copyright © " + year +  " All rights reserved";
            ShadowFIleCompressor.SetShadowForm(this);
            description.Text = "compress files quickly and easily with File Compressor just select the file and place the address where you want to save it already compressed. Works the same way when unzipping";
        }
        //CONTROL EXIT
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //EXTRACTION
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

        void CleanTxtExtraction()
        {
            txtExtractArchive.Text = "";
            txtExtractDirectory.Text = "";
        }
        private void BtnExtraction_Click(object sender, EventArgs e)
        {
            if (txtExtractArchive.Text == "" && txtExtractDirectory.Text == "")
            {
                MessageBox.Show("Select your file please!", "Information");
            }
            else {
                SevenZipExtractor.SetLibraryPath(Application.StartupPath + "\\7z.dll");
                using (SevenZipExtractor tmp = new SevenZipExtractor(txtExtractArchive.Text))
                {
                    tmp.ExtractArchive(txtExtractDirectory.Text);
                }
                MessageBox.Show("Extraction Finished ...", "Information");
                CleanTxtExtraction();
            }
        }
        //COMPRESSION
        void CleanTxtCompression()
        {
            txtCompressDirectory.Text = "";
            txtCompressOutput.Text = "";
        }
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtCompressDirectory.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnBrowseOut_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                txtCompressOutput.Text = saveFileDialog1.FileName;
        }

        private void BtnCompression_Click(object sender, EventArgs e)
        {
            if (txtCompressDirectory.Text == "" && txtCompressOutput.Text == "")
            {
                MessageBox.Show("Select your file please!", "Information");
            }
            else {
                SevenZipCompressor.SetLibraryPath(Application.StartupPath + "\\7z.dll");
                SevenZipCompressor tmp = new SevenZipCompressor();
                tmp.ArchiveFormat = OutArchiveFormat.SevenZip;
                tmp.CompressionLevel = CompressionLevel.Ultra;
                tmp.CompressDirectory(txtCompressDirectory.Text, txtCompressOutput.Text);
                MessageBox.Show("Compression Finished ...","Information");
                CleanTxtCompression();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://andriksantos.github.io");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/andrik_rsm");
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/andriksantos/FileCompressor");
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/andriksantos");
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://andriksantos.github.io");
        }
    }
}
