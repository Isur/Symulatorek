using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerwazy
{
    static class Consts
    {
        public static char[,] Polarization = new char[2, 2] { {'-','|' }, {'/', '\\' } };
        public static char[] Base = new char[2] { '+', 'x' };
        public static char[] Result = new char[2] { 'N', 'R' };

        public static long Power(int x, int y)
        {
            long result = 1;

            for(int i=0; i<y; i++)
            {
                result *= x;
            }

            return result;
        }
    }
}
