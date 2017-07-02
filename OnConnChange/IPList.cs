using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnConnChange
{
    public static class IPList
    {
        private static String[] IPs = { "8.8.4.4", "8.8.8.8" };
        private static Random r = new Random();
        private static int lastIndex = -1;

        public static String getRndIP()
        {
            int ind = r.Next(0, IPs.Length);
            String IP = IPs[ind];
            lastIndex = ind;
            return IP;
        }

        public static String getNextIP()
        {
            lastIndex = (++lastIndex) % IPs.Length;
            return IPs[lastIndex];
        }
    }
}
