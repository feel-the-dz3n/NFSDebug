using Binarysharp.MemoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSDebug.Games
{
    public class BlackBoxGame : IDisposable
    {
        public string GameName = "Need for Speed: Unknown (Black Box, 2019)";
        public string ExecutableName = "nfs";
        public MemorySharp Mem = null;

        // public BlackBoxGame() => throw new NotSupportedException();

        public void SetGame(string name, string exe, System.Diagnostics.Process p)
        {
            if (Mem != null)
                return;

            GameName = name;
            if (exe.EndsWith(".exe"))
                exe = exe.Remove(exe.Length - ".exe".Length, ".exe".Length);
            ExecutableName = exe;
            
            if (p != null)
                Mem = new MemorySharp(p);
            else
                Mem = null;
        }

        public void GoFreeroam()
        {
            if (this is MWBB)
                Mem[(IntPtr)0x56C5B0, false].Execute();
            else
                throw new NotImplementedException($"Address for game '{GameName}' is not found");
        }

        public void Dispose()
        {
            if(Mem != null)
                Mem.Dispose();
        }
    }
}
