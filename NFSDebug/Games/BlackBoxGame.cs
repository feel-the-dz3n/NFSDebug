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
                Mem[(IntPtr)0xFFFFFFFF].Execute();
            else if (this is Carbon)
                Mem[(IntPtr)0xFFFFFFFF].Execute();
            else
                throw new NotImplementedException($"Address for game '{GameName}' is not found");
        }
    }
}
