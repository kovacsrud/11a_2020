using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSUDH
{
    public class Domain
    {
        public string DomainName { get; set; }
        public string IpAddress { get; set; }

        public Domain(string sor)
        {
            var e = sor.Split(';');
            DomainName = e[0];
            IpAddress = e[1];
        }

        public string GetDomain(int szint)
        {
            var e = DomainName.Split('.');

            Array.Reverse(e);

            if (szint>e.Length)
            {
                return "nincs";
            } else
            {
                return e[szint-1];
            }

            
        }
    }
}
