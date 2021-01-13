using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capsule_Er_Dhakna
{
    public class CR
    {
        private string megaKnight;
        public CR(string avalue)
        {
            megaKnight = avalue;
        }
        public string Minipekka
        {
            get
            {
                return megaKnight;
            }
        }
    }
    public class CRMF
    {
        public static int Main(string[] args)
        {
            CR d = new CR("Elite Barbarian");
            Console.WriteLine("6 Elixir er moddhe amar shobcheye pochondo " + d.Minipekka);
            Console.ReadLine();
            return 0;
        }
    }
}
