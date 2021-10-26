using OdevHafta1_2.ENTITY;
using OdevHafta1_2.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta1_2.MANAGERS
{
    class UserServiceManager : IUserService
    {
        bool adminPanelAccess = false;
        bool userPanelAccess = false;
        bool lecturerPanelAccess = false;

        bool adminPanelEditPerm = false;
        bool userPanelEditPerm = false;
        bool lecturerPanelEditPerm = false;

        int authority = 0;

        Dictionary<string, bool> ListOfPerm = new Dictionary<string, bool>();
        
        public void ResetPerm()
        {
            this.adminPanelAccess = false;
            this.userPanelAccess = false;
            this.lecturerPanelAccess = false;

            this.adminPanelEditPerm = false;
            this.userPanelEditPerm = false;
            this.lecturerPanelEditPerm = false;

            int authority = 0;
        }

        public int AuthorityControl(User user)
        {
            if (user.Authority == 1)
            {
                Console.WriteLine("Admin Level");
                ResetPerm();
                this.authority = 1;
                adminPanelAccess = true; userPanelAccess = true; lecturerPanelAccess = true;
                adminPanelEditPerm = true; userPanelEditPerm = true; lecturerPanelEditPerm = true;
                PostAuthority();
            }

            if (user.Authority == 2) { Console.WriteLine("User Level"); ResetPerm(); this.authority = 2; userPanelAccess = true; PostAuthority(); }

            if (user.Authority == 3) { Console.WriteLine("Lecturer Level"); ResetPerm(); this.authority = 3; userPanelAccess = true; lecturerPanelAccess = true; PostAuthority(); }

            if (user.Authority == 4) { Console.WriteLine("Editor Level"); ResetPerm(); this.authority = 4; userPanelAccess = true; lecturerPanelAccess = true; PostAuthority(); }

            if (user.Authority == 0) { Console.WriteLine("Waiting Mail Activation"); ResetPerm(); this.authority = 0; PostAuthority(); }
            if (user.Authority == 5) { Console.WriteLine("Banned."); ResetPerm(); this.authority = 5; PostAuthority(); }


            return this.authority;
        }

        public void SetUserSettings(User user, string set, int value)
        {
            Console.WriteLine("Current Theme: "+user.UserSettings[set]);
            user.UserSettings[set] = value;
            Console.WriteLine("Theme Changed To: "+value);
        }

        public Dictionary<string, bool> PostAuthority()
        {
            ListOfPerm.Clear();

            Dictionary <string, bool> temp = new Dictionary<string, bool>
            {
                { "adminPanelAccess", this.adminPanelAccess },
                { "userPanelAccess", this.userPanelAccess },
                { "lecturerPanelAccess", this.lecturerPanelAccess },

                { "adminPanelEditPerm", this.adminPanelEditPerm },
                { "userPanelEditPerm", this.userPanelEditPerm },
                { "lecturerPanelEditPerm", this.lecturerPanelEditPerm }
            };

            foreach(var (k,v) in temp) { ListOfPerm.Add(k, v); }

            temp.Clear();

            return ListOfPerm;
        }

        public int GetAuth() { return authority; }
    }
}
