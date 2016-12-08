using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using BattleBards.Helpers;

namespace BattleBards.Models
{

    public class CharacterModels
    {
        [Key]
        public int characterId { get; set; }
        public ApplicationUser User { get; set; }
        [Required]
        [StringLength(50, ErrorMessage ="Character name cannot exceed 50 characters.")]
        public string name { get; set; }
        [Display(Name ="class")]
        public CharacterClass characterClass { get; set; }
        public int swole { get; set; }
        public int smarts { get; set; }
        public int swagger { get; set; }
        public Gender gender { get; set; }
        
        //public SystemMessage SaveNewCharacter(Character model)
        //{
        //    using (var _db = new BbDb())
        //    {
        //        try
        //        {
        //            _db.Character.Add(model);
        //            _db.SaveChanges();
        //            return new SystemMessage() { Message = "save successful" };
        //        }
        //        catch {
        //            return new SystemMessage() { Message = "save unsuccessful" };
        //        }
        //    }
        //}
    }

    public enum CharacterClass {
        bruiser=1,
        wizard=2,
        skallywag=3,
        zealot=4
    }

    public enum Gender
    {
        male,
        female,
        other
    }
    

 
}

