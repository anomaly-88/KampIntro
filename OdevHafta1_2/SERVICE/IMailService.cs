using OdevHafta1_2.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta1_2.SERVICE
{
    interface IMailService
    {
        string GetUserMail(User user);
        void CheckUserMailPermissions(User user);
        void SendMail();
    }
}
