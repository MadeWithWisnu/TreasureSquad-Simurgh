using System.ComponentModel.DataAnnotations;

namespace TreasureAPI.DTOs.District;

public class DistrictUpdateDTO
{
    [Required(ErrorMessage = "Id provinsi tidak boleh kosong")]
    public int Id_Province { get; set; }
    [Required(ErrorMessage = "Id Kota/Kabupaten tidak boleh kosong")]
    public int Id { get; set; }
     [Required(ErrorMessage = "Nama Kota/Kabupaten tidak boleh kosong")]
    public string Name { get; set; } = null!;
     [Required(ErrorMessage = "Status tidak boleh kosong")]
    public int Status { get; set; }
}
