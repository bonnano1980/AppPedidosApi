﻿using AppPedidosApi.Domain.Entities.Products;

namespace AppPedidosApi.Domain.Entities.Orders
{
    public class OrderItem
    {
        public Guid Id { get; private set; } = new Guid();
        public Guid OrderId { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem()
        {
        }

        public void AddProduct(Guid orderId, Product product, int qty)
        {
            OrderId = orderId;
            Product = product;
            Quantity = qty;
        }

        public double GetTotalPrice()
        {
            return Product.Price * Quantity;
        }
    }
}
