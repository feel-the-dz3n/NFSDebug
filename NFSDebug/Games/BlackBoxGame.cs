using Binarysharp.MemoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSDebug.Games
{
    public class BlackBoxGame
    {
        public string GameName = "Need for Speed: Unknown (Black Box, 2019)";
        public string ExecutableName = "nfs.exe";
        public MemorySharp Mem = null;

        public BlackBoxGame() => throw new NotSupportedException();

        public void GoFreeroam()
        {
            if (this is MWBB)
                Mem[(IntPtr)0x56C5B0, false].Execute();
            else
                throw new NotImplementedException($"Address for game '{GameName}' is not found");
        }
    }
}
