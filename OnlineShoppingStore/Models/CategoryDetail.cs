using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OnlineShoppingStore.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Category Name Required")]
        [StringLength(100,ErrorMessage ="Maximum 100 characters are allowed",MinimumLength =3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }

    }

    public class ProductDetail
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name Required")]
        [StringLength(100, ErrorMessage = "Maximum 100 characters are allowed", MinimumLength = 3)]
        public string ProductName { get; set; }

        [Required]
        [Range(1,50)]
        public Nullable<int> CategoryId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        [Required(ErrorMessage = "Product Name Required")]
        public Nullable<System.DateTime> Description { get; set; }
        public string productImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }

        [Required]
        [Range(typeof(int),"1","500", ErrorMessage = "Invalid Qunatity")]
        public Nullable<int> quantity { get; set; }

        [Required]
        [Range(typeof(decimal),"1","200000",ErrorMessage ="invalid price")]
        public Nullable<decimal> price { get; set; }

        public SelectList Categories { get; set; }

    }
}