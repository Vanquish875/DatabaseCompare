using System.IO;

namespace DatabaseCompare
{
    public static class Helper
    {
        public static string CleanFieldString(string line, string field)
        {
            return RemoveWhiteSpace(line.Replace(field, ""));
        }

        public static bool CheckFields(string line, string field)
        {
            if (line.StartsWith(field))
            {
                return true;
            }

            return false;
        }

        public static string RemoveWhiteSpace(string input)
        {
            return input.Trim();
        }

        public static bool CheckArguments(string[] arguments)
        {
            if(arguments.Length == 3)
            {
                return true;
            }

            return false;
        }

        public static bool CheckForFilesInDirectory(string path)
        {
            bool PCCAnalogDotLExists = File.Exists(path + @"\pcc\analog.l");
            bool PCCRateDotLExists = File.Exists(path + @"\pcc\rate.l");
            bool PCCRemoteDotLExists = File.Exists(path + @"\pcc\remote.l");
            bool PCCStatusDotLExists = File.Exists(path + @"\pcc\status.l");
            bool TNDAnalogDotLExists = File.Exists(path + @"\tnd\analog.l");
            bool TNDRateDotLExists = File.Exists(path + @"\tnd\rate.l");
            bool TNDRemoteDotLExists = File.Exists(path + @"\tnd\remote.l");
            bool TNDStatusDotLExists = File.Exists(path + @"\tnd\status.l");

            if (PCCAnalogDotLExists && PCCRateDotLExists && PCCRemoteDotLExists && PCCStatusDotLExists &&
                TNDAnalogDotLExists && TNDRateDotLExists && TNDRemoteDotLExists && TNDStatusDotLExists)
            {
                return true;
            }

            return false;
        }
    }
}
