﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaDeVendasMVC.Models;
using SistemaDeVendasMVC.Models.Enums;

namespace SistemaDeVendasMVC.Data {
    public class SeedingService {

        private SistemaDeVendasMVCContext _context;

        public SeedingService(SistemaDeVendasMVCContext context) {
            _context = context;
        }

        public void Seed() {
            if (_context.Department.Any() || _context.SalesRecords.Any() || _context.Sellers.Any()) {
                return; //DB já está populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "André Franca","afranca@top.com", new DateTime(1996, 10, 05), 3500.0, d1);
            Seller s2 = new Seller(2, "Maria Brown","Maria@gmail.com", new DateTime(1979, 01, 12), 4500.0, d3);
            Seller s3 = new Seller(3, "Alex Grey","Alex@gmail.com", new DateTime(1980, 05, 22), 2500.0, d4);
            Seller s4 = new Seller(4, "Bob Blues", "Blues@gmail.com",new DateTime(1976, 11, 15), 1200.0, d4);
            Seller s5 = new Seller(5, "Donald Pink","Donald@gmail.com" , new DateTime(1960, 06, 29), 5000.0, d2);
            Seller s6 = new Seller(6, "Moon Sun", "Moon@gmail.com", new DateTime(1987, 03, 06), 4300.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 04, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 04, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 04, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 04, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 04, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2020, 04, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2020, 04, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2020, 04, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2020, 04, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2020, 04, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2020, 04, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2020, 04, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2020, 04, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2020, 04, 4), 3000.0, SaleStatus.Billed, s1);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2020, 04, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2020, 05, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2020, 05, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2020, 05, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2020, 05, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2020, 05, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2020, 05, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2020, 05, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2020, 05, 19), 11000.0, SaleStatus.Canceled, s1);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2020, 05, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2020, 05,29), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2020, 05, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2020, 05, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2020, 05, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2020, 05, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2020, 05, 12), 5000.0, SaleStatus.Billed, s2);


            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Sellers.AddRange(s1,s2,s3,s4,s5,s6);

            _context.SalesRecords.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,r9,r10
                                          ,r11,r12,r13,r14,r15,r16,r16,r17,r18,r19,r20,
                                           r21,r22,r23,r24,r25,r26,r27,r28,r29,r30);
            _context.SaveChanges();
        }
    }
}
