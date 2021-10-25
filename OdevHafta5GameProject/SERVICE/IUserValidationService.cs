using OdevHafta5GameProject.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.SERVICE
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
