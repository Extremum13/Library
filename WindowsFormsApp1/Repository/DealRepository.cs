using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    class DealRepository : GenericRepository<Deal>
    {
        public DealRepository() : base()
        {

        }

        public List<Deal> GetDealsByReaderId(int readerId)
        {
            List<Deal> deals = _db.Deals.Where(d => d.ReaderId.Value.Equals(readerId)).ToList();
            return deals;
        }

    }
}
