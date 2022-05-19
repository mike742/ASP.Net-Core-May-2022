using ASP.Net_Core_May_2022.Models;
using System.Collections.Generic;

namespace ASP.Net_Core_May_2022.Data.Interfaces
{
    public interface IProduct
    {
        public List<Product> GetAll();
        public Product GetById(int id);
        public void Delete(int id);
        public void Update(int id, Product vendor);
        public void Create(Product vendor);
    }
}
