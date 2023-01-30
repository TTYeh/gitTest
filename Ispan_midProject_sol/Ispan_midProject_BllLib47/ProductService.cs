using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispan_midProject_BllLib47.EF_CodeFirst;
using Ispan_midProject_BllLib47.Interface;

namespace Ispan_midProject_BllLib47
{
    public class ProductService
    {
        private readonly IProductRepository repo;

        public ProductService(IProductRepository repo)
        {
            this.repo = repo;
        }

        public List<Product> GetAll()
        {
            var entityInDB = repo.GetAll();
            if(entityInDB == null) throw new Exception("Product回傳是空的");
            return entityInDB;
        }

        public void Create (Product entity)
        {
            repo.Create(entity);
            // if (entityInDB != null) throw new Exception("Product回傳是空的");
            // return entityInDB;
        }

        public Product GetById(int Id)
        {
            return repo.GetById(Id);
            // if (entityInDB != null) throw new Exception("Product回傳是空的");
            // return entityInDB;
        }

        public void DeleteById(int Id)
        {
            repo.DeleteById(Id);
            // if (entityInDB != null) throw new Exception("Product回傳是空的");
            // return entityInDB;
        }
    }
   
}
