using PdfActivity.Interfaces;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfActivity.Services
{

    public  class ImageToPdfService : IPdfAction
    {
        private readonly List<string> _images;
        private readonly string _outputPdf;
        public ImageToPdfService(List<string> images, string outputPdf)
        {
            _images = images;
            _outputPdf = outputPdf;
        }
        public async Task ExecuteAsync()
        {
            await Task.Run(() =>
            {
                PdfDocument document = new PdfDocument();

                foreach (var img in _images)
                {
                    PdfPage page = document.AddPage();

                    using XImage image = XImage.FromFile(img);
                    page.Width = image.PixelWidth;
                    page.Height = image.PixelHeight;

                    using XGraphics gfx = XGraphics.FromPdfPage(page);
                    gfx.DrawImage(image, 0, 0);
                }

                document.Save(_outputPdf);
            });
        }
    }
}
