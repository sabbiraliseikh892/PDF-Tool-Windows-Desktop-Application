
namespace PdfProcessor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMergePdf = new System.Windows.Forms.Button();
            this.lstSelectedFiles = new System.Windows.Forms.ListBox();
            this.btnselectpdf = new System.Windows.Forms.Button();
            this.btnImagesToPdf = new System.Windows.Forms.Button();
            this.btnCompressPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMergePdf
            // 
            this.btnMergePdf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMergePdf.Location = new System.Drawing.Point(707, 51);
            this.btnMergePdf.Name = "btnMergePdf";
            this.btnMergePdf.Size = new System.Drawing.Size(114, 29);
            this.btnMergePdf.TabIndex = 0;
            this.btnMergePdf.Text = "Merge Pdf";
            this.btnMergePdf.UseVisualStyleBackColor = true;
            this.btnMergePdf.Click += new System.EventHandler(this.btnMergePdf_Click);
            // 
            // lstSelectedFiles
            // 
            this.lstSelectedFiles.FormattingEnabled = true;
            this.lstSelectedFiles.ItemHeight = 20;
            this.lstSelectedFiles.Location = new System.Drawing.Point(38, 41);
            this.lstSelectedFiles.Name = "lstSelectedFiles";
            this.lstSelectedFiles.Size = new System.Drawing.Size(413, 104);
            this.lstSelectedFiles.TabIndex = 1;
            // 
            // btnselectpdf
            // 
            this.btnselectpdf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnselectpdf.Location = new System.Drawing.Point(519, 51);
            this.btnselectpdf.Name = "btnselectpdf";
            this.btnselectpdf.Size = new System.Drawing.Size(121, 29);
            this.btnselectpdf.TabIndex = 2;
            this.btnselectpdf.Text = "Select Pdf";
            this.btnselectpdf.UseVisualStyleBackColor = true;
            this.btnselectpdf.Click += new System.EventHandler(this.btnselectpdf_Click);
            // 
            // btnImagesToPdf
            // 
            this.btnImagesToPdf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImagesToPdf.Location = new System.Drawing.Point(879, 51);
            this.btnImagesToPdf.Name = "btnImagesToPdf";
            this.btnImagesToPdf.Size = new System.Drawing.Size(117, 29);
            this.btnImagesToPdf.TabIndex = 3;
            this.btnImagesToPdf.Text = "Images To Pdf";
            this.btnImagesToPdf.UseVisualStyleBackColor = true;
            this.btnImagesToPdf.Click += new System.EventHandler(this.btnImagesToPdf_Click);
            // 
            // btnCompressPdf
            // 
            this.btnCompressPdf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompressPdf.Location = new System.Drawing.Point(1044, 50);
            this.btnCompressPdf.Name = "btnCompressPdf";
            this.btnCompressPdf.Size = new System.Drawing.Size(177, 29);
            this.btnCompressPdf.TabIndex = 4;
            this.btnCompressPdf.Text = "Compress Pdf";
            this.btnCompressPdf.UseVisualStyleBackColor = true;
            this.btnCompressPdf.Click += new System.EventHandler(this.btnCompressPdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1359, 450);
            this.Controls.Add(this.btnCompressPdf);
            this.Controls.Add(this.btnImagesToPdf);
            this.Controls.Add(this.btnselectpdf);
            this.Controls.Add(this.lstSelectedFiles);
            this.Controls.Add(this.btnMergePdf);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Develop By SAS   #Email Me 👉 ✉️ sabbir.comp@gmail.com For Project or Anything El" +
    "se.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMergePdf;
        private System.Windows.Forms.ListBox lstSelectedFiles;
        private System.Windows.Forms.Button btnselectpdf;
        private System.Windows.Forms.Button btnImagesToPdf;
        private System.Windows.Forms.Button btnCompressPdf;
    }
}

