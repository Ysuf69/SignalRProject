using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {

        private readonly IOrderDetailDal _orderDetail;

        public OrderDetailManager(IOrderDetailDal orderDetail)
        {
            _orderDetail = orderDetail;
        }

        public void TAdd(IOrderDetailService entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(IOrderDetailService entity)
        {
            throw new NotImplementedException();
        }

        public IOrderDetailService TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<IOrderDetailService> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(IOrderDetailService entity)
        {
            throw new NotImplementedException();
        }
    }
}
