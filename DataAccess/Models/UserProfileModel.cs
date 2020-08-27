using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Models
{
    public class UserProfileModel
    {
        public int userId { get; set; }
        public CareerAdjectiveProfileModel careerAdjectiveProfileModel { get; set; }
        public ProjectProfileModel projectProfileModel { get; set; }
        public ContactProfileModel contactProfileModel { get; set; }
        public AboutProfileModel aboutProfileModel { get; set; }
        public SelfImageProfileModel selfImagProfileModel { get; set; }
        public ExperienceProfileModel experienceProfileModel { get; set; }
        public BlogProfileModel blogProfileModel { get; set; }
        public ToolsIUseModel toolsIUseModel { get; set; } 
        public SkillProfileModel skillProfileModel{ get; set; }
        public AccomplishmentProfileModel accomplishmentProfileModel { get; set; }
        public AcademicProfileModel academicProfileModel { get; set; }
        public RandomFactProfileModel randomFactProfileModel { get; set; }
    }
}