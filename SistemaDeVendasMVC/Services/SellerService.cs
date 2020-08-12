using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaDeVendasMVC.Data;
using SistemaDeVendasMVC.Models;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendasMVC.Services.Exceptions;

namespace SistemaDeVendasMVC.Services {
    public class SellerService {
        private readonly SistemaDeVendasMVCContext _context;

        public SellerService(SistemaDeVendasMVCContext context) {
            _context = context;
        }
        public List<Seller> FindAll() {
            return _context.Sellers.ToList();
        }

        public void Insert(Seller obj) {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id) {
            return _context.Sellers.Include(x => x.Department).FirstOrDefault(x => x.Id == id);
        }
        public void Remove(int id) {
            var obj = _context.Sellers.Find(id);
            _context.Sellers.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj) {
            if (!_context.Sellers.Any(x=> x.Id == obj.Id)) {
                throw new NotFoundException("Id not found");
            }
            try {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e) {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
