using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispan_midProject_BllLib47.EF_CodeFirst;

namespace Ispan_midProject_BllLib47.Interface
{
    public interface IProductRepository
    {
        Product Create(Product entity);
        List<Product> GetAll();

        Product GetById(int id);

        void DeleteById(int id);

    }
}
