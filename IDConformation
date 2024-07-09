using System;
using System.Text.RegularExpressions;
using System.Globalization;
using Sequentum.ContentGrabber.Api;

public class Script
{
    public static string TransformContent(ContentTransformationArguments args)
    {
        string firstName = args.DataRow["FirstName"].Trim();
        string lastName = "MARCHANT, JENNIFER NICOLE SERVICE"; //args.DataRow["LastName"].Trim();
        string suffix = args.DataRow["Suffix"].Trim();
        string caseNumber = args.DataRow["CaseNumberRaw"].Trim();
        string sourceInfoID = args.GlobalData.GetString("SourceInfoID");
        string id = string.Empty;

        try
        {
            firstName = firstName.Length >= 7 ? firstName.Remove(6) : firstName;
            lastName = lastName.Length >= 7 ? lastName.Remove(6) : lastName;

            firstName = Regex.Replace(firstName, @"[^0-9a-zA-Z]", string.Empty);
            lastName = Regex.Replace(lastName, @"[^0-9a-zA-Z]", string.Empty);
            caseNumber = Regex.Replace(caseNumber, @"[^0-9a-zA-Z]", string.Empty);

            // Check if firstName is "EMPTY" and remove it if true
            string namePart = (firstName.ToUpper() == "EMPTY") ? lastName : lastName + firstName;

            id = string.Format("{0}_{1}_{2}", sourceInfoID, namePart, caseNumber);

            id = Regex.Replace(id, @"[^0-9a-zA-Z_]", string.Empty);

            id = id.Length > 51 ? id.Remove(50) : id;
        }
        catch (Exception error)
        {
            string message = string.Format("Error creating ID: {0}", error.Message);
            args.WriteDebug(error.Message, DebugMessageType.Error);

            id = caseNumber;
            id = Regex.Replace(id, @"[^0-9a-zA-Z]", string.Empty);
        }

        return id.ToUpper();
    }
}
