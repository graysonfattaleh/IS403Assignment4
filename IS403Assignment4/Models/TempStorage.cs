using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS403Assignment4.Models
{
    public class TempStorage
    {
        public TempStorage()
        {
        }

        private static List<PersonalListEntry> suggestions = new List<PersonalListEntry>();

        // iteratable list
        public static IEnumerable<PersonalListEntry> Suggestions => suggestions;

        public static void addListEntry(PersonalListEntry ple)
        {
            suggestions.Add(ple);
        }
    }
}
