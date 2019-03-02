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
        {
            GameName = "Need for Speed Carbon (Black Box)";
            ExecutableName = "nfsc.exe";
            Mem = new Binarysharp.MemoryManagement.MemorySharp(p);
        }
    }
}
