using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldNewUG
{
    class Program
    {
        public static void dataType()
        {
            Console.WriteLine("Helloworld");
            Console.ReadKey();
            Console.WriteLine("Typy danych C#");
            double a1 = 10.5;
            Console.WriteLine("Wartosc: {0}, Minimalna Liczba:{1}, Maksymalna Liczba: {2}", a1, Double.MinValue, Double.MaxValue);
            Console.ReadKey();
            char a2 = 'U';
            Console.WriteLine("Wartosc: {0}", a2);
            Console.ReadKey();
            decimal a3 = 11.1M;
            Console.WriteLine("Wartosc: {0}, Minimalna Liczba:{1}, Maksymalna Liczba: {2}", a3, Decimal.MinValue, Decimal.MaxValue);

            Console.ReadKey();
            int a4 = 13;
            Console.WriteLine("Wartosc: {0}, Minimalna Liczba:{1}, Maksymalna Liczba: {2}", a4, int.MinValue, int.MaxValue);

            Console.ReadKey();
            string a5 = "14";
            Console.WriteLine("Wartosc: {0}", a5);

            Console.ReadKey();
            long a6 = 11444;
            Console.WriteLine("Wartosc: {0}, Minimalna Liczba:{1}, Maksymalna Liczba: {2}", a6, long.MinValue, long.MaxValue);

            Console.ReadKey();
        }
        public static void nameSurname()
        {
            String name;
            String surname;
            Console.WriteLine("podaj imie");
            name = Console.ReadLine();
            Console.WriteLine("podaj nazwisko");
            surname = Console.ReadLine();
            Console.WriteLine(name + " " + surname);
        }
        public static void convertStringToIn()
        {
            String number1;
            String number2;
            Console.WriteLine("podaj 1 liczbe");
            number1 = Console.ReadLine();
            Console.WriteLine("podaj 2 liczbe");
            number2 = Console.ReadLine();
            Console.WriteLine(int.Parse(number1) + int.Parse(number2));
        }
        public static void loopAndSwitch()
        {
            Console.WriteLine("znak aktywujący");
            String mainMark;
            mainMark = Console.ReadLine();
            //  dataType();
            //   nameSurname();
            //   convertStringToIn();
            while (mainMark != "g")
            {
                String number3;
                String number4;

                Console.WriteLine("podaj 3 liczbe");
                number3 = Console.ReadLine();
                Console.WriteLine("podaj 4 liczbe");
                number4 = Console.ReadLine();
                try
                {
                    Double sumDouble = Double.Parse(number3) + Double.Parse(number4);
                }
                catch (Exception)
                {

                    Console.WriteLine("nie da sie sparsowac");
                    Console.WriteLine();
                }


                String number5;
                String number6;
                Console.WriteLine("podaj 5 liczbe");
                number5 = (Console.ReadLine());
                Console.WriteLine("podaj 6 liczbe");
                number6 = Console.ReadLine();
                String mark;
                Console.WriteLine("podaj znak ");
                mark = Console.ReadLine();
                switch (mark)
                {
                    case "+":
                        Console.WriteLine(int.Parse(number5) + int.Parse(number6));
                        break;
                    case "-":
                        Console.WriteLine(int.Parse(number5) - int.Parse(number6));
                        break;
                    case "*":
                        Console.WriteLine(int.Parse(number5) * int.Parse(number6));
                        break;
                    default:
                        Console.WriteLine("Nie wpisales znaku");
                        break;
                }
                Console.WriteLine("znak aktywujący");
                mainMark = Console.ReadLine();
            }
        }
        public static void printTable(int[] myRandowTable)
        {
            foreach (int el in myRandowTable)
            {
                Console.Write(el + " ");
            }
        }
        public static int[] createTable(String tableLength)
        {

            int[] myRandowTable = new int[int.Parse(tableLength)];

            return myRandowTable;
        }
        public static int[] tableAddingEll(int[] table, String tableMaxValue)
        {
            //tablica

            Random random = new Random();
            for (int i = 0; i < table.Length; i++)
            {

                table[i] = random.Next(int.Parse(tableMaxValue));
            }
            return table;

        }
        public static int[] sortArr(int[] table)
        {
            int numberOfEl = table.Length;
            int temp = 0;
            for (int i = 0; i < numberOfEl; i++)
            {
                for (int sort = 0; sort < numberOfEl - 1; sort++)
                {
                    if (table[sort] > table[sort + 1])
                    {
                        temp = table[sort + 1];

                        table[sort + 1] = table[sort];
                        table[sort] = temp;
                    }
                }
            }
            return table;

        }

        public static int[] insertSort(int[] table)
        {

            for (int i = table.Length - 2; i >= 0; i--)
            {
                int x = table[i];
                int j = i + 1;
                while ((j < table.Length) && (x > table[j]))
                {
                    table[j - 1] = table[j];
                    j++;
                }
                table[j - 1] = x;
            }

            return table;
        }
        public static void listCreator()
        {
            List<int> mylist = new List<int>();
            List<int> mylistWithout2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj liczbę");
                String number = Console.ReadLine();
                mylist.Add(int.Parse(number));

            }
            Console.WriteLine("1 tablica");
            foreach (int el in mylist)
            {
                Console.Write(el);
            }
            foreach (int el in mylist)
            {
                if (el > 2)
                {
                    mylistWithout2.Add(el);

                }
            }
            Console.WriteLine("2 tablica");
            foreach (int el in mylistWithout2)
            {
                Console.Write(el);
            }
        }
        static void Main(string[] args)
        {
            String tableLength;
            String tableMaxValue;

            //  Console.WriteLine("Podaj wielkość tablicy");
            //   tableLength = Console.ReadLine();
            //  Console.WriteLine("Podaj górny limit wartości tablicy");
            // tableMaxValue = Console.ReadLine();

            //  int[] myTable = createTable(tableLength);
            //  myTable = tableAddingEll(myTable, tableMaxValue);
            //  printTable(myTable);
            // sortowanie
            //  Console.WriteLine("Posortowana tablica");
            //  printTable(sortArr(myTable));

            // int []mySortTable = sortArr(myTable);

            // int[] mySecontTable = createTable(tableLength);
            // mySecontTable = tableAddingEll(mySecontTable, tableMaxValue);
            // int[] myInsertSort = insertSort(mySecontTable);
            // Console.WriteLine("Sortowanie bąbelkowe");
            // printTable(mySortTable);
            // Console.WriteLine("Sortowanie przez wstawianie");
            // printTable(myInsertSort);
            //    listCreator();
            Animal dog = new Animal("Burek", 5, "kundel");
            //String name = "Burek";
            //dog.name = "lola";
            //dog.age = 5;
            //dog.species = "jamnik";
            //int age = 5;
            //String rasa = "kundel";
            Animal animalek = new Animal("burek", 5, "animalek");
            Console.WriteLine(animalek);
            Dog brutus = new Dog("Brutus", 5);
            Console.WriteLine(brutus);


            //Console.WriteLine("Mam na imie " + dog.name + " jestem rasy " + dog.species + " mam lat " + dog.age);
           // brutus.move();
            Fish rybka = new Fish("Zlota", 2);
            Console.WriteLine(rybka);
        }
    }

    class Animal
    {
        private String name;
        private int age;
        private String species;

        public virtual void move()
        {
            Console.WriteLine("I am moving");
        }

        public Animal(String name, int age, String species)
        {
            this.name = name;
            this.age = age;
            this.species = species;
        }

        public override string ToString()
        {
            return "jestem " + species + " mam na imie " + name + " i mam " + age + " lat";
        }
    }

    class Dog : Animal
    {
        public Dog(String name, int age)
            : base(name, age, "dog")
        { }

        public override void move()
        {
            Console.WriteLine("I am dog and I run");
        }
    }
    class Fish : Animal
    {
        public Fish(String name, int age)
            :base(name, age,"fish")
        { }
        public override void move()
        {
            Console.WriteLine("I am fish and I swim");
        }

    }
}

