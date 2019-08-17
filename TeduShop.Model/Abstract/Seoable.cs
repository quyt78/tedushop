using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Models.Abstract;

namespace TeduShop.Model.Abstract
{
    public abstract class Seoable: ISeoable
    {
        [MaxLength]
        public string MetaKeyword { get; set; }

        [MaxLength]
        public string MetaDescription { get; set; }
    }
}
