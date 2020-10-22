using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4990ExampleApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //form1.MaximizeBox = false;
            //form1.Size = new Size(658, 615);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form1 = new Form1();
            Application.Run(form1);
        }
    }
}
