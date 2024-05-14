using System;
using System.Collections.Generic;
using System.Linq;
namespace TestTaker
{
	public static class CustomCode
	{
		public static int VersionCompare( string version1, string version2 ) {
		 //Insert your code here 
		 	if (version1 == version2) return 0;
			var arr1 =  GetVersionNums(version1);
			var arr2 =  GetVersionNums(version2);
			
			int d = arr1.Count - arr2.Count;
			/* equalize if number of sections are different */
			if (d != 0) {
				List<int> arr = d < 0 ? arr1 : arr2;
				for(int i = 0; i < Math.Abs(d); i++) {
					arr.Add(0);
				}            
			}
			/* compare each number section */
			for(int i = 0; i < arr1.Count; i++) {
				int v1 = arr1[i];
				int v2 = arr2[i];
				if (v1 < v2) return -1;
				else if (v1 > v2) return 1;
			}
			return 0;
		}

		private static List<int> GetVersionNums(string v) {
			return v.Split('.').Select(x => int.Parse(x)).ToList();
		}
	}
}