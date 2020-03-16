# Event Lab
## Charles Carter
## March 16, 2020

1. Open the source code for *EventLabStarter* in Visual Studio and examine the code. The file contains four classes: Program, Attacker, Defender, and Responder.

1. In the Event class, declare an event handler to handle attack events.

        public class Defender
        {
            //1. declare event handler
            public event EventHandler<string> UnderAttackEvent;

1. In the Event class, create a method to raise the attack event.

        public class Defender
        {
            ...
            //2. create get help method
            private void RaiseGetHelp(string weapon)
            {
                UnderAttackEvent?.Invoke(this, weapon);
            }

1. in the *CallForHelp(string weapon)* method, call *RaiseGetHelp(weapon)*.

        public void CallForHelp(string weapon)
        {
            Console.WriteLine($"D. Help, we are under attack by {weapon}");
            //3. create call help method
            RaiseGetHelp(weapon);
            //4.   comment out the remainder of the method, it will be raised by the event
        //    if (v == "heavy machine guns")
        //        Responder.MaDeuce();
        //    if (v == "moms bringing reinforcements in trucks")
        //        Responder.Predator();
        //    if (v == "armored vehicles")
        //        Responder.WartHog();
        //    if (v == "SCUD missles")
        //        Responder.BUFF();
        }

1. In the Responder class, add method *HelpDefender()*

        //5. add helper method 
        public static void HelpDefender(object sender, string weapon)
        {
            if (weapon == "heavy machine guns")
                MaDeuce(weapon);
            else if (weapon == "moms bringing reinforcements in trucks")
                Predator(weapon);
            else if (weapon == "armored vehicles")
                WartHog(weapon);
            else if (weapon == "SCUD missles")
                BUFF(weapon);
        }

1. Change the support methods (*MaDeuce*, *BUFF*, etc.) to private.

        //6. change public methods to private
        private static void MaDeuce(string w)
        {
            Console.WriteLine($"Ma Deuce: 50 Cal opens up and smokes the Sons of Witches shooting {w}. Rat..tat...tat...\n");
        }
        private static void Predator(string w)
        {
            Console.WriteLine($"Predator: We just hellfired those mother trucking {w}. kaBOOM\n");
        }
        private static void WartHog(string w)
        {
            Console.WriteLine($"Wart Hog: We just shot the shift out of the {w} with our Gatling Gun. Zzzzzzip\n");
        }
        private static void BUFF(string w)
        {
            Console.WriteLine($"BUFF: The Big Ugly Fat Fuggers just obliterated the {w}\n");
        }

1. In the Program class, subscribe to the attack event.

            a.Attack("full auto rifle fire");
            d.ReturnFire("grenade launcher");

            //7. subscribe to UnderAttackEvent
            d.UnderAttackEvent += Responder.HelpDefender;
            string attackType = "heavy machine guns";
            a.Attack(attackType);
            d.CallForHelp(attackType);

1. Compile and run the example.
