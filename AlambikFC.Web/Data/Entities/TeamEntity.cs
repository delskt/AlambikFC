using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlambikFC.Web.Data.Entities
{
    public class TeamEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The  field {0} is mandatory.")]
        public string Name { get; set; }
    }
}
