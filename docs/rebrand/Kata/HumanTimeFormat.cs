using System;
public class HumanTimeFormat{

  public static string formatDuration(int seconds){
  	int MINUTE = 60;
  	int HOUR = MINUTE * 60;
	int DAY = HOUR * 24;
	int YEAR = DAY * 365;
    
    if (seconds == 0) return "now";
	if (seconds == 1) return "1 second";
	if (seconds < 61) return string.Concat(seconds, " seconds");
	if (seconds < HOUR) {
		return formatDuration(seconds, MINUTE, "minute", "minutes");
	}
	if (seconds < DAY) {
		return formatDuration(seconds, HOUR, "hour", "hours");
	}
	if (seconds < YEAR) {
		return formatDuration(seconds, DAY, "day", "days");
	}
	return formatDuration(seconds, YEAR, "year", "years");
  }
  
  static string formatDuration(int seconds, int d, string k1, string k2){
	int hrs = Convert.ToInt32(Math.Floor((decimal)seconds / d));
	if (hrs == 0) return string.Empty;
	int s = seconds % d;
	string x = string.Concat(hrs, " ", hrs == 1 ? k1 : k2);
	string y = formatDuration(s);
	if (s != 0) x = string.Concat(x, y.Contains("and") ? ", " : " and ", y);
	return x;
  }
}