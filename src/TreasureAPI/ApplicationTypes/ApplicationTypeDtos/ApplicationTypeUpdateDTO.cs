namespace TreasureAPI.ApplicationTypes;

public class ApplicationTypeUpdateDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool Status { get; set; }
}
