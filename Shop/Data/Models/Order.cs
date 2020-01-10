using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name="Enter name")]
        [StringLength(25)]
        [Required(ErrorMessage = "Invalid name(so long)")]
        public string Name { get; set; }

        [Display(Name = "Enter surname")]
        [StringLength(25)]
        [Required(ErrorMessage = "Invalid surname(so long)")]
        public string Surname { get; set; }

        [Display(Name = "Enter adress")]
        [StringLength(25)]
        [Required(ErrorMessage = "Invalid adress(so long)")]
        public string Adress { get; set; }

        [Display(Name = "Enter phone")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(25)]
        [Required(ErrorMessage = "Invalid phone(so long)")]
        public string Phone { get; set; }

        [Display(Name = "Enter e-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Invalid e-mail(so long)")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }


        public List<OrderDetail> OrderDetails { get; set; }
    }
}
