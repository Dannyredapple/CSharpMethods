using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using Sequentum.ContentGrabber.Api;
public class Script
{
	public static string[] ProvideSimpleData(SimpleDataProviderArguments args)
	{
		List<string> first = new List<string>();
		List<string> second = new List<string>();
		List<string> letters = new List<string>();
		char FistCombination = 'A';
        while (FistCombination <= 'Z')
        {
			first.Add(FistCombination.ToString());
			second.Add(FistCombination.ToString());
            FistCombination++;
        }
		foreach(string firstComb in first){
			foreach(string secondComb in second){
				letters.Add(firstComb+secondComb);
			}
		}
		return letters.ToArray();
	}
}
