using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan3
{
    class barbermodel
    {
        
        Database1Entities db = new Database1Entities();

        public List<Table> getBarbers()
        {
            return db.Table.ToList<Table>();
        }

        public void addbar(Table a)
        {
            db.Table.Add(a);
            db.SaveChanges();
        }
    }
}
