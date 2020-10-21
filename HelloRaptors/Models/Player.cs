using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloRaptors.Models
{
    public class Player
    {

        [Required]
        [StringLength(25)]
        [Display(Name ="Basketball Player Name")]
        public string PlayerName { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Please enter 3 or more letters")]
        public string Position { get; set; }



    }
}
