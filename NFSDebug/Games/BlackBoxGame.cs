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

        public List<GameMethod> Functions
        {
            get
            {
                List<GameMethod> result = new List<GameMethod>();

                foreach (var m in this.GetType().GetMethods())
                    if (m.Name.StartsWith("Func"))
                        result.Add(new GameMethod(m));

                return result;
            }
        }

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

        public void FuncGoFreeroam()
        {
            if (this is MWBB)
                Mem[(IntPtr)0x56C5B0, false].Execute();
            else
                throw new NotImplementedException($"Address for game '{GameName}' is not found");
        }

        public void FuncTe_stFunctionIsSuper()
        {
            
        }

        public void Dispose()
        {
            if(Mem != null)
                Mem.Dispose();
        }
    }
}
