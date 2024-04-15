using exeeptionnn.exeption;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace exeeptionnn
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            bool result = true;
            do
            {



                try
                {
                    string name = Console.ReadLine();
                    if (!IsLetter(name))
                    {
                        throw new exeeption();
                    }
                    name = Capitalize(name);
                    result = !IsLetter(name);
                }
                catch (exeeption)
                {
                    Console.WriteLine("sevh data");

                }

            }
            while (result);



        }

        public static string Capitalize(string name)
        { return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower(); }


        public static bool IsLetter(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            
            return true;



        }

    }
}