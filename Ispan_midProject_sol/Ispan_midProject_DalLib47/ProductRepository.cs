using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Ispan_midProject_BllLib47.EF_CodeFirst;
using Ispan_midProject_BllLib47.Interface;


namespace Ispan_midProject_DalLib47
{
    public class ProductRepository: IProductRepository
    {
        public List<Product> GetAll()
        {
            List<Product> result;
            using (var db = new EF_Travel_Model())
            {
                var linq = from data in db.Products
                           select data;
                result = linq.ToList();
            };
            return result;

        }

        public Product Create(Product entity)
        {
            Product result = null;
            using (var db = new EF_Travel_Model())
            {
                var a = db.Products.Add(entity);
                //var linq = from data in db.Products
                //           where data.ProductID == entity.ProductID
                //           select data;
            };
            return entity;
        }
    }
}
