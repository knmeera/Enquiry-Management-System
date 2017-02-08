using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enquiry.Models
{
    public class Chanel
    {
        public int ChanelId { get; set; }
        public string ChanelName { get; set; }

        public List<Chanel> ListOfChanels()
        {
            List<Chanel> ChanelsList = new List<Chanel>() ;
            ChanelsList.Add(new Chanel { ChanelId = 1, ChanelName = "Walk In" });
            ChanelsList.Add(new Chanel { ChanelId = 2, ChanelName = "Phone" });
            ChanelsList.Add(new Chanel { ChanelId = 3, ChanelName = "E-Mail" });
           
            return ChanelsList;

        }

    }
}