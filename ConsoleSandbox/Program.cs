using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volare.PaperBoy.ConsoleSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Volare.PaperBoy.ExternalModels.PaperFinder.GetPaper(DateTime.Now.AddDays(-2));
            }
            catch(Exception ex)
            {

            }

        }
    }
}
