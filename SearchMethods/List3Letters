using System;
using System.Collections.Generic;
using System.Data;
using Sequentum.ContentGrabber.Api;
public class Script
{
	//See help for a definition of SimpleDataProviderArguments.
	public static string[] ProvideSimpleData(SimpleDataProviderArguments args)
	{
		List<string> LetterList = new List<string>();

        for (char c1 = 'A'; c1 <= 'Z'; c1++)
        {
            for (char c2 = 'A'; c2 <= 'Z'; c2++)
            {
                for (char c3 = 'A'; c3 <= 'Z'; c3++)
                {
                    string letter = string.Format("{0}{1}{2}*", c1, c2, c3);
                    LetterList.Add(letter);
                }
            }
        }
		return LetterList.ToArray();
	}
}
