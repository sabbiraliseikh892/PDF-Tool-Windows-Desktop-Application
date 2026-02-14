using PdfActivity.Facade;
using PdfActivity.Interfaces;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfActivity.Services
{
    public class PdfMergeService : IPdfAction
    {
        private readonly List<string> _inputFiles;
        private readonly string _outputFile;
        public PdfMergeService(List<string> inputFiles, string outputFile)
        {
            _inputFiles = inputFiles;
            _outputFile = outputFile;
        }
        public async Task ExecuteAsync()
        {
            await Task.Run(() =>
            {
                PdfDocument output = new PdfDocument();

                foreach (var file in _inputFiles)
                {
                    using PdfDocument input =
                        PdfReader.Open(file, PdfDocumentOpenMode.Import);

                    for (int i = 0; i < input.PageCount; i++)
                        output.AddPage(input.Pages[i]);
                }

                output.Save(_outputFile);
            });
        }
    }
}
