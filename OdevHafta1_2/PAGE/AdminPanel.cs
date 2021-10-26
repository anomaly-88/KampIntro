using OdevHafta1_2.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta1_2.PAGE
{
    class AdminPanel
    {
        bool access = false;
        bool edit = false;
        bool delete = false;

        IUserService userService;

        public AdminPanel(IUserService userService)
        {
            this.userService = userService;
            CheckAuth();
        }

         private void CheckAuth()
        {
            int authLevel = userService.GetAuth();
            if(authLevel == 1) { 
            Console.WriteLine("Access Verified.");
           

            Dictionary<string, bool> listOfPerm = userService.PostAuthority();
             foreach (var (k,v) in listOfPerm) {
                    if(k.Contains("adminPanelAccess") && v.Equals(true))
                    {
                        access = true;
                    }
                    

                    if (k.Contains("adminPanelEditPerm") && v.Equals(true))
                    {
                        edit = true;
                    }
                         
                }

                if(this.access)PageContent();
                if(this.edit)EditPageContent(); 


            }
            else { Console.WriteLine("You have no auth access to the this page."); }

        }

        public void PageContent()
        {
            //içerik aşağıdaki gibi olsun.
            Console.WriteLine("Admin panel içerik");
            //Dictionary<string, bool> listOfPerm = userService.PostAuthority();
            
            //foreach (var i in listOfPerm) { Console.WriteLine(i); }
        }

        private void EditPageContent()
        {
            //içerik aşağıdaki gibi olsun.
            Console.WriteLine("Admin panel edit içerik");
            //Dictionary<string, bool> listOfPerm = userService.PostAuthority();

            //foreach (var i in listOfPerm) { Console.WriteLine(i); }
        }

    }
}
