using PdfActivity.Interfaces;
using PdfActivity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfActivity.Facade
{
    public class PdfFacade
    {
        public Task MergeAsync(List<string> files, string output)
        => new PdfMergeService(files, output).ExecuteAsync();
        public Task ImagesToPdfAsync(List<string> images, string output)
       => new ImageToPdfService(images, output).ExecuteAsync();

        public Task CompressAsync(string input, string output)
            => new PdfCompressService(input, output).ExecuteAsync();
    }
}
