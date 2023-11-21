namespace Utilities
{
    using System.Collections.Generic;
    
    public static class GuidMaintenance
    {
        public static Dictionary<string, HashSet<string>> GuidDict = new Dictionary<string, HashSet<string>>();

        public static string GenerateGuid(string userId, string tableName)
        {
            string key = "[" + userId + "][" +tableName + "]";  

            HashSet<string> guidSet;

            if (!GuidDict.ContainsKey(key))
            {
                guidSet = new HashSet<string>();

                GuidDict.Add(key, guidSet);
            }

            else
            {
                guidSet = GuidDict[key]; 
            }

            string guid = System.Guid.NewGuid().ToString();

            while (guidSet.Contains(guid))
            {
                guid = System.Guid.NewGuid().ToString();
            }

            guidSet.Add(guid); 

            return guid;

        }

    }
}