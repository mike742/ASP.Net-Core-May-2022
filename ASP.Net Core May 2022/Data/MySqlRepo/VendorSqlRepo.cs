using ASP.Net_Core_May_2022.Data.Interfaces;
using ASP.Net_Core_May_2022.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASP.Net_Core_May_2022.Data.MySqlRepo
{
    public class VendorSqlRepo : IVendorRepo
    {
        private readonly AppDbContext _context;

        public VendorSqlRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Vendor vendor)
        {
            _context.Add(vendor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Vendor> GetAll()
        {
            return _context.Vendors.ToList();
        }

        public Vendor GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Vendor vendor)
        {
            throw new System.NotImplementedException();
        }
    }
}
