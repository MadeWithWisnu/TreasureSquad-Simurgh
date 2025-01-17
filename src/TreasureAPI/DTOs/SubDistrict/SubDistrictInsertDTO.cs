using System.ComponentModel.DataAnnotations;

namespace TreasureAPI.DTOs.SubDistrict;

public class SubDistrictInsertDTO
{
    [Required(ErrorMessage = "Nama Provinsi tidak boleh kosong")]
    public string Name_Province { get; set; } = null!;
    [Required(ErrorMessage = "Nama Kota/Kabupaten tidak boleh kosong")]
    public string Name_District { get; set; } = null!;
    [Required(ErrorMessage = "Nama Kecamatan tidak boleh kosong")]
    public string Name { get; set; } = null!;
    [Required(ErrorMessage = "Status tidak boleh kosong")]
    public int Status { get; set; } 
}
