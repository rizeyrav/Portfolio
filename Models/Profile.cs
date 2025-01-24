using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// Membuat Kelas untuk Model Profile
public class Profile{
    //Menggunakan Data annotation 
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Profile { get; set; } 
    [Required(ErrorMessage = "Kolom Nama Tidak Boleh Kosong")]
    public string Nama { get; set; } = string.Empty;
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",ApplyFormatInEditMode = true)]
    [Display (Name = "Tanggal Lahir")]
    public DateTime Tanggal_Lahir { get; set; }
    [Required(ErrorMessage = "Kolom Domisili Tidak Boleh Kosong")]
    [MaxLength(100,ErrorMessage = "Panjang Karakter Maksimal 100")]
    public string Kota_Domisili { get; set; } = string.Empty;
    [DataType(DataType.Upload)]
    [FileExtensions(Extensions = "jpg,jpeg,png",ErrorMessage ="Format File yang didukung jpg,jpeg,png")]
    public IFormFile? Foto { get; set; }
    
    //Relasi Tabel

}