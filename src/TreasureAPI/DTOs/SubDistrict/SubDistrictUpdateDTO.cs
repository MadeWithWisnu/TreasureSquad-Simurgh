using System.ComponentModel.DataAnnotations;

namespace TreasureAPI.DTOs.SubDistrict;

public class SubDistrictUpdateDTO
{
    [Required(ErrorMessage = "Id provinsi tidak boleh kosong")]
    public int Id_Province { get; set; }
    [Required(ErrorMessage = "Id Kota/Kabupaten tidak boleh kosong")]
    public int Id_District { get; set; }
    [Required(ErrorMessage = "Id Kelurahan tidak boleh kosong")]
    public int Id { get; set; }
     [Required(ErrorMessage = "Nama Kelurahaan tidak boleh kosong")]
    public string Name { get; set; } = null!;
     [Required(ErrorMessage = "Status tidak boleh kosong")]
    public int Status { get; set; }
}
