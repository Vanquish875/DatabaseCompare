using DatabaseCompare.DBCompare;
using DatabaseCompare.Print;
using System;

namespace DatabaseCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = "";
            string WhatTask = "";
            string WhatSystem = "";

            if(args[0].ToLower() == "-h")
            {
                Console.WriteLine("Provide path to .l files for both systems.");
                Console.WriteLine("Store the main systems .l files in a folder named pcc and the secondary system with a name tnd under the main directory provided.");
                Console.WriteLine("Provide TND if you wish to compare the points in the secondary system with the main system.");
                Console.WriteLine("Provide PCC if you wish to compare the points in the main system with the secondary system.");
                Console.WriteLine("Use -t to generate list of points in one system but not the other.");
                Console.WriteLine("Use -r to generate list of configurations of each system that don't match the system specfied.");
                Console.WriteLine("Use -i to generate ADE insert files for the points in one system but not the other. Note: Only works for analog, rate, and status tables.");
                Console.WriteLine(@"Example: C:\Temp\DotLFiles tnd -t");
                Console.WriteLine("Each folder should contain at least: acecode.l, aceconfig.l, analog.l, connection.l, multistate.l, rate.l, remote.l, and status.l");
                return;
            }

            if(Helper.CheckArguments(args))
            {
                FilePath = args[0];
                WhatSystem = args[1].ToUpper();
                WhatTask = args[2].ToUpper();
            }
            

            if(Helper.CheckForFilesInDirectory(FilePath))
            {
                if(WhatTask.Equals("-T"))
                {
                    var prog = new Program();
                    prog.CompareSystemsPoints(WhatSystem, FilePath);
                    return;
                }
                
                
                if(WhatTask.Equals("-R"))
                {
                    var prog = new Program();
                    prog.CompareSystemsConfigurations(WhatSystem, FilePath);
                    return;
                }

                if(WhatTask.Equals("-I"))
                {
                    var prog = new Program();
                    prog.CompareSystemsPointsAndAddADEInserts(WhatSystem, FilePath);
                    return;
                }

                if(WhatTask.Equals("-H"))
                {
                    Console.WriteLine("Use -t to generate list of points in one system but not the other.");
                    Console.WriteLine("Use -r to generate list of configurations of each system that don't match the specfied system.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Please make sure you have entered the correct path to all .l files.");
                Console.ReadLine();
            }
        }

        public void CompareSystemsPoints(string system, string filePath)
        {
            if(system.Equals("TND"))
            {
                PointCountCompare compare = new PointCountCompare();
                compare.CompareTNDToPCC(filePath, false);
                return;
            }

            if(system.Equals("PCC"))
            {
                PointCountCompare compare = new PointCountCompare();
                compare.ComparePCCToTND(filePath, false);
            }
        }

        public void CompareSystemsConfigurations(string system, string filePath)
        {
            if(system.Equals("TND"))
            {
                var compare = new PrintTNDPointConfigurationCompare();
                compare.PrintTNDTOPCC(filePath);
                return;
            }

            if(system.Equals("PCC"))
            {
                var compare = new PrintPCCPointConfigurationCompare();
                compare.PrintPCCToTND(filePath);
            }
        }

        public void CompareSystemsPointsAndAddADEInserts(string system, string filePath)
        {
            if (system.Equals("TND"))
            {
                PointCountCompare compare = new PointCountCompare();
                compare.CompareTNDToPCC(filePath, true);
                return;
            }

            if (system.Equals("PCC"))
            {
                PointCountCompare compare = new PointCountCompare();
                compare.ComparePCCToTND(filePath, true);
            }
        }
    }
}
