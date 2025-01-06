using FluentValidation;
using FluentValidation.Results;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Validation;
using System;
using System.Collections.Generic;

namespace NTierArchitecture.Business.Services
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public Order GetOrderById(Guid id)
        {
            return _orderRepository.GetByID(id);
        }

        public void AddOrder(Order order)
        {
            OrderValidator validator = new();
            ValidationResult result = validator.Validate(order);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _orderRepository.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            _orderRepository.Update(order);
        }

        public void DeleteOrder(Guid id)
        {
            _orderRepository.Delete(id);
        }

        public bool IfOrderExists(Guid id)
        {
            return _orderRepository.IfEntityExists(o => o.Id == id);
        }
    }
}
