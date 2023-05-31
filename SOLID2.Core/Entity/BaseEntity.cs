using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2.Core.Entity
{
    /// <summary>
    ///  abstract (new) lenmez
    /// </summary>
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;   
        public DateTime? UpdatedDate { get; set; }
    }
}
