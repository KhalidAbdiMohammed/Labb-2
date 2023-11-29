namespace Labb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fråga användaren hur många familjemedlemmar det finns
            Console.WriteLine("Hur många består din familj utav?");
            int Bigfamily = Convert.ToInt32(Console.ReadLine());

            int menuSelector = 0;
            int userinput = 0;
            string[] names = new string[Bigfamily];
            double[] age = new double[Bigfamily];
            double totalage = 0;
            double averageAge = 0;

            //vi bildar en while-loop
            while (menuSelector != 5)  

            {
                Console.WriteLine(

                    // Vi skriver ut en menyalternativen för användaren
                    "\n------------------------------------------------------------------" +
                    "\nVälj ett av alternativen: " +
                    "\n1.) Lägg till namn på familjemedlemmar samt ålder" +
                    "\n2.) Visa familjemedlemmarna samt deras ålder" +
                    "\n3.) Skriv ut summan av familjemedlemmars ålder" +
                    "\n4.) Skriv ut medelåldern för familjemedelmarna" +
                    "\n5.) Avsluta" +
                    "\n------------------------------------------------------------------"
                    );


                menuSelector = int.Parse(Console.ReadLine());

                // Hantera användarens val med en switch-sats
                switch (menuSelector)

                {
                    case 1:

                        if (userinput < Bigfamily)
                        {
                            Console.WriteLine("Skriv namnet på en familjmedlem");
                            names[userinput] = Console.ReadLine();


                            Console.WriteLine("Skriv åldern på familjmedlem");
                            age[userinput] = double.Parse(Console.ReadLine());
                            userinput++;

                        }
                        else
                        {
                            // Använder console clear så att den raderar allt previous commands
                            Console.Clear(); 
                            Console.WriteLine("Tyvärr det fullt");
                        }
                       break;

                    case 2:
                        {
                            if (userinput == 0);
                            Console.Clear();
                            Console.WriteLine("Du måste namnge någon familjemedlem");
                        }
                        for (int i = 0; i < userinput; i++)
                        {
                            Console.WriteLine(names[i] + " är " + age [i] + " år gammal");
                        }
                        break;

                    case 3:

                        // Beräkna och skriv ut totalåldern för familjen
                        for (int i = 0; i < userinput; i++)
                        {
                            totalage += age[i];
                        }
                        Console.WriteLine("Sammanlagda åldern är " + totalage.ToString("0.00"));
                        
                        break;

                    case 4:
                        averageAge = 0;

                        for (int i = 0; i < userinput; i++)
                        {
                            averageAge+= age[i];
                        }
                        averageAge = averageAge / userinput;
                        Console.WriteLine("Medelåldern är " + averageAge.ToString("0.00"));

                        break;
                    case 5:
                        Console.WriteLine("Tack för din tid!");
                        break;

                    default:
                        Console.WriteLine("Du behöver ange ett nummer mellan 1 - 5");
                        break;
                     }
                
                }
            }
        }
    }
