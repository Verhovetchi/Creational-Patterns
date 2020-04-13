using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
     abstract class Player
     {
          public abstract void Show();
     }
     class Goalkeeper : Player
     {
          public override void Show()
          {
               Console.WriteLine("Goalkeeper");
          }
     }
     class Defender : Player
     {
          public override void Show()
          {
               Console.WriteLine("Defender");
          }
     }
     class Midfielder : Player
     {
          public override void Show()
          {
               Console.WriteLine("Midfielder");
          }
     }
     class Forward : Player
     {
          public override void Show()
          {
               Console.WriteLine("Forward");
          }
     }
}
