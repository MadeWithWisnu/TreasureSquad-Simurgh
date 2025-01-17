namespace TreasureAPI.DTOs.District;

public class DistrictResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Status { get; set; }
    public string Name_Province { get; set; } = null!;
}
