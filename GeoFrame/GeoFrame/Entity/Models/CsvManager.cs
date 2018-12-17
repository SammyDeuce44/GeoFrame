using System.Collections.Generic;

namespace GeoFrame.Entity.Models
{
   public class CsvManager
   {
      private readonly IReader _reader;
      private readonly IDataStorage _dataStorage;

      public CsvManager(IReader reader, IDataStorage dataStorage)
      {
         _reader = reader;
         _dataStorage = dataStorage;
      }

      public IDataStorage PrintAll()
      {
         return _dataStorage;
      }

      public IEnumerable<T> Read<T>() where T : CsvBase, new()
      {
         var assetName = typeof(T).Name;
         return _reader.Read<T>(assetName, true);
      }

      public object Transfer<T>() where T : CsvBase, new()
      {
         var assetName = typeof(T).Name;
         return _dataStorage.Get(assetName);
      }

      public void Print<T>(string header, IEnumerable<T> data) where T : CsvBase, new()
      {
         Printer.Print(header, data);
      }

      public void Save<T>(object data)
      {
         _dataStorage.Save(typeof(T).Name, data);
      }
   }
}