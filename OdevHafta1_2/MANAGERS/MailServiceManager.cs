using OdevHafta1_2.ENTITY;
using OdevHafta1_2.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta1_2.MANAGERS
{
    class MailServiceManager : IMailService
    {

        string revievedServiceText = "Mail İçeriği";
        User user;

        // Email me when someone responds to my comments. 0/1
        // Email me when someone comments on a discussion I've commented in. 0/1
        // Receive instructional and promotional emails from Kodlama.io. 0/1
        public void CheckUserMailPermissions(User user)
        {

            int userMailPerm = 0;
            this.user = user;

            //Monitor all comments
            //monitor mentioned comments

            if (user.UserSettings["MailPerm"] == 100) {

                Console.WriteLine("Email me when someone responds to my comments: ON"+
                                  "\nEmail me when someone comments on a discussion I've commented in: OFF" +
                                  "\nReceive instructional and promotional emails from Kodlama.io : OFF");

                userMailPerm = user.UserSettings["MailPerm"];
            }
            if (user.UserSettings["MailPerm"] == 101)
            {

                Console.WriteLine("Email me when someone responds to my comments: ON" +
                                  "\nEmail me when someone comments on a discussion I've commented in: OFF" +
                                  "\nReceive instructional and promotional emails from Kodlama.io : ON");

                userMailPerm = user.UserSettings["MailPerm"];
            }
            if (user.UserSettings["MailPerm"] == 110)
            {

                Console.WriteLine("Email me when someone responds to my comments: ON" +
                                  "\nEmail me when someone comments on a discussion I've commented in: ON" +
                                  "\nReceive instructional and promotional emails from Kodlama.io : OFF");

                userMailPerm = user.UserSettings["MailPerm"];
            }
            if (user.UserSettings["MailPerm"] == 011)
            {

                Console.WriteLine("Email me when someone responds to my comments: OFF" +
                                  "\nEmail me when someone comments on a discussion I've commented in: ON" +
                                  "\nReceive instructional and promotional emails from Kodlama.io : ON");

                userMailPerm = user.UserSettings["MailPerm"];
            }
            if (user.UserSettings["MailPerm"] == 010)
            {

                Console.WriteLine("Email me when someone responds to my comments: OFF" +
                                  "\nEmail me when someone comments on a discussion I've commented in: ON" +
                                  "\nReceive instructional and promotional emails from Kodlama.io : OFF");

                userMailPerm = user.UserSettings["MailPerm"];
            }
            if (user.UserSettings["MailPerm"] == 000)
            {

                Console.WriteLine("Email me when someone responds to my comments: OFF" +
                                  "\nEmail me when someone comments on a discussion I've commented in: OFF" +
                                  "\nReceive instructional and promotional emails from Kodlama.io : OFF");

                userMailPerm = user.UserSettings["MailPerm"];
            }
            if (user.UserSettings["MailPerm"] == 111)
            {

                Console.WriteLine("Email me when someone responds to my comments: ON" +
                                  "\nEmail me when someone comments on a discussion I've commented in: ON" +
                                  "\nReceive instructional and promotional emails from Kodlama.io : ON");

                userMailPerm = user.UserSettings["MailPerm"];
            }
            if (user.UserSettings["MailPerm"] == 001)
            {

                Console.WriteLine("Email me when someone responds to my comments: OFF" +
                                  "\nEmail me when someone comments on a discussion I've commented in: OFF" +
                                  "\nReceive instructional and promotional emails from Kodlama.io : ON");

                userMailPerm = user.UserSettings["MailPerm"];
            }
        }

        public string GetUserMail(User user)
        {
            return user.Mail;   
        }

        public void SendMail()
        {
            string userMailAddress = GetUserMail(user);
            //MailService(userMailAddress);

            Console.WriteLine(revievedServiceText + "Mail Sended to " + userMailAddress);
        }
    }
}
