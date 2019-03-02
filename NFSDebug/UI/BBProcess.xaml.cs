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
    /// <summary>
    /// Interaction logic for BBProcess.xaml
    /// </summary>
    public partial class BBProcess : UserControl
    {
        private System.Diagnostics.Process process = null;
        public Games.BlackBoxGame BBGame = null;

        public BBProcess(System.Diagnostics.Process p = null, Games.BlackBoxGame game = null)
        {
            InitializeComponent();

            BBGame = game;
            Process = p;
        }

        public Process Process
        {
            get => process;
            set
            {
                process = value;

                if(value != null)
                    pName.Text = value.ProcessName;

                if (BBGame != null)
                    pGameName.Text = BBGame.GameName;
            }
        }
    }
}
