using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models{
    public class Education{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Education_Id { get; set; }
        [Column("Tingkat Pendidikan")]
        [Display(Name="Tingkat Pendidikan")]
        public eduLevel? Tingkat { get; set; }
        [Display(Name="Instansi Pendidikan")]
        [Column("Instansi Pendidikan")]
        
        public string? Kejuruan { get; set; }
        public string? Lembaga { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name="Mulai Pendidikan")]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}",ApplyFormatInEditMode = true)]
        public DateTime? Mulai { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name="Lulus Pendidikan")]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}",ApplyFormatInEditMode = true)]
        public DateTime? Lulus { get; set; }
    }
}
public enum eduLevel{
    SD,
    SMP,
    SMK,
    Sarjana
}