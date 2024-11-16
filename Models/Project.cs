using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Models{
    public class Project{
        [Key]
        public int Project_Id { get; set; }
        [Column("Nama Project")]
        [Display(Name="Nama Project")]
        public string? Nama_Project { get; set; }
        public string? Deskripsi { get; set; }
        [DataType(DataType.DateTime)]
        [Column("Waktu Mulai")]
        [Display(Name="Waktu Mulai")]
        public DateTime? Waktu_Mulai { get; set; }
        [DataType(DataType.DateTime)]
        [Column("Waktu Selesai")]
        [Display(Name="Waktu Selesai")]
        public DateTime? Waktu_Selesai { get; set; }        
    }
}