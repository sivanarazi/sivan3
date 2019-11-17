using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan3
{
    class barbercontroler
    {
        private barbermodel bm = new barbermodel();

        public List<Table> getBarbers()
        {
            return bm.getBarbers();
        }

        public void addbar(string n, string g, string p, string ad)
        {
            Table a = new Table
            {
                name = n,
                gender = g,
                phone = p,
                address = ad,
            };
            bm.addbar(a);
        }
    }
}
