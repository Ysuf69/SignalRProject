using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class NatificationManager : INatificationService
    {
        private readonly INatificationDal _natificationDal;

        public NatificationManager(INatificationDal natificationDal)
        {
            _natificationDal = natificationDal;
        }

        public void TAdd(Natification entity)
        {
            _natificationDal.Add(entity);
        }

        public void TDelete(Natification entity)
        {
            _natificationDal.Delete(entity);
        }

        public List<Natification> TGetAllNatificationByFalse()
        {
            return _natificationDal.GetAllNatificationByFalse();
        }

        public Natification TGetByID(int id)
        {
            return _natificationDal.GetByID(id);
        }

        public List<Natification> TGetListAll()
        {
            return _natificationDal.GetListAll();
        }

        public int TNatificationCountByStatusFalse()
        {
            return _natificationDal.NatificationCountByStatusFalse();
        }

        public void TNatificationStatusChangeToFalse(int id)
        {
            _natificationDal.NatificationStatusChangeToFalse(id);
        }

        public void TNatificationStatusChangeToTrue(int id)
        {
            _natificationDal.NatificationStatusChangeToTrue(id);
        }

        public void TUpdate(Natification entity)
        {
            _natificationDal.Update(entity);
        }
    }
}
