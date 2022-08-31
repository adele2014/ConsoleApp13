using System;

namespace ConsoleApp13
{
    internal class AirConditioner
    {
        static void Main(string[] args)  //method
        {
            Console.WriteLine("Blowing cool air");
            #region EatingReference

            //int calories = Eating("pasta");
            //Console.WriteLine($"We get {calories} from the food "); 
            #endregion

            Worrying();

        }

        private int vend;  //field
        public string Condenser { get; set; } // property

        public delegate int AddNumbers(int a, int b); // delegate

        public AirConditioner(string compressor)  //constructor
        {

        }

        ~AirConditioner()  //destructor
        {
            Console.WriteLine("Clear the water away");

        }

        int Calculator(int firstNumber, int secondNumber) //method/function
        {
            return firstNumber + secondNumber;
        }

        static int Eating(string food)
        {
            if (food == "rice")
            {
                return 500;
            }
            else if (food == "fufu")
            {
                return 300;
            }
            else
            {
                return 100;
            }


        }  // method

        string CommonNames()
        {
            return "Peace";
        } 

        static void Worrying()
        {
            #region WhileLoop
            //int amountSofar = 1;
            //  while (amountSofar < 10000)
            //  {
            //      Console.WriteLine($"Advertise for more sales, we are at {amountSofar} naira");
            //      amountSofar = amountSofar * 2;
            //  } 
            #endregion

            #region UsingOfForLoop
            //int total = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    total = total + i;
            //    Console.WriteLine($"Hello I am {total} for now");

            //} 
            #endregion

         
            
            
            
            
            
            
            
            
            
            
            
            
            #region foreachLoop
            int[] apcFans = { 23, 17, 21, 31, 27, 18 };  //array

            int total = 0;
            foreach (var youthAge in apcFans)
            {
               // total = total + youthAge;
                total += youthAge;
                //Console.WriteLine($"Age {youth} is an APC fan age");

                for (int i = 0; i < UPPER; i++)
                {
                    
                }
            }

            decimal average = total / apcFans.Length;
            Console.WriteLine($"the average age of apc fans is {average}");
            #endregion

        }

    }
}
