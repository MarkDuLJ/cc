using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    [ModelMetadataType(typeof(MetaOrder))]
    public partial class Order
    {
    }
    public  class MetaOrder
    {

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ProvinceCode { get; set; }
        [RegularExpression(@"^[A-Za-z\d[A-Za-z]$")]
        public string PostalCode { get; set; }
        [RegularExpression(@"^[A-Za-z[A-Za-z]$")]
        public string CountryCode { get; set; }


        public string Phone { get; set; }
        public string Email { get; set; }
        public double Total { get; set; }
    }
}
