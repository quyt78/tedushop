using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Astract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post: Auditable
    {

    }
}
