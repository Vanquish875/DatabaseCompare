using DatabaseCompare.DotLFields;
using DatabaseCompare.Models;
using System;
using System.Collections.Generic;

namespace DatabaseCompare.Mapping
{
    public class RemoteMapping
    {
        public Dictionary<string, Remote> MapRemote(List<string> data)
        {
            int FieldLength = RemoteFields.Fields.Length;
            var remotes = new Dictionary<string, Remote>();

            try
            {
                for (int i = 0; i < data.Count; i += FieldLength)
                {
                    var remote = new Remote
                    {
                        Name = data[i],
                        Group = data[i + 1],
                        Description = data[i + 2],
                        PriorityDisplay = data[i + 3],
                        Protocol = data[i + 4],
                        Address = data[i + 5]
                    };
                    remotes.Add(remote.Name, remote);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return remotes;
        }
    }
}
