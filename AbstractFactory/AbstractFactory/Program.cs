using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static AbstractHero NewHero()
        {
            Console.WriteLine("Enter the type of your hero: (1, 2, 3): ");
            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    return new AbstractHero(new FactoryType1());
                case 2:
                    return new AbstractHero(new FactoryType2());
                case 3:
                    return new AbstractHero(new FactoryType3());
                default:
                    return null;
            }
        }

        static void Use(AbstractHero h1, AbstractHero h2)
        {
            SaverSingleton saverSingleton;
            saverSingleton = SaverSingleton.GetInstance(1);

            int choice1, choice2;
            Console.WriteLine("Select action for first hero: ");
            Console.WriteLine("Hit: 1");
            Console.WriteLine("Magic: 2");
            Console.WriteLine("Special skill: 3");
            choice1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Select action for second hero: ");
            Console.WriteLine("Hit: 1");
            Console.WriteLine("Magic: 2");
            Console.WriteLine("Special skill: 3");
            choice2 = int.Parse(Console.ReadLine());

            try
            {
                switch (choice1)
                {
                    case 1:
                        h1.Hit.UseHit(h2);
                        break;
                    case 2:
                        h1.Magic.UseMagic(h2);
                        if (h1.Magic is MagicType1)
                            return;
                        break;
                    case 3:
                        h1.SpecialSkill.UsePsecialSkill();
                        if (h1.SpecialSkill is SpecialSkillType1)
                            return;
                        h1.Hit.UseHit(h2);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine("Second hero win");
                Console.ReadKey();
                saverSingleton.SaveLog("Second win");
                Environment.Exit(0);
            }
            

            try
            {
                switch (choice2)
                {
                    case 1:
                        h2.Hit.UseHit(h1);
                        break;
                    case 2:
                        h2.Magic.UseMagic(h1);
                        if (h2.Magic is MagicType1)
                            return;
                        break;
                    case 3:
                        h2.SpecialSkill.UsePsecialSkill();
                        if (h2.SpecialSkill is SpecialSkillType1)
                            return;
                        h2.Hit.UseHit(h1);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine("First hero win");
                Console.ReadKey();
                saverSingleton.SaveLog("First win");
                Environment.Exit(0);
            }
            
        }

        static void Main(string[] args)
        {
            AbstractHero h1, h2;
            h1 = NewHero();
            h2 = NewHero();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hero 1: ");
                Console.WriteLine(h1.ToString());
                Console.WriteLine("**********************");
                Console.WriteLine("Hero 2: ");
                Console.WriteLine(h2.ToString());
                Console.WriteLine("**********************");
                Use(h1, h2);
            }

            Console.ReadKey();
        }
    }
}
