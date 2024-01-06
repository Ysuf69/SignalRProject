using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface INatificationDal:IGenericDal<Natification>
    {
        int NatificationCountByStatusFalse();
        List<Natification> GetAllNatificationByFalse();

        void NatificationStatusChangeToTrue(int id);
        void NatificationStatusChangeToFalse(int id);
    }
}
