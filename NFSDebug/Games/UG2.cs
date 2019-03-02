using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSDebug.Games
{
    public class UG2 : BlackBoxGame
    {
        public UG2(System.Diagnostics.Process p)
              => SetGame("Need for Speed: Underground 2 (Black Box)", "speed.exe", p);
    }
}
