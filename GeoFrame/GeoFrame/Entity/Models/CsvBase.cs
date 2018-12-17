using System;
using System.Collections.Generic;
using System.Reflection;

namespace GeoFrame.Entity.Models
{
   public class CsvBase
   {
      public virtual void AssignValuesFromCsv(string[] propertyValues)
      {
         var properties = GetType().GetProperties();
         try
         {
            for (var i = 0; i < properties.Length; i++)
            {
               if (properties[i].PropertyType.IsSubclassOf(typeof(CsvBase)))
               {
                  i = AssignValue(propertyValues, properties, i);
               }
               else
               {
                  SetDefault(propertyValues, properties, i);
               }
            }
         }
         catch (Exception e)
         {
            Console.WriteLine("This error was thrown: {0}", e);
         }
      }

      private int AssignValue(string[] propertyValues, PropertyInfo[] properties, int i)
      {
         var instance = Activator.CreateInstance(properties[i].PropertyType);
         var instanceProperties = instance.GetType().GetProperties();
         var propertyList = new List<string>();

         for (var j = 0; j < instanceProperties.Length; j++)
         {
            propertyList.Add(propertyValues[i + j]);
         }

         var m = instance.GetType().GetMethod("AssignValuesFromCsv", new Type[] { typeof(string[]) });
         m.Invoke(instance, new object[] { propertyList.ToArray() });
         properties[i].SetValue(this, instance);
         i += instanceProperties.Length;
         return i;
      }

      private void SetDefault(string[] csvDataValues, PropertyInfo[] modelProperties, int i)
      {
         var typeName = modelProperties[i].PropertyType.Name;

         switch (typeName)
         {
            case "Int32":
               // Catching TryParse: http://stackoverflow.com/questions/4945763/what-is-better-int-tryparse-or-try-int-parse-catch
               var myInt = 0;
               modelProperties[i].SetValue(this, int.TryParse(csvDataValues[i], out myInt) ? myInt : 0);
               break;
            case "Double":
               var mynew = 0.0;
               modelProperties[i].SetValue(this,
                   double.TryParse(csvDataValues[i], out mynew) ? mynew : 0.0);
               break;
            default:
               modelProperties[i].SetValue(this, csvDataValues[i]);
               break;
         }
      }
   }
}