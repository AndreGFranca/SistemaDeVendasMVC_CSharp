using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaDeVendasMVC.Data;
using SistemaDeVendasMVC.Models;

namespace SistemaDeVendasMVC.Services {
    public class SellerService {
        private readonly SistemaDeVendasMVCContext _context;

        public SellerService(SistemaDeVendasMVCContext context) {
            _context = context;
        }
        public List<Seller> FindAll() {
            return _context.Sellers.ToList();
        }
    }
}
