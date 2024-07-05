﻿using eshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Infrastructure.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        private List<Product> _products;
        public FakeProductRepository()
        {
            _products = new List<Product>()
            {
                new(){ Id= 1, Name="POCO", Description="8GB RAM", Price=10000 },
                new(){ Id= 2, Name="Samsung", Description="16GB RAM", Price=17000 },
                new(){ Id= 3, Name="IPAD", Description="8GB RAM", Price=25000 },
                new(){ Id= 4, Name="Homend", Description="8GB RAM", Price=5000 },
                new(){ Id= 5, Name="A", Description="8GB RAM", Price=10000 },
                new(){ Id= 6, Name="B", Description="16GB RAM", Price=17000 },
                new(){ Id= 7, Name="C", Description="8GB RAM", Price=25000 },
                new(){ Id= 8, Name="D", Description="8GB RAM", Price=5000 },
            };
        }
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> SearchProductByName(string productName)
        {
            throw new NotImplementedException();
        }
    }
}
