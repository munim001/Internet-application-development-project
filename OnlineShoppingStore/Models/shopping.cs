using OnlineShoppingStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace OnlineShoppingStore.Models
{
    public class shippingdetail
    {
        public int ShippingDetailsId { get; set; }

        [Required]

        public Nullable<int> MemberId { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string ZipCode { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }

        [Required]
        public string PaymentType { get; set; }

    }
}