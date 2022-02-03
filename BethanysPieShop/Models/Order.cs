using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BethanysPieShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório")]
        [Display(Name = "Sobrenome")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Endereço obrigatório")]
        [StringLength(100)]
        [Display(Name = "Endereço")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Complemento")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "CEP obrigatório")]
        [Display(Name = "CEP")]
        [StringLength(10, MinimumLength = 4)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Cidade obrigatória")]
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(10)]
        public string State { get; set; }

        [Required(ErrorMessage = "País obrigatório")]
        [StringLength(50)]
        [Display(Name = "País")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Celular obrigatório")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Celular")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email obrigatório")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Seu endereço de email não está no formato correto")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }

}
