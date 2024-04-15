namespace classwork16
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Test test = new Test();
            test[0] = 1;
            test[1] = 12;
            test[2] = 123;
            test[3] = 1234;
            test[4] = 12345;
            test[5] = 54321;
            test[6] = 4321;
            test[7] = 321;
            test[8] = 21;
            test[9] = 2;


            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            foreach(var item in typeof(Test).GetProperties())
                Console.WriteLine(item);
            

        }
    }
    class Test
    {
        public int[] arr { get; }
        public int Length => arr.Length;
        public int this[int i]
        {
            get { return arr[i]; }
            set 
            {
                if (value<0) 
                {
                    throw new ArgumentException("0dan kicik ola bilmez");
                }
                if (i>=arr.Length)
                {
                    throw new IndexOutOfRangeException("arrayin uznlugu uygun deyil");
                }
                arr[i] = value;
               
            }
        }
        public Test()
        {
            arr = new int[10];
        }
    }

}