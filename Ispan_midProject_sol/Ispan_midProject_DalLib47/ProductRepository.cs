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
                var linq = from p in db.Products
                           select p;

                result = linq.ToList();
                //amount = grp.Sum(x => Convert.ToDouble(x["AMOUNT"] == DBNull.Value ? 0 : x["AMOUNT"]));
                //foreach (string item in linq.ToList())
                //{
                //    //public virtual ProductCategory ProductCategory { get; set; }

                //    //public virtual ProductModel ProductModel { get; set; }
                //    item.ProductCategory = item.ProductCategory == (DBNull.Value)
                //            ? default(T)
                //            : (T) source[columnName];
                //    result += item;
                //}
            };

            return result;

        }

        public Product Create(Product entity)
        {
            //Product result = null;
            using (var db = new EF_Travel_Model())
            {
                var a = db.Products.Add(entity);
                db.SaveChanges();

            };
            return entity;
        }

        public Product GetById(int Id)
        {
            Product result = null;
            using (var db = new EF_Travel_Model())
            {
                var linq = from p in db.Products
                           where p.ProductID == Id
                           select p;

                result = linq.FirstOrDefault();
            };

            return result;

        }

        public void DeleteById(int Id)
        {
            using (var db = new EF_Travel_Model())
            {
                var linq = (from p in db.Products
                           where p.ProductID == Id
                           select p).FirstOrDefault();
                try
                {
                    db.Products.Remove(linq);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    // Provide for exceptions.
                }
                

            };

        }

    }
}
