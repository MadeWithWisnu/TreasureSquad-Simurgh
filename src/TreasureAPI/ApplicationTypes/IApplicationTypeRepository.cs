using TreasureDataAccess.Models;

namespace TreasureAPI.ApplicationTypes;

public interface IApplicationTypeRepository
{
  public MstApplicationType? Get(int id);
  public List<MstApplicationType> GetList(int id, string name, bool? status);
  public int Insert(MstApplicationType mstApplicationDescription);
  public int Update(MstApplicationType mstApplicationDescription);
}
