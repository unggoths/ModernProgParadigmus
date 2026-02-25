using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpP
{
    public static class LinearResolve
    {
        public static string SolveQuadratic(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                    return c == 0 ? QuadraticFunctionExistingResults.InfiniteSolutions : QuadraticFunctionExistingResults.NoSolution;

                var x = -c / b;
                return $"x = {x}";
            }

            var Disc = b * b - 4 * a * c;

            switch (Disc)
            {
                case < 0:
                    return QuadraticFunctionExistingResults.NoSolution;
                case 0:
                {
                    var x = -b / (2 * a);
                    return $"x = {x}";
                }
            }

            var sqrtDisc = Math.Sqrt(Disc);
            var x1 = (-b + sqrtDisc) / (2 * a);
            var x2 = (-b - sqrtDisc) / (2 * a);

            return $"x1 = {x1}, x2 = {x2}";

        }
    }

}

