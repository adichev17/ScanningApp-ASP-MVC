﻿using Microsoft.EntityFrameworkCore;
using ScanningProductsApp.Domain;
using ScanningProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanningProductsApp.Manager.Products
{
    public class BrandSpecificationProductManager : IFilterProduct
    {
        private readonly AppDbContext _context;

        public BrandSpecificationProductManager(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> Filter(ProductViewCategoryOrBrand model)
        {
            var products = await _context.ProductTable.Where(vl => vl.BrandID == model.IDNameDivisions).ToListAsync();
            if (products != null)
                return products;

            return null;
        }
    }
}
