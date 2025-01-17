using TreasureDataAccess.Models;

namespace TreasureAPI.ApplicationTypes;

public class ApplicationTypeRepository(SimurghContext dbContext) : IApplicationTypeRepository
{
  private readonly SimurghContext _dbContext = dbContext;

  public MstApplicationType? Get(int id)
  {
    return _dbContext.MstApplicationTypes
    .Where(data => data.Id == id)
    .FirstOrDefault();
  }

  public List<MstApplicationType> GetList(int id, string name, bool? status)
  {
    return _dbContext.MstApplicationTypes
         .Where(data =>
           (id == 0 || data.Id == id)
           && (data.Name ?? "").Contains(name)
           && (status == null || data.Status == (bool)status)
           && data.Deleted == false
         )
         .ToList();
  }

  public int Insert(MstApplicationType mstApplicationDescription)
  {
    _dbContext.Add(mstApplicationDescription);
    _dbContext.SaveChanges();
    return mstApplicationDescription.Id;
  }

  public int Update(MstApplicationType mstApplicationDescription)
  {
    _dbContext.Update(mstApplicationDescription);
    _dbContext.SaveChanges();
    return mstApplicationDescription.Id;
  }
}
