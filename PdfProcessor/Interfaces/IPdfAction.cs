using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfActivity.Interfaces
{
    public  interface IPdfAction
    {
        Task ExecuteAsync();
    }
}
