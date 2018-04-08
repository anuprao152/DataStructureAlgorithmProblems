using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview.Vmware
{
    public class IPAddressValidation
    {
        public bool IsValidIPV4Address(string ipAddress)
            {
                if (string.IsNullOrEmpty(ipAddress))
                    return false;

                var dotCount = 0;

                int i = 0;
                int value = 0;
                while (i < ipAddress.Length)
                {
                    while (i < ipAddress.Length && ipAddress[i] != '.' && dotCount < 4)
                    {
                        if (ipAddress[i] < '0' || ipAddress[i] > '9' && ipAddress[i] != '.')
                             return false;

                    value = value * 10 + ipAddress[i] - '0';
                        i++;
                    }

                    if (i < ipAddress.Length && ipAddress[i] == '.')
                        dotCount++;

                    if ( value > 255 || dotCount >= 4)
                        return false;

                    value = 0;
                    i++;
                }

                return true;
            }

        public bool IsValidIPV6Address(string ipAddress)
        {
            if (string.IsNullOrEmpty(ipAddress))
                return false;

            int i = 0;
            int digitCount = 0;
            int colonCount = 0;
            while (i < ipAddress.Length)
            {
               
                while (i < ipAddress.Length && ipAddress[i] != ':' && colonCount <  8)
                {

                    if ((ipAddress[i] < '0' || ipAddress[i] > '9') && !(ipAddress[i] >= 'a' && ipAddress[i] <= 'f') && ipAddress[i] != ':')
                        return false;

                    digitCount++;
                    i++;
                }

                if (i<ipAddress.Length && ipAddress[i] == ':')
                {
                    colonCount++;
                    digitCount = 0;
                }

                if (digitCount > 4 || colonCount >=8)
                    return false;

                i++;
            }

            return true;
        }
    }
}
