

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RQCore.RQEnitity;

namespace RQCore.RQEnitity.Dtos
{
    public class CreateOrUpdateInvoiceInput
    {
        [Required]
        public InvoiceEditDto Invoice { get; set; }

    }
}