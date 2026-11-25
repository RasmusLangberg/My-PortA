using System;
using System.Collections.Generic;
using System.Text;

namespace My_PortA.Repository
{
    public class ProductRepos : IProductRepository
    {
        public Task CreateProduct(string name, string size, string description, string material, string COO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task ReadAll()
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(string Id, string name, string size, string description, string material, string COO)
        {
            throw new NotImplementedException();
        }
    }
}
