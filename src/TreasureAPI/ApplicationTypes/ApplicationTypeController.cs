using Microsoft.AspNetCore.Mvc;

namespace TreasureAPI.ApplicationTypes;

[Route("api/[controller]")]
[ApiController]
public class ApplicationTypeController(ApplicationTypeService service) : ControllerBase
{
  private readonly ApplicationTypeService _service = service;

  [HttpPost("list")]
  public ActionResult<List<ApplicationTypeResponseDTO>> GetList(int id = 0, string name = "", bool? status = true)
  {
    List<ApplicationTypeResponseDTO> dtos = _service.GetList(id, name, status);
    return Ok(dtos);
  }

  [HttpPost("insert")]
  public ActionResult<List<ApplicationTypeResponseDTO>> Insert(ApplicationTypeInsertDTO dto)
  {
    int res = _service.Insert(dto);
    return Ok(res);
  }

  [HttpPost("update")]
  public ActionResult<List<ApplicationTypeResponseDTO>> Update(ApplicationTypeUpdateDTO dto)
  {
    int res = _service.Update(dto);
    return Ok(res);
  }

  [HttpPost("delete")]
  public ActionResult<List<ApplicationTypeResponseDTO>> Delete(int id)
  {
    int res = _service.Delete(id);
    return Ok(res);
  }
}
