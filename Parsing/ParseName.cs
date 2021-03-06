using System.Collections.Generic;

namespace DatabaseCompare.Parsing
{
    public class ParseName
    {
        private readonly Parser _parser; 
        public ParseName()
        {
            _parser = new Parser();
        }
        public HashSet<string> FindNamesHash(string FilePath)
        {
            string[] fields = { "name ", "group " };
            var data = new List<string>();
            var returnNames = new HashSet<string>();

            data = _parser.ProcessFileList(FilePath, fields);

            for(int i = 0; i < data.Count; i += fields.Length)
            {
                if(!data[i + 1].Equals("2BDELETE"))
                {
                    returnNames.Add(data[i]);
                }
            }

            return returnNames;
        }

        public List<string> FindNamesList(string FilePath)
        {
            string[] fields = { "name ", "group " };
            var data = new List<string>();
            var returnNames = new List<string>();

            data = _parser.ProcessFileList(FilePath, fields);

            for(int i = 0; i < data.Count; i += fields.Length)
            {
                if(!data[i + 1].Equals("2BDELETE"))
                {
                    returnNames.Add(data[i]);
                }
            }

            return returnNames;
        }
    }
}
