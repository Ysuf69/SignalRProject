using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repository;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfNatification : GenericRepository<Natification>, INatificationDal
    {
        public EfNatification(SignalRContext context) : base(context)
        {
        }

        public List<Natification> GetAllNatificationByFalse()
        {
            using var context = new SignalRContext();
            return context.Natifications.Where(x => x.Status == false).ToList();
        }

        public int NatificationCountByStatusFalse()
        {
            using var context = new SignalRContext();
            return context.Natifications.Where(x=>x.Status==false).Count();
        }

        public void NatificationStatusChangeToFalse(int id)
        {
            using var context = new SignalRContext();
            var value = context.Natifications.Find(id);
            value.Status = false;
            context.SaveChanges(); ;
        }

        public void NatificationStatusChangeToTrue(int id)
        {
            using var context=new SignalRContext();
            var value = context.Natifications.Find(id);
            value.Status=true;
            context.SaveChanges();
        }
    }
}
