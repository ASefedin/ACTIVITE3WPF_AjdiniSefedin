using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ACTIVITE_3WPF_AjdiniSefedin
{
    class MethodesDuProjet
    {
        public void ResoudTrinome(double a, double b, double c, out double x1, out double x2, out string message)
        {
            x1 = 0;
            x2 = 0;
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                message = "Il n'y a pas de solution réelle";

            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                message = "Il y a une solution " + x1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                message = "Il y a deux solutions " + x1 + " et " + x2;
            }
        }
    }
}
