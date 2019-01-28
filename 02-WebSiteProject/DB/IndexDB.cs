using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_WebSiteProject.DB
{
    public class IndexDB
    {
        public IndexDB()
        {
            
        }

        public static Dictionary<string,string> ChooseList { get; set; }
        public static Dictionary<string, string> WhyChooseUs()
        {
            ChooseList.Add("~/images/meeting.jpg", "<b>Our lawyers</b> Our website templates are created with inspiration, checked for quality and originality.");
            ChooseList.Add("~/images/handshake.jpg", "<b>get to know us more</b> Just browse through all our Free Website Templates and ﬁnd what you’re looking for.");
            ChooseList.Add("~/images/smile.jpg", "<b>what we offer</b> Join the discussion on our forum and meet other people in the community.");
            ChooseList.Add("~/images/family-small.jpg", "<b>get in touch with us</b> And we love the challenge of doing something diferent and something special.");

            return ChooseList;
        }
    }
}