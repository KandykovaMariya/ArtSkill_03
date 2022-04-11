        using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtSkill_03.Models
{
    public class IllustrationModel
    {
            public int Id { get; set; }
        
            [StringLength(60, MinimumLength = 3)]
            [Required]
            public string? Name { get; set; }
            [StringLength(150, MinimumLength = 5)]
            [Required]
            public string shortDesc { get; set; }
            [StringLength(500, MinimumLength = 5)]
            [Required]
            public string longDesc { get; set; }
            [Display(Name = "Release Date")]
            [DataType(DataType.Date)]
            public DateTime ReleaseDate { get; set; }
            
            [Required]
            [StringLength(30)]
            public string? Category { get; set; }   
               
            public string img { get; set; }
            
            [Column(TypeName = "decimal(18, 2)")] 
            public decimal Price { get; set; }
           // public virtual Category Category { get; set; }

    }
}

