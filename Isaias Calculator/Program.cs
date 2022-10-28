
using System.Globalization;

namespace isaiascalc;
class Program
{
    static void Main(string[] args)
    {

        double firstnum = 0;
        double secondnum = 0;
        double result = 0;
        List<double> resultathistoria = new List<double>();

        while (true)
        {
            Console.WriteLine("Välkommen ;)");

            Console.WriteLine("Första Numret");
            firstnum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Välj räknesätt | (  +  ),(  -  ), (  /  ), (  *  )");
            string räknesätt = Console.ReadLine();

            Console.WriteLine("Andra numret");
            secondnum = Convert.ToDouble(Console.ReadLine());


            switch (räknesätt)
            {
                case "+":
                    result = firstnum + secondnum;
                    Console.WriteLine(" = " + result);
                    break;

                case "-":
                    result = firstnum - secondnum;
                    Console.WriteLine(" = " + result);
                    break;

                case "/":
                    if (secondnum == 0)
                    {
                        Console.WriteLine("ogiltlig inmatning!");
                        break;
                    }
                    result = firstnum / secondnum;
                    Console.WriteLine(" = " + result);
                    break;


                case "*":
                    result = firstnum * secondnum;
                    Console.WriteLine(" = " + result);
                    break;

                default:

                    Console.WriteLine("Det du skrev är inte ett av det listade räknesätten :(");
                    break;
            }
            resultathistoria.Add(result);

            Console.WriteLine("Vill du se tidigare resultat? Ja = J eller Nej = N ");
            char setidigareres = Console.ReadLine()[0];

            if (setidigareres == 'J' || setidigareres == 'j')
            {
                Console.WriteLine("Dina tidigare uträckningar! :");
                foreach (double a in resultathistoria) { Console.WriteLine(a); }
            }

            else if (setidigareres == 'N' || setidigareres == 'n')
            {
                Console.WriteLine("");
            }

            Console.WriteLine("Fortsätta räkna? Ja = J Nej = N");
            char fortsätt = Console.ReadLine()[0];
            if (fortsätt == 'J' || fortsätt == 'j')
            {
                Console.WriteLine("");
            }
            else if (fortsätt == 'N' || fortsätt == 'n')
            {
                break;
            }

            Console.ReadKey();
        }

    }
}
