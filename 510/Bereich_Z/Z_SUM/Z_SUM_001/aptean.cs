using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Ranorex.Core.Testing;

namespace Ranorex.AutomationHelpers.UserCodeCollections
{
	/// <summary>
    /// An Aptean collection of useful general helper methods.
    /// </summary>
    [UserCodeCollection]
    public static class Aptean
    {
		private const string libraryName = "Aptean";
        //private static readonly Dictionary<string, System.DateTime> timers = new Dictionary<string, System.DateTime>();

		/// <summary>
        /// Returns the current time and date as a string in the specified format.
        /// </summary>
        /// <param name="expectedFormat">The format the time and date are returned in. 
		/// Default = dd.MM.yyyy					f.E.: 01.01.2020 dd.MM.yyyy = 01.01.2020;
		///</param>
        /// <returns>The current time and date as a string.</returns>
        [UserCodeMethod]
        public static string GetSystemDateTimeAsString(string expectedFormat = "dd.MM.yyyy")
        {
			// only one digit by Day IF the Date has only 1 digit.
            if(expectedFormat != "dd.MM.yyyy")
            	return (GetDateAsString(System.DateTime.Now.ToString(), expectedFormat));
            else
                  return System.DateTime.Now.ToString(expectedFormat);
        }

		/// <summary>
		/// Returns the given date as a string in the specified format.
		/// </summary>
		///<param name="date"> Date to extract the info
		///</param>
		/// <param name="expectedFormat">The format the time and date are returned in. 
		/// dd = the two digits by Day, 			f.E.: 03.10.2020 dd = 03; 	15.10.2020 dd = 15
		/// d = only one digit by Day, 				f.E.: 03.10.2020 d = 3; 	15.10.2020 d = 15
		/// MM = the two digits by Month 			f.E.: 01.01.2020 MM = 01; 	15.12.2020 MM = 12
		/// M = only one digit by Month,			f.E.: 01.01.2020 M = 1; 	15.12.2020 M = 12
		/// yy = only the two last digits by Year	f.E.: 01.01.2020 yy = 20; 	15.12.2003 yy = 03
		/// yyyy = the four digits by Year			f.E.: 01.01.2020 yyyy = 2020; 15.12.2003 yyyy = 2003
		/// MM.yyyy = month and year				f.E.: 01.01.2020 MM.yyyy = 01.2020
		/// HH = the two digits by Hour,			f.E.: 01.01.2020 02:08:34 	HH = 02
		/// H = only one digit by Hour,				f.E.: 01.01.2020 02:08:34 	H = 2
		/// mm = the two digits by Minute,			f.E.: 01.01.2020 02:08:34 	mm = 08
		/// m = only one digit by Minute,			f.E.: 01.01.2020 02:08:34 	m = 8		
		/// ss = the two digits by second,			f.E.: 01.01.2020 02:08:04 	ss = 04
		/// s = only one digit by second,			f.E.: 01.01.2020 02:08:04 	s = 4
		/// Default = dd.MM.yyyy					f.E.: 01.01.2020 dd.MM.yyyy = 01.01.2020
		///</param>
		/// <returns>The given date as a string.</returns>
		[UserCodeMethod]
		public static string GetDateAsString(string date, string expectedFormat = "dd.MM.yyyy")
		{
			// Tage
            if(expectedFormat=="d" || expectedFormat == "dd" && date.Length>1)
            {
            	if(date[0]=='0')
            		return (date[1].ToString());
            	else
            		return ((date[0].ToString()+date[1].ToString()));
            }
			
			// Monat
			if (expectedFormat=="M" || expectedFormat == "MM" && date.Length>4)
			{
				if(date[3]=='0')
					return (date[4].ToString());
				else
					return (date[3].ToString()+date[4].ToString());
			}
			
			// Jahr
			if (expectedFormat == "yy" ||expectedFormat == "y" && date.Length > 9)
				return (date[8].ToString() + date[9].ToString());
			if (expectedFormat == "yyyy" && date.Length > 9)
				return (date[6].ToString() + date[7].ToString() + date[8].ToString() + date[9].ToString());
			
			// Monat.Jahr
			if(expectedFormat=="MM.yyyy" && date.Length > 9)
				return (date[3].ToString()+date[4].ToString()+date[5].ToString()+date[6].ToString() + date[7].ToString() + date[8].ToString() + date[9].ToString());
			
			// Stunde
			if(expectedFormat=="H" ||expectedFormat=="HH" && date.Length > 12)
			{
				if(date[11]=='0')
					return (date[12].ToString());
				else
					return (date[11].ToString()+date[12].ToString());
			}
			
			// Minute
			if(expectedFormat=="m" || expectedFormat=="mm" && date.Length > 15)
			{
				if(date[14]=='0')
					return (date[15].ToString());
				else
					return (date[14].ToString()+date[15].ToString());
			}
			
			// Sekunde
			if(expectedFormat=="s" || expectedFormat=="ss" && date.Length > 18)
			{
				if(date[17]=='0')
					return (date[18].ToString());
				else
					return (date[17].ToString()+date[18].ToString());
			}
			
			// Minute:Sekunde
			if(expectedFormat=="mm:ss" && date.Length > 18)
			{
				if(date[14]=='0')
					return (date[15].ToString()+date[16].ToString()+date[17].ToString()+date[18].ToString());
				else
					return (date[14].ToString()+date[15].ToString()+date[16].ToString()+date[17].ToString()+date[18].ToString());
			}
			if(expectedFormat=="dd.MM.yyyy" && date.Length >9)
				return (date[0].ToString()+date[1].ToString()+date[2].ToString()+date[3].ToString()+date[4].ToString()+date[5].ToString()+date[6].ToString() + date[7].ToString() + date[8].ToString() + date[9].ToString());
			else
				return date;
		}
		/// <summary>
		/// Prüfen, ob der Inhalt des Feldes field_D und die Variable D beim Vergleich ohne vorangestellte 0 gleich sind. 
		/// </summary>
		/// <param name="field_D1">Zelle mit dem Inhalt von field_D1</param>
		/// <param name="D1">Variable D1</param>
		[UserCodeMethod]
		public static void Validate2Digits(string field_D1, string D1)
		{
			// Inhalt von Feld wird als Integer konvertiert           
			int Period_int1 = Convert.ToInt32(field_D1);
			// Periode_int1 (konvertierte Inhalt von Feld als integer) wird als String konvertiert
			string Period_string1 = Period_int1.ToString();

			// Inhalt von Variable wird als Integer konvertiert
			int Period_int2 = Convert.ToInt32(D1);
			// Periode_int2 (konvertierte Inhalt von Variable als integer) wird als String konvertiert
			string Period_string2 = Period_int2.ToString();
			
			Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$D1) on item 'cellInfo'." + field_D1);
			// Vergleichen die Periode_string1 und Periode_string2
			Validate.AreEqual(Period_string1, Period_string2);
		}
		/// <summary>
		/// Prüfen, ob der Inhalt des Feldes field_D1 und die Variable D1 ohne Dezimalstellen gleich sind. 
		/// </summary>
		/// <param name="field_D1">Zelle mit dem Inhalt von field_D1</param>
		/// <param name="D1">Variable D1</param>
		[UserCodeMethod]
		public static void ValidateWithoutDecimals(string field_D1, string D1)
		{
			Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$D1) on item 'cellInfo'."+ field_D1);
			string variable1="", variable2 ="";
			if (field_D1.Contains(','))
			{
				//Feld field_D1 ohne Nachkommastellen
				variable1 = field_D1.Split(',')[0];

				//Variable ohne Nachkommastellen
				variable2 = D1.Split(',')[0];
			}
			else if (field_D1.Contains('.'))
			{
				//Feld field_D1 ohne Nachkommastellen
				variable1 = field_D1.Split('.')[0];

				//Variable ohne Nachkommastellen
				variable2 = D1.Split('.')[0];
			}
			Validate.AreEqual(variable1, variable2);
		}
		/// <summary>
		/// Erhalten das aktuelle Datum plus Zähler counter
		/// </summary>
		/// <param name="s">Was wollen wir addieren. zB.: d(Tag), M(Monat), y(Jahr), H(Stunde), m(Minute),s(Sekunde) </param>
		/// <param name="counter">wie viel wollen wir addieren</param>
		/// <returns>Datum plus Zähler counter</returns>
		[UserCodeMethod]
        public static string GetSystemDateTimePlus(string s, int counter)
        {
			return (GetDateTimePlus(System.DateTime.Now.ToString(), s, counter));
        }
		/// <summary>
		/// Erhalten das angegebene Datum plus Zähler counter
		/// </summary>
		/// <param name="date">das Datum für die Bearbeitung</param>
		/// <param name="s">Was wollen wir addieren. zB.: d(Tag) oder M(Monat) oder y(Jahr) </param>
		/// <param name="counter">wie viel wollen wir addieren</param>
		/// <param name="expectedFormat">Das Format, in dem Uhrzeit und Datum zurückgegeben werden</param> 
		/// <returns>Datum plus Zähler counter</returns>
		[UserCodeMethod]
		public static string GetDateTimePlus(string date, string s, int counter, string expectedFormat = "dd.MM.yyyy")
		{
			System.DateTime d1 = System.DateTime.Parse(date);
			System.DateTime d2 = System.DateTime.Parse(date);
			//Tage
			if(s=="d" || s=="dd")
			{
				d2 = d1.AddDays(counter);
			}
			//Monat
			else if(s=="M" || s=="MM")
			{
				d2 = d1.AddMonths(counter);
			}
			//Jahr
			else if(s=="y" || s=="yy" || s=="yyyy")
			{
				d2= d1.AddYears(counter);
			}
			//Stunden
			if(s=="H" || s=="HH")
			{
				d2 = d1.AddHours(counter);
				if(expectedFormat.IsEmpty())
					expectedFormat = "a";
			}
			//Minute
			else if(s=="m" || s=="mm")
			{
				d2 = d1.AddMinutes(counter);
				if(expectedFormat.IsEmpty())
					expectedFormat = "a";
			}
			//Sekunde
			else if(s=="s" || s=="ss" || s=="mm:ss")
			{
				d2= d1.AddSeconds(counter);
				if(expectedFormat.IsEmpty())
					expectedFormat = "a";
			}
			return GetDateAsString(d2.ToString(), expectedFormat);
		}
		/// <summary>
		/// vergleichen ob variable ist gleich var1 ODER var2
		/// </summary>
		/// <param name="variable">Feld Inhalt</param>
		/// <param name="var1">Variable 1</param>
		/// <param name="var2">Variable 2</param>
		[UserCodeMethod]
		public static void ValidateVar1Var2(string variable, string var1, string var2)
		{			
			if(variable.Equals(var1, StringComparison.CurrentCultureIgnoreCase) || (variable.Equals(var2, StringComparison.CurrentCultureIgnoreCase)))
			{
			  	Report.Log(ReportLevel.Info, "Validation", $"Validating AttributeEqual (Text=$var1) {var1} = {variable}");
			}
			else
				throw new ValidationException($"Module execution was aborted because a validation step has failed. Attribute 'Text' of element does not match the specified value (actual= '{variable}' , expected= '{var1}|{var2}').");
		}
		/// <summary>
		/// erhalten den Namen des Rechners , auf dem der Testfall ausgeführt wurde
		/// </summary>
		/// <returns>Computer Name, auf dem der Testfall ausgeführt wurde</returns>
		[UserCodeMethod]
		public static string GetHost()
		{		
			return Host.Local.MachineName;
		}
	}
}