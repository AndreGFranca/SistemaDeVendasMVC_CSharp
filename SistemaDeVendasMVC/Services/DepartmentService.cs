using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaDeVendasMVC.Data;
using SistemaDeVendasMVC.Models;


namespace SistemaDeVendasMVC.Services {
    public class DepartmentService {
        private readonly SistemaDeVendasMVCContext _context;

        public DepartmentService(SistemaDeVendasMVCContext context) {
            _context = context;
        }

        public List<Department> FindAll() {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
