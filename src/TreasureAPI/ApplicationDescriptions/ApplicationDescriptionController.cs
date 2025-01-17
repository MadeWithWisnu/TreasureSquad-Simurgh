using Microsoft.AspNetCore.Mvc;

namespace TreasureAPI.ApplicationDescriptions;

[Route("api/[controller]")]
[ApiController]
public class ApplicationDescriptionController(ApplicationDescriptionService service) : ControllerBase
{
	private readonly ApplicationDescriptionService _service = service;

	[HttpPost("list")]
	public ActionResult<List<ApplicationDescriptionResponseDTO>> GetList(int id = 0, string name = "", bool? status = true)
	{
		List<ApplicationDescriptionResponseDTO> dtos = _service.GetList(id, name, status);
		return Ok(dtos);
	}

	[HttpPost("insert")]
	public ActionResult<List<ApplicationDescriptionResponseDTO>> Insert(ApplicationDescriptionInsertDTO dto)
	{
		int res = _service.Insert(dto);
		return Ok(res);
	}

	[HttpPost("update")]
	public ActionResult<List<ApplicationDescriptionResponseDTO>> Update(ApplicationDescriptionUpdateDTO dto)
	{
		int res = _service.Update(dto);
		return Ok(res);
	}

	[HttpPost("delete")]
	public ActionResult<List<ApplicationDescriptionResponseDTO>> Delete(int id)
	{
		int res = _service.Delete(id);
		return Ok(res);
	}
}
