using TreasureDataAccess.Models;

namespace TreasureAPI.Provinces;

public interface IProvinceRepository
{
    List<MstProvince> Get(int page, int pageSize, string name);
    List<MstProvince> Get();
    MstProvince? GetById(int id);
    void Insert(MstProvince province);
    void Update(MstProvince province);
    int Count(string name);
}
