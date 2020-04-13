using System;
using Factory;

namespace DoFactory.GangOfFour.Factory.Structural
{
     class MainApp
     {
          static void Main()
          {
               string s = Console.ReadLine();
               int n = Convert.ToInt32(s);
               Create(new PositionCreator[n]);

               Console.ReadKey();
          }

          static void Create(PositionCreator[] creator)
          {
               Random random = new Random();
               int rand = random.Next(1, 3);
               int count = creator.Length;
               Player product;
               for (int i = 0; i < count; i++)
               {
                    rand = random.Next(1, 5);
                    switch (rand)
                    {
                         case 1:
                              creator[i] = new GoalkeeperCreator();
                              product = creator[i].FactoryMethod();
                              product.Show();
                              break;
                         case 2:
                              creator[i] = new DefenderCreator();
                              product = creator[i].FactoryMethod();
                              product.Show();
                              break;
                         case 3:
                              creator[i] = new MidfielderCreator();
                              product = creator[i].FactoryMethod();
                              product.Show();
                              break;
                         case 4:
                              creator[i] = new ForwardCreator();
                              product = creator[i].FactoryMethod();
                              product.Show();
                              break;
                    }
               }

          }
     }
     abstract class PositionCreator
     {
          public abstract Player FactoryMethod();
     }
     class GoalkeeperCreator : PositionCreator
     {
          public override Player FactoryMethod()
          {
               return new Goalkeeper();
          }
     }
     class DefenderCreator : PositionCreator
     {
          public override Player FactoryMethod()
          {
               return new Defender();
          }
     }
     class MidfielderCreator : PositionCreator
     {
          public override Player FactoryMethod()
          {
               return new Midfielder();
          }
     }
     class ForwardCreator : PositionCreator
     {
          public override Player FactoryMethod()
          {
               return new Forward();
          }
     }
}