using ASP.Net_Core_May_2022.Models;
using System.Collections.Generic;

namespace ASP.Net_Core_May_2022.Data.Interfaces
{
    public interface IVendorRepo
    {
        public List<Vendor> GetAll();
        public Vendor GetById(int id);
        public void Delete(int id);
        public void Update(int id, Vendor vendor);
        public void Create(Vendor vendor);
    }
}
