using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSDebug.Games
{
    public class Carbon : BlackBoxGame
    {
        public Carbon(System.Diagnostics.Process p) 
            => SetGame("Need for Speed Carbon (Black Box)", "nfsc.exe", p);
    }
}
