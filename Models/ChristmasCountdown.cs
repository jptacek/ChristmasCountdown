using System.ComponentModel.DataAnnotations;
using System;

namespace MvcSample.Web.Models
{
    public class ChristmasCount
    {
    	private DateTime _startTime = DateTime.Now;
       
       public ChristmasCount() {
       	_startTime = DateTime.Now;
       }

        public string TimeTilChristmas { 
        	get 
        	{
        		DateTime eventDate = new DateTime(2014, 12, 25, 5, 00, 0);
        		return CalcuateDisplayString(eventDate);
        	} 
        }
        public string TimeTilBuild { 
        	get 
        	{
        		DateTime eventDate = new DateTime(2015, 04, 29, 11, 00, 0);
        		return CalcuateDisplayString(eventDate);
        	} 
        }
        public string TimeTilSW7 { 
        	get 
        	{
        		DateTime eventDate = new DateTime(2015, 12, 18, 0, 00, 0);
        		return CalcuateDisplayString(eventDate);
        	} 
        }

        private string CalcuateDisplayString(DateTime eventTime) {
        TimeSpan dateDifference = eventTime.Subtract(_startTime);
        	int months = _startTime.Month - eventTime.Month;
        	int days = _startTime.Day - eventTime.Day;
        	
        	string timeDiff = String.Format("{0:%d} day(s) {0:%h} hour(s) {0:%m} minutes(s)", dateDifference);
            
        	return timeDiff ;
        }
    }
}
