using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongPasswordGenerator
{
    public static class ProgrssBarExtension
    {
        [DllImport("uxtheme.dll")]

        static extern int SetWindowTheme(IntPtr hWnd, string appName="", string partList="");


       //extesion method that add a method to the progressbar class
        public static void DisableStyle(this ProgressBar progressBar)
        {
            SetWindowTheme(progressBar.Handle);
        }
    }
}
