using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSDebug.Games
{
    public class UG1 : BlackBoxGame
    {
        public UG1(System.Diagnostics.Process p)
              => SetGame("Need for Speed: Underground (Black Box)", "speed.exe", p);
    }
}
