using System;

namespace EventsLabStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("At a lonely outpost in far off mountains...\n");

            Attacker a = new Attacker();
            a.Attack("snipers");

            Defender d = new Defender();
            d.ReturnFire("rifle fire");

            a.Attack("full auto rifle fire");
            d.ReturnFire("squad automatic weapon");

            string attackType = "heavy machine guns";
            a.Attack(attackType);
            d.CallForHelp(attackType);

            attackType = "moms bringing reinforcements in trucks";
            a.Attack(attackType);
            d.CallForHelp(attackType);

            attackType = "armored vehicles";
            a.Attack(attackType);
            d.CallForHelp(attackType);

            attackType = "SCUD missles";
            a.Attack(attackType);
            d.CallForHelp(attackType);
        }
    }

    class Attacker
    {
        public void Attack(string s)
        {
            Console.WriteLine($"A. Enemy attacks with {s}");
        }
    }

    public class Defender
    {
        public void ReturnFire(string s)
        {
            Console.WriteLine($"D. Defender responds with {s}\n");
        }

        public void CallForHelp(string weapon)
        {
            Console.WriteLine($"D. Help, we are under attack by {weapon}");

            if (weapon == "heavy machine guns")
                Responder.MaDeuce(weapon);
            if (weapon == "moms bringing reinforcements in trucks")
                Responder.Predator(weapon);
            if (weapon == "armored vehicles")
                Responder.WartHog(weapon);
            if (weapon == "SCUD missles")
                Responder.BUFF(weapon);
        }
    }

    public class Responder
    {
        public static void MaDeuce(string w)
        {
            Console.WriteLine($"Ma Deuce: 50 Cal opens up and smokes the Sons of Witches shooting {w}. Rat..tat...tat...\n");
        }
        public static void Predator(string w)
        {
            Console.WriteLine($"Predator: We just hellfired those mother trucking {w}. kaBOOM\n");
        }
        public static void WartHog(string w)
        {
            Console.WriteLine($"Wart Hog: We just shot the shift out of the {w} with our Gatling Gun. Zzzzzzip\n");
        }
        public static void BUFF(string w)
        {
            Console.WriteLine($"BUFF: The Big Ugly Fat Fuggers just obliterated the {w}. SHOCK AND AWE!!!\n");
        }
    }
}
