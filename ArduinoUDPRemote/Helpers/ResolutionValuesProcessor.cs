using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoUDPRemote.Helpers
{
    public class ResolutionValuesProcessor
    {
        private ResolutionValuesEnum _defaultVal;

        public ResolutionValuesProcessor(ResolutionValuesEnum defaultVal)
        {
            _defaultVal = defaultVal;
        }

        /// <summary>
        /// Gets the resolution in times per second from the index of the enum element
        /// </summary>
        /// <param name="enumValue">The enum cast to int</param>
        /// <returns>Resolution in times per sec</returns>
        public int GetResolutionFromEnumIndex(int enumValue)
        {
            switch (enumValue)
            {
                case (int)ResolutionValuesEnum.R1:
                    return 1;
                case (int)ResolutionValuesEnum.R2:
                    return 2;
                case (int)ResolutionValuesEnum.R3:
                    return 3;
                case (int)ResolutionValuesEnum.R5:
                    return 5;
                case (int)ResolutionValuesEnum.R10:
                    return 10;
                case (int)ResolutionValuesEnum.R15:
                    return 15;
                case (int)ResolutionValuesEnum.R20:
                    return 20;
                case (int)ResolutionValuesEnum.R25:
                    return 25;
                case (int)ResolutionValuesEnum.R30:
                    return 30;
                case (int)ResolutionValuesEnum.R50:
                    return 50;
                case (int)ResolutionValuesEnum.R100:
                    return 100;
                default:
                    throw new ArgumentOutOfRangeException("Value is not supported by the ResolutionValuesEnum", new Exception());
            }
        }
    }
}
