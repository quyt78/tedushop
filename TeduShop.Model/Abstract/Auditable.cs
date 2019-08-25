using System;
using System.ComponentModel.DataAnnotations;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Astract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime CreatedDate { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        public bool Status { get; set; }
    }
}