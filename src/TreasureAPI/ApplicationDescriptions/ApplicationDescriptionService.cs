using TreasureDataAccess.Models;

namespace TreasureAPI.ApplicationDescriptions;

public class ApplicationDescriptionService(IApplicationDescriptionRepository repository)
{
	private readonly IApplicationDescriptionRepository _repository = repository;

	public List<ApplicationDescriptionResponseDTO> GetList(int id, string name, bool? status)
	{
		List<MstApplicationDescription> models = _repository.GetList(id, name, status);
		List<ApplicationDescriptionResponseDTO> dtos = new List<ApplicationDescriptionResponseDTO>();
		foreach (MstApplicationDescription d in models)
		{
			ApplicationDescriptionResponseDTO dto = new ApplicationDescriptionResponseDTO { 
				Id = d.Id,
				Name = d.Name,
				Status = (bool)d.Status,
			};
			dtos.Add(dto);
		}
		
		return dtos;
	}

	public int Insert(ApplicationDescriptionInsertDTO dto)
	{
		MstApplicationDescription model = new MstApplicationDescription {
			Name = dto.Name,
			Status = dto.Status.ToString(),
			Deleted = false
		};
		return _repository.Insert(model);
	}

	public int Update(ApplicationDescriptionUpdateDTO dto)
	{

		MstApplicationDescription model = _repository.Get(dto.Id);
		model.Name = dto.Name;
		model.Status = dto.Status;
		return _repository.Update(model);
	}

	public int Delete(int id)
	{
		MstApplicationDescription model = _repository.Get(id);
		model.Deleted = false;
		return _repository.Update(model);
	}
}
