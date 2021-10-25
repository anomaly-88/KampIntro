using OdevHaftaBes.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevHaftaBes.SERVICE
{
    class VerifyGamerService
    {
        public void Verify(Gamer gamer)
        {

            // E-devlet service
            // if gamer.cn , E-Devlet service ile eşleşiyorsa;
            bool check = true;
            
            
            if(check)
            {
                Console.WriteLine("E-Devlet Onayı !");
            }else if (!check)
            {
                Console.WriteLine("E-Devlet Reddi.");
            }
            else { Console.WriteLine("Bağlantı Problemi."); }

        }
    }
}
