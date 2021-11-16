using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokPrzestepny
{
    class Obliczenia
    {
        public static bool CzyPrzestepny(int r)
        {
            if((r % 4 == 0 && r % 100 != 0) || r % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
