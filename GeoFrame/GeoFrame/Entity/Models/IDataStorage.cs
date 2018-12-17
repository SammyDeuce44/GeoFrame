namespace GeoFrame.Entity.Models
{
   public interface IDataStorage
   {
      object Get(string key);
      bool Save(string key, object data);
   }
}