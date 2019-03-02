using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NFSDebug.Games
{
    public class GameMethod
    {
        public string FriendlyName;
        public MethodInfo Method;

        public GameMethod(MethodInfo m)
        {
            FriendlyName = Global.GetFriendlyName("Func", m.Name);
            Method = m;
        }
    }
}
