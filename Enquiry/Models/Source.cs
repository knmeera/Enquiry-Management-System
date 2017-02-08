using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enquiry.Models
{
    public class Source
    {
        public int SourceId { get; set; }
        public string SourceName { get; set; }


        public List<Source> ListofSources()
        {
            List<Source> ObjSources = new List<Source>();
            ObjSources.Add(new Source { SourceId = 1, SourceName = "Advertisement" });
            ObjSources.Add(new Source { SourceId = 1, SourceName = "Friends" });
            ObjSources.Add(new Source { SourceId = 1, SourceName = "Internet" });
            ObjSources.Add(new Source { SourceId = 1, SourceName = "Campaign" });
            return ObjSources;
        }
    }
}