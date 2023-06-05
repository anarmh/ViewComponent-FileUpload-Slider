﻿using FiorelloFront.Data;
using FiorelloFront.Models;
using FiorelloFront.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FiorelloFront.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;   
        }
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.Include(m => m.ProductImages).Take(8).Where(m => !m.SoftDelete).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            return  await _context.Products.FindAsync(id);
        }

        public async Task<Product> GetByIdImagesAsync(int? id)
        {
           return await _context.Products.Include(m => m.ProductImages).FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
