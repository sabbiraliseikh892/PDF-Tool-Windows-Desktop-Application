using PdfActivity.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfActivity.Services
{
    public class PdfCompressService : IPdfAction
    {
        private readonly string _input;
        private readonly string _output;
        public PdfCompressService(string input, string output)
        {
            _input = input;
            _output = output;
        }
        public async Task ExecuteAsync()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "gswin64c",
                    Arguments =
                        "-sDEVICE=pdfwrite -dCompatibilityLevel=1.4 " +
                        "-dPDFSETTINGS=/ebook -dNOPAUSE -dQUIET -dBATCH " +
                        $"-sOutputFile=\"{_output}\" \"{_input}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            await process.WaitForExitAsync();
        }
    }
}
