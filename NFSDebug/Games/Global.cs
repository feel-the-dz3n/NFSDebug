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

        public static string GetFriendlyName(string initial, string source)
        {
            StringBuilder a = new StringBuilder();

            source = source.Remove(0, initial.Length);

            for(int i = 0; i < source.Length; i++)
            {
                var c = source[i];

                if (i != 0 && char.IsUpper(c))
                    a.Append(' ');

                if (c == '_')
                    c = ' ';

                a.Append(c);
            }

            return a.ToString();
        }
    }
}
