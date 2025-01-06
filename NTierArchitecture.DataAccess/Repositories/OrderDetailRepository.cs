using Microsoft.EntityFrameworkCore;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<OrderDetail> _dbSet;
        public OrderDetailRepository(ApplicationDbContext context) : base(context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<OrderDetail>();
        }

        public void DeleteOrderDetail(Guid orderID, Guid ProductID)
        {
            var orderDetail = _dbSet.FirstOrDefault(x => x.OrderID == orderID && x.ProductID == ProductID);

            if (orderDetail != null)
            {
                _dbSet.Remove(orderDetail);
                _dbContext.SaveChanges();
            }
        }

        public OrderDetail GetOrderDetailByOIDandPID(Guid orderID, Guid ProductID)
        {
            var orderDetail = _dbSet.FirstOrDefault(x => x.OrderID == orderID && x.ProductID == ProductID);

            if (orderDetail != null)
            {
                return orderDetail;
            }

            throw new Exception("OrderDetail not found");
        }
    }
}
