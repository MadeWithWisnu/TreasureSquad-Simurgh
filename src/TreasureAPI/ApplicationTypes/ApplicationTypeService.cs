using TreasureDataAccess.Models;

namespace TreasureAPI.ApplicationTypes;

public class ApplicationTypeService(IApplicationTypeRepository repository)
{
  private readonly IApplicationTypeRepository _repository = repository;

  public List<ApplicationTypeResponseDTO> GetList(int id, string name, bool? status)
  {
    List<MstApplicationType> models = _repository.GetList(id, name, status);
    List<ApplicationTypeResponseDTO> dtos = new List<ApplicationTypeResponseDTO>();
    foreach (MstApplicationType d in models)
    {
      ApplicationTypeResponseDTO dto = new ApplicationTypeResponseDTO
      {
        Id = d.Id,
        Name = d.Name,
        Status = (bool)d.Status,
      };
      dtos.Add(dto);
    }

    return dtos;
  }

  public int Insert(ApplicationTypeInsertDTO dto)
  {
    MstApplicationType model = new MstApplicationType
    {
      Name = dto.Name,
      Status = dto.Status,
      Deleted = false
    };
    return _repository.Insert(model);
  }

  public int Update(ApplicationTypeUpdateDTO dto)
  {

    MstApplicationType model = _repository.Get(dto.Id);
    model.Name = dto.Name;
    model.Status = dto.Status;
    return _repository.Update(model);
  }

  public int Delete(int id)
  {
    MstApplicationType model = _repository.Get(id);
    model.Deleted = false;
    return _repository.Update(model);
  }
}
