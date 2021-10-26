using OdevHafta1_2.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta1_2.SERVICE
{
    interface IUserService
    {
        int AuthorityControl(User user);
        void SetUserSettings(User user, string set, int value);
        Dictionary<string, bool> PostAuthority();
        void ResetPerm();

        int GetAuth();

    }
}
