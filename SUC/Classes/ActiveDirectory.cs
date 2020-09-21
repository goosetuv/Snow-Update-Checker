using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Threading.Tasks;

namespace SUC.Classes
{
    class ActiveDirectory
    {
        public static List<string> GetComputers(string domain)
        {
            List<string> computerNames = new List<string>();

            using (DirectoryEntry entry = new DirectoryEntry(domain))
            {
                using (DirectorySearcher mySearcher = new DirectorySearcher(entry))
                {
                    mySearcher.Filter = ("(objectClass=computer)");

                    // No size limit, reads all objects
                    mySearcher.SizeLimit = 0;

                    // Read data in pages of 250 objects. Make sure this value is below the limit configured in your AD domain (if there is a limit)
                    mySearcher.PageSize = 250;

                    // Let searcher know which properties are going to be used, and only load those
                    mySearcher.PropertiesToLoad.Add("name");

                    foreach (SearchResult resEnt in mySearcher.FindAll())
                    {
                        // Note: Properties can contain multiple values.
                        if (resEnt.Properties["name"].Count > 0)
                        {
                            string computerName = (string)resEnt.Properties["name"][0];
                            computerNames.Add(computerName);
                        }
                    }
                }
            }

            return computerNames;
        }

        public static string GetLDAPAsync()
        {
            try
            {
                string defaultNamingContext = "LDAP://";
                using (DirectoryEntry deRoot = new DirectoryEntry("LDAP://RootDSE"))
                {
                    if (deRoot.Properties["defaultNamingContext"] != null)
                    {
                        defaultNamingContext = @"LDAP://" + deRoot.Properties["defaultNamingContext"].Value.ToString();
                    }
                }
                return defaultNamingContext;
            } catch (Exception ex)
            {
                return "LDAP://";
            }
        }
    }
}
