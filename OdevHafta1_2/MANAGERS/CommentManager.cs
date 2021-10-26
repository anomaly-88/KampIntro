using OdevHafta1_2.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta1_2.MANAGERS
{
    class CommentManager
    {
        IMonitorService monitorService;
        
        public CommentManager(IMonitorService monitorService)
        {
            this.monitorService = monitorService;
            
        }


        //Get user for userID(Foreign key)...
        //etc..
        //kullanıcı profiline, sayfaya, kullanıcıya cevap olarak..
        //Comment parametresi biraz daha komplike olabilirdi, sümulasyon tabii bu.

        public void Add(string commentText) {
            
            Console.WriteLine("#ADD OP.  Comment: " + commentText + "\n \t  added to X Category Y Post. \n \t  New CommentID = x");

            monitorService.MonitorComment(commentText);
        }

        public void Delete() { Console.WriteLine("CommentID x : deleted."); }

        public void Update() { Console.WriteLine("CommentID x : updated."); }

    }
}
