using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        

        static void Main()
        {
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form1());
            Class1 cs1 = new Class1();
            
            //cs1.Insert();
        }
    }
}
