using TreasureDataAccess.Models;

namespace TreasureAPI.ApplicationDescriptions
{
	public interface IApplicationDescriptionRepository
	{
		public MstApplicationDescription? Get(int id);
		public List<MstApplicationDescription> GetList(int id, string name, bool? status);
		public int Insert(MstApplicationDescription mstApplicationDescription);
		public int Update(MstApplicationDescription mstApplicationDescription);
		public int Delete(int id);
	}
}
