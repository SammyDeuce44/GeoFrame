using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.Controller
{
   public class CsvController
   {
      private readonly CsvManager _csvController;

      public CsvController(CsvStringReader reader, DataStorage storage)
      {
         _csvController = new CsvManager(reader, storage);
      }

      public void ConvertSingle<T>(bool canPrint = false) where T : CsvBase, new()
      {
         var data = _csvController.Read<T>();
         _csvController.Save<T>(data);

         if (canPrint)
         {
            _csvController.Print(typeof(T).Name, data);
         }
      }

      public object ReadSingle<T>() where T : CsvBase, new()
      {
         var fileName = typeof(T).Name;
         var model = _csvController.Transfer<T>();
         if (model == null)
         {
            Console.WriteLine("\nFailed to retreive data from {0}. The key search returned no results.\n", fileName);
         }

         return model;
      }

      public IDataStorage ReadAll()
      {
         return _csvController.PrintAll();
      }
   }
}