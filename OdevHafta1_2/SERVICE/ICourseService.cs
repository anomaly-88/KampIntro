using OdevHafta1_2.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta1_2.SERVICE
{
    interface ICourseService
    {
        void GetCourseByID(User user, List<Course> courses);
        void EnrollTheCourse(User user, Course course);
    }
}
