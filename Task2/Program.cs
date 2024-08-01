using System.Runtime.CompilerServices;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NumberReader number = new NumberReader();
            while (true)
            {
                try
                {
                    number.Read();
                }
                catch (Exception)
                { Console.WriteLine("Вы ввели неверное значение, пожалуйста, введите 1 или 2"); }
                //123
            }
        }

        class NumberReader
        {
            List<string> sonames = new List<string>()
            {
                "Azujon",
                "Ibragim",
                "Michael",
                "Andy",
                "Sandy",
                "Koko",
                "Loli",
                "Strelka",
                "Sergey",
                "Vladislav",
                "Natali"
            };
            public delegate void NumberEnteredDelegate(int value);
            public event NumberEnteredDelegate NumberEnteredEvent;

            public void Read()
            {
                Console.WriteLine("");
                Console.WriteLine("Введите число 1 или 2");
                int value = int.Parse(Console.ReadLine());
                if (value != 1 && value != 2) { throw new Exception(); }
                NumberEntered(value);
                ShowList(value,sonames);

            }

            protected virtual void NumberEntered(int value)
            {
                NumberEnteredEvent?.Invoke(value);
            }

            static void ShowList(int number, List<string> sonames)
            {
                switch (number)
                {
                    case 1:  SortAsc(sonames); break;
                    case 2:  SortDesc(sonames); break;
                }
            }



            static void SortAsc(List<string> sonames)
            {

                sonames.Sort();
                foreach (string soname in sonames)
                {
                    Console.WriteLine(soname);
                }
                Console.WriteLine("");
            }

            static void SortDesc(List<string> sonames)
            {
                sonames.Reverse();
                foreach (string soname in sonames)
                {
                    Console.WriteLine(soname);
                }
                Console.WriteLine("");
            }

        }
    }
}
