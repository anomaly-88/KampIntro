using OdevHafta1_2.ENTITY;
using OdevHafta1_2.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta1_2.MANAGERS
{
    class CourseManager : ICourseService
    {
        public void GetCourseByID(User user, List<Course> courses)
        {
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseID);
                foreach (var uCourseID in user.Courses) { Console.WriteLine(uCourseID); 
            
            if(course.CourseID == uCourseID)
                    {
                        Console.WriteLine(user.UserName+"Courses: "+course.Name);
                    }
        }
        }
        }
        public void EnrollTheCourse(User user, Course course)
        {
            user.Courses.Add(course.CourseID);
            Console.WriteLine(course.Name + " Enrolled."); 
        }
    }
}
