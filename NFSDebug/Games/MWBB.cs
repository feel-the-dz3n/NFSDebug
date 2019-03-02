using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSDebug.Games
{
    /// <summary>
    /// Most Wanted (Black Box) (2005)
    /// </summary>
    public class MWBB : BlackBoxGame
    {
        public MWBB(System.Diagnostics.Process p)
               => SetGame("Need for Speed: Most Wanted (Black Box, 2005)", "speed.exe", p);

        public void FuncSpecialMWFunc_243_142()
        {

        }
    }
}
