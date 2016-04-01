using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoUDPRemote.Helpers
{
    public static class ExtensionMethods
    {
        public static int Map(this int value, int fromSource, int toSource, int fromTarget, int toTarget)
        {
            if (value <= fromSource)
            {
                return fromTarget;
            }
            else if (value >= toSource)
            {
                return toTarget;
            }
            else
            {
                double sourceRange = toSource - fromSource;
                double targetRange = toTarget - fromTarget;

                double result = (value / sourceRange) * targetRange;

                return (int)Math.Round(result);
            }
        }
    }
}
