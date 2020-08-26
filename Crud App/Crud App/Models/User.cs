using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Crud_App.Models
{
    public class User
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$")]
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        [StringLength(11, MinimumLength = 11)]
        [Required]
        public int Phonenumber { get; set; }
        [RegularExpression("^((?!-)[A-Za-z0-9-]" + "{1,63}(?<!-)\\.)" + "+[A-Za-z]{2,6}")]
        [Required]
        public string Domain { get; set; }

        public string Notes { get; set; }

    }
}
