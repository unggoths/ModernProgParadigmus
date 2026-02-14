using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpP
{
    public static class LinearResolve
    {
        public static string SolveLinear(double a, double b)
        {
            if (a == 0)
                return (b== 0) ? ResolveResults.Intifity : ResolveResults.NoSolution;

            var res = -b / a;
            return $"x = {Math.Abs(res)}";
        }

    }
}
