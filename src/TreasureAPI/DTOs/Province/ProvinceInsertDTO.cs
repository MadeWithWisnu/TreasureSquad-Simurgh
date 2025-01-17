using System.ComponentModel.DataAnnotations;

namespace TreasureAPI.DTOs.Province;

public class ProvinceInsertDTO
{
    [Required(ErrorMessage = "Nama Provinsi tidak boleh kosong")]
    public string Name { get; set; } = null!;
    [Required(ErrorMessage = "Status tidak boleh kosong")]
    public int Status { get; set; }
}
