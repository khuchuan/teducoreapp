using System;
using System.ComponentModel.DataAnnotations;
using TeduCoreApp.Infrastructure.SharedKernel;

namespace TeduCoreApp.Data.Entities
{
    public class Bill : DomainEntity<int>
    {
        [Required]
        public int CustomerId { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(500)]
        public string CustomerAddress { get; set; }

        [StringLength(20)]
        public string CustomerPhone { get; set; }

        [StringLength(50)]
        public string CustomerEmail { get; set; }

        [Required]
        public DateTime BillDate { get; set; }

        public int Status { get; set; }
    }
}