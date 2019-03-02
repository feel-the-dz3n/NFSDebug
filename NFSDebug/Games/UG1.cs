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
        {
            GameName = "Need for Speed: Underground (Black Box)";
            ExecutableName = "speed.exe";
            Mem = new Binarysharp.MemoryManagement.MemorySharp(p);
        }
    }
}
