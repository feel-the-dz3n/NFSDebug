using NFSDebug.Games;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NFSDebug.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (var g in Global.BlackboxGames)
            {
                var m = g.Functions;
                StringBuilder a = new StringBuilder();
                foreach(var f in m)
                {
                    a.AppendLine(f.FriendlyName);
                }
                MessageBox.Show(a.ToString(), g.GameName);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var p in Process.GetProcesses())
            {
                foreach (var g in Global.BlackboxGames)
                    if (p.ProcessName.ToLower().Contains(g.ExecutableName))
                        lbProcesses.Items.Add(new BBProcess(p, g));
            }
        }
    }
}
