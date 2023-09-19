using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_poe
{
    class library
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Classhoursperweek { get; set; }
        public int Numberofcredits { get; set; }
        public int Numberofweeks { get; set; }

        public string Startdate { get; set; }
         public int Numberofhours { get; set; }
        public int Selfstudyhoursperweek { get; set; }

        public int Selfstudyhoursleft { get; set; }

        public library(string module_code,string module_name ,int number_of_credits, int hours_per_week,int number_of_weeks,int number_of_hours,int self_study_hours_per_week,int self_study_hours_left, DateTime start_date)
        {
       
            Name = module_code;
            Code = module_name;
            Numberofcredits= number_of_credits;
            Numberofweeks= number_of_weeks;
            Classhoursperweek= hours_per_week;
            DateTime Startdate;
            Selfstudyhoursperweek = self_study_hours_per_week;
            Selfstudyhoursleft = self_study_hours_left;
            Numberofhours= number_of_hours;
           
        }
        public string studentReport ()
        {
            return "\n module_code: " + Code + "\t" + "\nmodule_name :" + Name + "\t" + "\nnumber_of_credits :" + Numberofcredits + "\t" + "\nhours_per_week" + Classhoursperweek + "\t" + "\nnumber_of_weeks" + Numberofweeks + "\t" + "\nnumber_of_hours" + Numberofhours + "\nstart_date" + Startdate + "\nself-study_hours_per_week" + Selfstudyhoursperweek + "\t" + "\nself_study_hours_left" + Selfstudyhoursleft + "\t";

        }
    }
}
