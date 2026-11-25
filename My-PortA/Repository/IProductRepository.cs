using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace My_PortA.Repository
{
    public interface IProductRepository
    {
        Task CreateProduct(string name, string size, string description, string material, string COO);

        Task UpdateProduct(string Id, string name, string size, string description, string material, string COO);

        Task ReadAll();

        Task DeleteProduct(int id);





    }
}
