using OdevHafta1_2.ENTITY;
using OdevHafta1_2.MANAGERS;
using OdevHafta1_2.PAGE;
using OdevHafta1_2.SERVICE;
using System;
using System.Collections.Generic;

namespace OdevHafta1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.UserId=1;
            user1.Authority=1;
            user1.UserName="Admin";
            user1.Mail="admin@local";
            user1.CreditCard="888-888-888";
            user1.UserSettings = new Dictionary<string, int> { { "MailPerm", 100 }, { "Theme", 1 }, {"Uye Mesajlari Alimi",0 }, {"Bildirimler",0 } };
            user1.Subscriptions = new List<string> { "Satranç Kulübü", "Kütüphane Kulübü"};
            user1.Courses = new List<int>{ 1,2,3 };

            User user2 = new User();
            user2.UserId = 2;
            user2.Authority = 2;
            user2.UserName = "KsK";
            user2.Mail = "KsK@local";
            user2.CreditCard = "666-555-888";
            user2.UserSettings = new Dictionary<string, int> { { "MailPerm", 101 }, { "Theme", 1 }, { "Uye Mesajlari Alimi", 0 }, { "Bildirimler", 0 } };
            user2.Subscriptions = new List<string> { "Satranç Kulübü", "Kütüphane Kulübü" };
            user2.Courses = new List<int> { 1, 2, 3 };

            Course course1 = new Course()
            {
                CourseID = 1,
                Name = "Java",
                Description = "İleri Seviye Java",
                Price = 999,
                Lecturer = "Arif Kahyaoğlu"
            };

            Course course2 = new Course()
            {
                CourseID = 2,
                Name = "C#",
                Description = "İleri Seviye C#",
                Price = 998,
                Lecturer = "Tim Cook"
            };

            Course course3 = new Course()
            {
                CourseID = 3,
                Name = "Python",
                Description = "İleri Seviye Python",
                Price = 997,
                Lecturer = "Canan Karatay"
            };




            IUserService userService = new UserServiceManager();
            IMonitorService monitor = new MonitorManager(user2, new MailServiceManager());
            CommentManager newComment1 = new CommentManager(monitor); 

            Console.WriteLine("");

            //Kullanıcı Erişimini Tayin Etmek
            userService.AuthorityControl(user1);


            //Ex: i want to see it. Writeln PostAuthorityDict.
            Dictionary<string, bool> permDict = userService.PostAuthority();
            foreach (var (key, value) in permDict)
            {
                Console.WriteLine(key + " : " + value);
            }
            //EOW

            Console.WriteLine("");

            // Ex: Select new theme
            userService.SetUserSettings(user2, "Theme", 2);

            Console.WriteLine("");

            // Ex: new comment
            newComment1.Add("Dolar kaç olur hocam ?");


            //Page
            AdminPanel adminPanel = new AdminPanel(userService);
            
            
        }
    }
}
