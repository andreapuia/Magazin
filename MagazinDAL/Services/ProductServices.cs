using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagazinDAL.Models;
namespace MagazinDAL.Services
{
    public class ProductServices
    {

        public void AddProduct(string Name, string Price)
        {
            Product p = new Product();
            p.Name = Name;
            p.Price = Int32.Parse(Price);

            using (var context = new MasterContext())
            {
                context.Set<Product>().Add(p);
                context.SaveChanges();
            }

        }
        public List<Product> GetProducts()
        {
            using (var context = new MasterContext())
            {
                return context.Products.ToList();
            }

        }
        public void DeleteProduct(Product p)
        {
            using (var context = new MasterContext())
            {
                context.Entry(p).State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
    }
}
