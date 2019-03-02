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
        {
            GameName = "Need for Speed: Underground 2 (Black Box)";
            ExecutableName = "speed.exe"; // change the name
            Mem = new Binarysharp.MemoryManagement.MemorySharp(p);
        }
    }
}
