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

        for (char c = 'A'; c <= 'Z'; c++)
        {
            LetterList.Add(c.ToString()+ "*");
        }

		return LetterList.ToArray() ;
	}
}
