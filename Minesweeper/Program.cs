using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjektProgram
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static Form1 Form;

        static void Main()
        {
            Form = new Form1();
            Application.Run(Form);
        }

    }


}
