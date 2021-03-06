using System.Collections.Generic;
using System.IO;
using System;

namespace DatabaseCompare.Parsing
{
    public class Parser
    {
        public List<string> ProcessFileList(string filePath, string[] fields)
        {
            var data = new List<string>();
            string line = "";

            try
            {
                using (StreamReader readFile = new StreamReader(filePath))
                {
                    while ((line = readFile.ReadLine()) != null)
                    {
                        foreach (var field in fields)
                        {
                            if (Helper.CheckFields(line, field))
                            {
                                data.Add(Helper.CleanFieldString(line, field));
                            }
                        }
                    }
                }
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            return data;
        }

        public HashSet<string> ProcessFileHash(string FilePath, string Field)
        {
            var data = new HashSet<string>();
            string line = "";
            
            try
            {
                using(StreamReader readFile = new StreamReader(FilePath))
                {
                    while((line = readFile.ReadLine()) != null)
                    {
                        if(Helper.CheckFields(line, Field))
                        {
                            data.Add(Helper.CleanFieldString(line, Field));
                        }
                    }
                }
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            return data;
        }
    }
}
