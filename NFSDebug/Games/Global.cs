using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSDebug.Games
{
    public class Global
    {
        public static List<BlackBoxGame> BlackboxGames = new List<BlackBoxGame>()
        {
            new UG1(null),
            new UG2(null),
            new MWBB(null),
            new Carbon(null)
            // undercover
        };
    }
}
