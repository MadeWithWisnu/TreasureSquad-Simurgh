namespace TreasureAPI.DTOs.SubDistrict;

public class SubDistrictResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Status { get; set; }
    public string Name_Province { get; set; } = null!;
    public string Name_District { get; set; } = null!;
}
