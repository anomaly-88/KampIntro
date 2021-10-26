using OdevHafta1_2.ENTITY;
using OdevHafta1_2.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta1_2.MANAGERS
{
    class MonitorManager : IMonitorService
    {
        User user;
        IMailService mailService;

        public MonitorManager(User user, IMailService mailService)
        {
            this.mailService = mailService;
            this.user = user;
            //mailService.CheckUserMailPermissions(user);
        }


        public void MonitorComment(string comment)
        {
            //filter code..
            //send to mail service
            Console.WriteLine("Monitor Comment Activated.\n Comment: " + comment + "\n");
            Console.WriteLine("Check UserMailPermService Activated.");
            mailService.CheckUserMailPermissions(user);
        }
    }
}
