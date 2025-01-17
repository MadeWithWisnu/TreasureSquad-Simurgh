using System.ComponentModel.DataAnnotations;

namespace TreasureAPI.DTOs.Province;

public class ProvinceUpdateDTO
{
    [Required(ErrorMessage = "Id Provinsi tidak boleh kosong")]
    public int Id { get; set; }
     [Required(ErrorMessage = "Nama Provinsi tidak boleh kosong")]
    public string Name { get; set; } = null!;
     [Required(ErrorMessage = "Status tidak boleh kosong")]
    public int Status { get; set; }
}
