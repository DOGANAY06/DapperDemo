using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

    }
}
