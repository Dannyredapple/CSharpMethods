using System;
using Sequentum.ContentGrabber.Api;

public class Script
{
    //See help for a definition of ContentTransformationArguments.
    public static string TransformContent(ContentTransformationArguments args)
    {
        // Remove "AKA" or "aka" and the text following it
        string content = args.Content.Trim();
        int akaIndex = content.IndexOf("AKA", StringComparison.OrdinalIgnoreCase);
        if (akaIndex >= 0)
        {
            content = content.Remove(akaIndex).Trim();
        }

        // Remove "SHEETS #569-307,"
        content = content.Replace("SHEETS #569-307,", "").Trim();

        return content;
    }
}
