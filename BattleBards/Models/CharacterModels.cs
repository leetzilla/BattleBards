using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BattleBards.Models
{
    public class CharacterModels
    {
        public int characterID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage ="Character name cannot exceed 50 characters.")]
        public string name { get; set; }
        public ApplicationUser userID { get; set; }
        [Display(Name ="class")]
        public int classID { get; set; }
        public int swole { get; set; }
        public int smarts { get; set; }
        public int swagger { get; set; }
    }
}