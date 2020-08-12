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
        public async Task<List<Seller>> FindAllAsync() {
            return await _context.Sellers.ToListAsync();
        }

        public async Task InsertAsync(Seller obj) {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id) {
            return await _context.Sellers.Include(x => x.Department).FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task RemoveAsync(int id) {
            
            try {
                var obj = await _context.Sellers.FindAsync(id);
                _context.Sellers.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e) {
                throw new IntegrityException("Can't delete seller because he/she has sales!");
            }

        }

        public async Task UpdateAsync(Seller obj) {
            bool hasAny = await _context.Sellers.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny) {
                throw new NotFoundException("Id not found");
            }
            try {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e) {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
