using PdfActivity.Facade;
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

namespace PdfProcessor
{
    public partial class Form1 : Form
    {
        List<string> selectedFiles = new List<string>();
        PdfFacade pdf = new PdfFacade();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnselectpdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "PDF & Images|*.pdf;*.jpg;*.jpeg;*.png"
                //Filter = "PDF & Images|*.pdf;*.jpg;*.jpeg;*.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFiles.Clear();
                lstSelectedFiles.Items.Clear();

                foreach (var file in ofd.FileNames)
                {
                    selectedFiles.Add(file);
                    lstSelectedFiles.Items.Add(file);
                }
            }
        }

        private async void btnMergePdf_Click(object sender, EventArgs e)
        {
            var pdfFiles = selectedFiles
         .Where(f => f.EndsWith(".pdf"))
         .ToList();

            if (pdfFiles.Count < 2)
            {
                MessageBox.Show("Select at least 2 PDF files");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            btnMergePdf.Enabled = false;
            await pdf.MergeAsync(pdfFiles, sfd.FileName);
            btnMergePdf.Enabled = true;

            MessageBox.Show("PDFs merged successfully!");

        }

        private async void btnImagesToPdf_Click(object sender, EventArgs e)
        {
            var images = selectedFiles
        .Where(f => f.EndsWith(".jpg") || f.EndsWith(".png"))
        .ToList();

            if (!images.Any())
            {
                MessageBox.Show("Please select image files");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            btnImagesToPdf.Enabled = false;
            await pdf.ImagesToPdfAsync(images, sfd.FileName);
            btnImagesToPdf.Enabled = true;

            MessageBox.Show("Images converted to PDF successfully!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnCompressPdf_Click(object sender, EventArgs e)
        {
            var pdfFiles = selectedFiles
        .Where(f => f.EndsWith(".pdf"))
        .ToList();

            if (pdfFiles.Count != 1)
            {
                MessageBox.Show("Select exactly one PDF to compress");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            btnCompressPdf.Enabled = false;
            await pdf.CompressAsync(pdfFiles[0], sfd.FileName);
            btnCompressPdf.Enabled = true;

            MessageBox.Show("PDF compressed successfully!");
        }
    }
}
