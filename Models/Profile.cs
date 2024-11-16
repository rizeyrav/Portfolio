using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models{
    public class Profile{
        public Profile(){ }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        [StringLength(50)]
        public string? Nama { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Column("Tanggal Lahir")]
        [Display(Name = "Tangal Lahir")]
        public DateTime Tanggal_Lahir { get; set; }
        public string? Domisili { get; set; }
        [StringLength(250)]
        public string? Alamat { get; set; }

        public string? Bio { get; set; }
        [NotMapped]
        public required IFormFile Foto { get; set;} 
        public byte[]? dataByte { get; set; }

        public ICollection<Education>? Educations { get; set; }
        public ICollection<Project>? Projects { get; set; }
    }
}