using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TreasureAPI.ApplicationTypes;

[Route("api/[controller]")]
[ApiController]
public class ApplicationTypeController(ApplicationTypeService service) : ControllerBase
{
  private readonly ApplicationTypeService _service = service;

  [HttpPost("list")]
  public ActionResult<List<ApplicationTypeResponseDTO>> GetList(int id = 0, string name = "", bool? status = true)
  {
    try
    {
      List<ApplicationTypeResponseDTO> dtos = _service.GetList(id, name, status);
      return Ok(dtos);
    }
    catch (System.Exception)
    {
      return BadRequest();
    }
  }

  [HttpPost("insert")]
  public ActionResult<List<ApplicationTypeResponseDTO>> Insert(ApplicationTypeInsertDTO dto)
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
  public ActionResult<List<ApplicationTypeResponseDTO>> Update(ApplicationTypeUpdateDTO dto)
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
  public ActionResult<List<ApplicationTypeResponseDTO>> Delete(int id)
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
