using System;
using System.Windows.Forms;

namespace ApartmentRental_v2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (AuthForm auth = new AuthForm())
            {
                if (auth.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }
        }
    }
}
