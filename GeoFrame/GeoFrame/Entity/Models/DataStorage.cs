using System;
using System.Collections.Generic;

namespace GeoFrame.Entity.Models
{
   public class DataStorage : IDataStorage
   {
      private static Dictionary<string, object> _dict = new Dictionary<string, object>();

      public object Get(string key)
      {
         if (_dict.ContainsKey(key))
         {
            return _dict[key];
         }

         return null;
      }

      public bool Save(string key, object data)
      {
         try
         {
            if (_dict.ContainsKey(key))
            {
               _dict[key] = data;  // Update
            }
            else
            {
               _dict.Add(key, data);  // Save
            }
            return true;
         }
         catch (Exception)
         {
            return false;
         }
      }
   }
}