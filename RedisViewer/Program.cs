using RedisViewer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace RedisViewer
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var connections = GetConnections();
            if (connections.Any())
            {
                Application.Run(new Start());
            }
        }

        private static Dictionary<string, string> GetConnections()
        {
            var connections = Settings.GetConnections();
            if (!connections.Any() || (connections.Count == 1 && connections.Count(x => x.Key == "Name") == 1))
            {
                MessageBox.Show("Please add your Redis connections to the app.config file before you start the application", "No connections", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                connections.Clear();
            }

            return connections;
        }
    }
}