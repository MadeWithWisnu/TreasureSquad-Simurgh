using TreasureDataAccess.Models;

namespace TreasureAPI.ApplicationDescriptions
{
	public class ApplicationDescriptionRepository(SimurghContext dbContext) : IApplicationDescriptionRepository
	{
		private readonly SimurghContext _dbContext = dbContext;

		public MstApplicationDescription? Get(int id)
		{
			return _dbContext.MstApplicationDescriptions
				.Where(data => data.Id == id)
				.FirstOrDefault();
		}

		public List<MstApplicationDescription> GetList(int id, string name, bool? status)
		{
			return _dbContext.MstApplicationDescriptions
				.Where(data =>
					(id == 0 || data.Id == id)
					&& (data.Name ?? "").Contains(name)
					&& (status == null || data.Status == (bool)status)
					&& data.Deleted == false
				)
				.ToList();
		}

		public int Insert(MstApplicationDescription mstApplicationDescription)
		{
			_dbContext.Add(mstApplicationDescription);
			_dbContext.SaveChanges();
			return mstApplicationDescription.Id;
		}

		public int Update(MstApplicationDescription mstApplicationDescription)
		{
			_dbContext.Update(mstApplicationDescription);
			_dbContext.SaveChanges();
			return mstApplicationDescription.Id;
		}

		// public int Delete(int id)
		// {
		// 	_dbContext.Remove(id);
		// 	_dbContext.SaveChanges();
		// 	return id;
		// }
	}
}
