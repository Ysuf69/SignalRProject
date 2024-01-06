using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface INatificationService:IGenericService<Natification>
    {
        int TNatificationCountByStatusFalse();
        List<Natification> TGetAllNatificationByFalse();

        void TNatificationStatusChangeToTrue(int id);
        void TNatificationStatusChangeToFalse(int id);

    }
}
