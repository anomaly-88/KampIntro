using OdevHafta5GameProject.ENTITY;
using OdevHafta5GameProject.SERVICE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHafta5GameProject.MANAGER
{
    class UserValidationManager : IUserValidationService
    {

        //MERNIS Validation Simulation
        public bool Validate(Gamer gamer)
        {
            //MERNIS
            string ChkIdentityNumber = "12345";
            string ChkFirstName = "So";
            string ChkLastName = "Infinity";
            int ChkBithYear = 1990;
            //

            if (gamer.IdentityNumber == ChkIdentityNumber && gamer.FirstName == ChkFirstName && gamer.LastName == ChkLastName && gamer.BirthYear == ChkBithYear)
            {
                return true;
            }

            return false;
        }
    }
}
