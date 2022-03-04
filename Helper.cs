using System.IO;

namespace DatabaseCompare
{
    public static class Helper
    {
        public static string CleanFieldString(string line, string field)
        {
            return line.Replace(field, "").Trim();
        }

        public static bool CheckFields(string line, string field)
        {
            return line.StartsWith(field);
        }

        public static bool CheckArguments(string[] arguments)
        {
            return arguments.Length == 3;
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
