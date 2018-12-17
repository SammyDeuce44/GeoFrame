using GeoFrame.Entity.Controller;
using GeoFrame.Entity.CsvModels;
using GeoFrame.Entity.Models;
using GeoFrame.Models;

namespace GeoFrame.Builder
{
   public class CsvBuilder
   {
      private readonly CsvController _controller;
      private readonly CsvContext _context;

      public CsvBuilder(CsvContext context)
      {
         var reader = new CsvStringReader();
         var storage = new DataStorage();
         _controller = new CsvController(reader, storage);
         _context = context;
      }

      public void Build()
      {
         RunBuild<Accessory>(CsvKey.Accessory);
         RunBuild<Actions>(CsvKey.Actions);
         RunBuild<Aidulon>(CsvKey.Aidulon);
         RunBuild<Archetype>(CsvKey.Archetype);
         RunBuild<Arena>(CsvKey.Arena);
         RunBuild<Armour>(CsvKey.Armour);
         RunBuild<Attributes>(CsvKey.Attributes);
         RunBuild<Barrier>(CsvKey.Barrier);
         RunBuild<BodyTone>(CsvKey.BodyTone);
         RunBuild<Combat>(CsvKey.Combat);
         RunBuild<FightStyle>(CsvKey.FightStyle);
         RunBuild<Hand>(CsvKey.Hand);
         RunBuild<ImpactArea>(CsvKey.ImpactArea);
         RunBuild<Level>(CsvKey.Level);
         RunBuild<MatchOfficial>(CsvKey.MatchOfficial);
         RunBuild<MediaCoverage>(CsvKey.MediaCoverage);
         RunBuild<MoveList>(CsvKey.MoveList);
         RunBuild<MoveSetMap>(CsvKey.MoveSetMap);
         RunBuild<Nationality>(CsvKey.Nationality);
         RunBuild<Overdrive>(CsvKey.Overdrive);
         RunBuild<Profile>(CsvKey.Profile);
         RunBuild<ProfileMap>(CsvKey.ProfileMap);
         RunBuild<ProfileStats>(CsvKey.ProfileStats);
         RunBuild<Race>(CsvKey.Race);
         RunBuild<Range>(CsvKey.Range);
         RunBuild<Rank>(CsvKey.Rank);
         RunBuild<Team>(CsvKey.Team);
         RunBuild<Technique>(CsvKey.Technique);
         RunBuild<Title>(CsvKey.Title);
         RunBuild<Weapon>(CsvKey.Weapon);
         RunBuild<WeaponGroup>(CsvKey.WeaponGroup);
         RunBuild<Weight>(CsvKey.Weight);
      }

      private void RunBuild<T>(CsvKey key) where T : CsvBase, new()
      {
         _controller.ConvertSingle<T>();
         var data = _controller.ReadSingle<T>();
         _context.Data.Add(key, data);
      }
   }
}
