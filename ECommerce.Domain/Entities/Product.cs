using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }               // معرف المنتج
        public string Name { get; set; } = string.Empty;         // اسم المنتج
        public string? Description { get; set; } // وصف المنتج
        public decimal Price { get; set; }        // سعر المنتج
        public int StockQuantity { get; set; }    // كمية المخزون المتاحة
    }
}
