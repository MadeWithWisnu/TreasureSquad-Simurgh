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
		try
		{
			List<ApplicationDescriptionResponseDTO> dtos = _service.GetList(id, name, status);
			return Ok(dtos);
		}
		catch (System.Exception)
		{
			return BadRequest();
		}
	}

	[HttpPost("insert")]
	public ActionResult<List<ApplicationDescriptionResponseDTO>> Insert(ApplicationDescriptionInsertDTO dto)
	{
		try
		{
			int res = _service.Insert(dto);
			return Ok(res);
		}
		catch (System.Exception)
		{
			return BadRequest();
		}
	}

	[HttpPost("update")]
	public ActionResult<List<ApplicationDescriptionResponseDTO>> Update(ApplicationDescriptionUpdateDTO dto)
	{
		try
		{
			int res = _service.Update(dto);
			return Ok(res);
		}
		catch (System.Exception)
		{
			return BadRequest();
		}
	}

	[HttpPost("delete")]
	public ActionResult<List<ApplicationDescriptionResponseDTO>> Delete(int id)
	{
		try
		{
			int res = _service.Delete(id);
			return Ok(res);
		}
		catch (System.Exception)
		{
			return BadRequest();
		}
	}
}
