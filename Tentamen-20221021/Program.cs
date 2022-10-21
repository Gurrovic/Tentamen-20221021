namespace Tentamen_20221021
{
    internal class Program
    {
        //Uppgift 6

        public class Species
        {
            public string namn;
            public string släkte;
            public string art;
            public string utbredning;

            public Species (string namn, string släkte, string art, string utbredning)
            {
                this.namn = namn;
                this.släkte = släkte;
                this.art = art;
                this.utbredning = utbredning;
            }

            public void Print()
            {
                Console.WriteLine($"Namn: {namn}");
                Console.WriteLine($"Släkte: {släkte}");
                Console.WriteLine($"Art: {art}");
                Console.WriteLine($"Utbredning: {utbredning}\n");
            }            
        }
                
        //Uppgift 2        
        static double InvSqr(double X)
        {
            return 1 / (X * X);
        }

        //Uppgift 5
        static double InverseSum (int m, int n)
        {
            double summa = 0;
            for (double i = m; i <= n; i++)
            {
                summa += (1 / i);                
            }
            return summa;
        }
        
        static void Main(string[] args)
        {
            //Uppgift 1

            Console.WriteLine("Tryck Enter för att starta uppgift 1");
            Console.ReadLine();
            Console.Clear();

            double ljushastighet = 299792.458;
            double solenmedelavståndkm = 149598023;
            double sekunderperminut = 60.0;

            double tidIMinuterFörLjusetAttGåFrånSolenTillJorden = solenmedelavståndkm / ljushastighet / sekunderperminut;
                        
            Console.WriteLine($"Tid i minuter för ljuset att gå från solen till jorden: {tidIMinuterFörLjusetAttGåFrånSolenTillJorden}");

            Console.WriteLine("\nTryck Enter för att starta uppgift 2");
            Console.ReadLine();
            Console.Clear();
                      

            //Uppgift 2

            Console.WriteLine(InvSqr(0.25));
            Console.WriteLine(InvSqr(0.1111111));
            Console.WriteLine(InvSqr(0.0625));
            Console.WriteLine(InvSqr(0.04));


            Console.WriteLine("\nTryck Enter för att starta uppgift 3");
            Console.ReadLine();
            Console.Clear();


            //Uppgift 3

            Console.WriteLine("Välj ett första tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Välj ett andra tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());


            int summa = 0;
            for (int i = tal1; i <= tal2; i++)
            {
                if (i % 2 == 0)
                {
                    summa += i;
                }
            }
            Console.WriteLine(summa);

            Console.WriteLine("\nTryck Enter för att starta uppgift 4");
            Console.ReadLine();
            Console.Clear();


            //Uppgift 4

            int[] array = new int[10];
            {
                for (int i = 0; i < array.Length; i++) { array[i] = i + 1; }

                int j = array[0];
                for (int x = 0; x < array.Length - 1; x++)
                {
                    array[x] = array[x + 1];
                }
                array[array.Length - 1] = j;

            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nTryck Enter för att starta uppgift 5");
            Console.ReadLine();
            Console.Clear();

            //Uppgift 5

            Console.WriteLine("Mata in tal 1: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mata in tal 2: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(InverseSum(m, n));

            Console.WriteLine("\nTryck Enter för att starta uppgift 6");
            Console.ReadLine();
            Console.Clear();

            //Uppgift 6

            Species Vildhäst = new Species("Vildhäst", "Equus", "Ferus", "Mongoliet");
            Species Bergszebra = new Species("Bergszebra", "Equus", "Zebra", "Namibia och Sydafrika");
            Species Stäppzebra = new Species("Stäppzebra", "Equus", "Quagga", "Afrika");
            Species Afrikansk_vildåsna = new Species("Afrikansk vildåsna", "Equus", "Africanus", "Egypten, Sudan, Eritrea och Etiopien");
                      

            //Vildhäst.Print();
            //Bergszebra.Print();
            //Stäppzebra.Print();
            //Afrikansk_vildåsna.Print();


            //BONUS

            Species[] djur = new Species[] { Vildhäst, Bergszebra, Stäppzebra, Afrikansk_vildåsna };

            foreach (Species d in djur)
            {
                d.Print();
            }

            Console.WriteLine("\nTACK FÖR ATT DU GICK IGENOM MIN TENTA! ADJÖ! TRYCK ENTER FÖR ATT AVSLUTA");

            Console.ReadLine();
        }
    }
}