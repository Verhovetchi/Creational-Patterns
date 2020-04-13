using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_1
{
     sealed class Club
     {
          private static Club club = null;
          private string name;
          
          private Club(string name)
          {
               this.name = name;
          }

          public static Club Initialize(string name)
          {
               if (club == null)
                    club = new Club(name);

               return club;
          }

          public void Show()
          {
               Console.WriteLine(name);
          }

     }

}
