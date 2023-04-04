using System.Reflection.Metadata.Ecma335;
Console.WriteLine("Kas soovid temperatuuri Celsiuses või Fahrenheitis? (C/F)");
char TempIn = Char.Parse(Console.ReadLine());
switch (TempIn)
{
    case 'C':
    case 'c':
        {
            Console.WriteLine("Teisenda Fahrenheit (F) Celsiuseks (C)");
            Console.WriteLine("Mitu Fahrenheiti soovid Celsiuseks teisendada?");
            int userNumC = Int32.Parse(Console.ReadLine());
            ConvertToC(userNumC);
            static void ConvertToC(double TempF)
            {
                Console.WriteLine($"{TempF} F on {(TempF - 32) * 5 / 9} C");
            }
            break;
        }
    case 'F':
    case 'f':
        {
            Console.WriteLine("Teisenda Celsius (C) Fahrenheitideks (F)");
            Console.WriteLine("Mitu Celsiust soovid Fahrenheitideks teisendada?");
            int userNumF = Int32.Parse(Console.ReadLine());
            ConvertToF(userNumF);
            static void ConvertToF(double TempC)
            {
                Console.WriteLine($"{TempC} C on {(TempC * 9 / 5 + 32)} F");
            }
            break;
        }
    default:
        {
            Console.WriteLine("invalid");
            break;
        }
}