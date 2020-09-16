using System;

namespace DelLab03
{
    class Program
    {
        public delegate void PrintPresDel(President p);
        public delegate string GetPresDel();

        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Lab 03");
            President first = new President
            {
                FirstName = "George",
                LastName = "Washington",
                State = "Virginia",
                Party = "none",
                Year = 1788
            };
            Console.WriteLine("========= three different ways =========");
            first.PrintFirstName(first);
            Console.WriteLine(first.GetFirstName());
            Console.WriteLine(first.FirstName);
            Console.WriteLine(first.FirstName.GetType());

            Console.WriteLine("=========non delegate demostration =========");
            Console.WriteLine(first.FirstName);
            Console.WriteLine(first.LastName);
            Console.WriteLine(first.State);
            Console.WriteLine(first.Party);
            Console.WriteLine(first.Year);
            Console.WriteLine(first.ToString());

            Console.WriteLine("=========first delegate demostration =========");
            GetPresDel myFirstDel = new GetPresDel(first.GetFirstName);
            Console.WriteLine(myFirstDel());
            myFirstDel = first.GetLastName;
            Console.WriteLine(myFirstDel());
            myFirstDel = first.GetState;
            Console.WriteLine(myFirstDel());
            myFirstDel = first.GetParty;
            Console.WriteLine(myFirstDel());
            myFirstDel = first.GetYear;
            Console.WriteLine(myFirstDel());
            myFirstDel = first.ToString;
            Console.WriteLine(myFirstDel());

            Console.WriteLine("=========second delegate demostration =========");
            PrintPresDel mySecondDel = new PrintPresDel(first.PrintFirstName);
            mySecondDel(first);
            mySecondDel = new PrintPresDel(first.PrintLastName);
            mySecondDel(first);
            mySecondDel = new PrintPresDel(first.PrintState);
            mySecondDel(first);
            mySecondDel = new PrintPresDel(first.PrintParty);
            mySecondDel(first);
            mySecondDel = new PrintPresDel(first.PrintYear);
            mySecondDel(first);
            mySecondDel = new PrintPresDel(first.PrintString);
            mySecondDel(first);
        }
    }
    public class President
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
        public string Party { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} from {State} was a {Party} elected in {Year}.";
        }

        //Get takes no arguments ahd returns a string
        public string GetFirstName() => FirstName;
        public string GetLastName() => LastName;
        public string GetState() => State;
        public string GetParty() => Party;
        public string GetYear() => Year.ToString();

        //print takes a President argument and returns void
        public void PrintFirstName(President p) => Console.WriteLine(p.FirstName);
        public void PrintLastName(President p) => Console.WriteLine(p.LastName);
        public void PrintState(President p) => Console.WriteLine(p.State);
        public void PrintParty(President p) => Console.WriteLine(p.Party);
        public void PrintYear(President p) => Console.WriteLine(p.Year.ToString());

        public void PrintString(President p) =>
            Console.WriteLine($"{FirstName} {LastName} from {State} was a {Party} elected in {Year}.");
    }
}
