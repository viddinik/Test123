using FluentValidation;
using FluentValidation.Results;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Validation;
using System;
using System.Collections.Generic;

namespace NTierArchitecture.Business.Services
{
    public class OrderDetailService
    {
        private readonly OrderDetailRepository _orderDetailRepository;

        public OrderDetailService(OrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return _orderDetailRepository.GetAll();
        }

        public OrderDetail GetOrderDetailById(Guid orderId, Guid productId)
        {
            return _orderDetailRepository.GetOrderDetailByOIDandPID(orderId, productId);
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailValidator validator = new();
            ValidationResult result = validator.Validate(orderDetail);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _orderDetailRepository.Add(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            _orderDetailRepository.Update(orderDetail);
        }

        public void DeleteOrderDetail(Guid orderId, Guid productId)
        {
            _orderDetailRepository.DeleteOrderDetail(orderId, productId);
        }

        public bool IfOrderDetailExists(Guid orderId, Guid productId)
        {
            return _orderDetailRepository.IfEntityExists(od => od.OrderID == orderId && od.ProductID == productId);
        }
    }
}
