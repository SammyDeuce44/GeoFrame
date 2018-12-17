using System;
using GeoFrame.Entity.Models;

namespace GeoFrame.Entity.CsvModels
{
    public class Profile : CsvBase
    {
        public Profile() { }
        public Profile(string id, string profileMapId, string firstName, string lastName, string codeName, string gender,
            int age, int birthDay, int birthMonth, int birthYear, int heightCm, string nationalityId, string raceId,
            string timeline, string titleId, string archetypeId, string teamId, string description)
        {
            Id = id;
            ProfileMapId = profileMapId;
            FirstName = firstName;
            LastName = lastName;
            CodeName = codeName;
            Gender = gender;
            Age = Convert.ToInt32(age);
            BirthDay = Convert.ToInt32(birthDay);
            BirthMonth = Convert.ToInt32(birthMonth);
            BirthYear = Convert.ToInt32(birthYear);
            HeightCm = Convert.ToInt32(heightCm);
            NationalityId = nationalityId;
            RaceId = raceId;
            Timeline = timeline;
            TitleId = titleId;
            ArchetypeId = archetypeId;
            TeamId = teamId;
            Description = description;
        }

        public string Id { get; set; }
        public string ProfileMapId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CodeName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int BirthDay { get; set; }
        public int BirthMonth { get; set; }
        public int BirthYear { get; set; }
        public int HeightCm { get; set; }
        public string NationalityId { get; set; }
        public string RaceId { get; set; }
        public string Timeline { get; set; }
        public string TitleId { get; set; }
        public string ArchetypeId { get; set; }
        public string TeamId { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} " +
                                 "{8} {9} {10} {11} {12} {13} {14} {15} {16} {17}",
                    Id, ProfileMapId, FirstName, LastName, CodeName, Gender, Age, BirthDay, BirthMonth, BirthYear,
                    HeightCm, NationalityId, RaceId, Timeline, TitleId, ArchetypeId, TeamId, Description);
        }
    }
}