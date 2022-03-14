namespace Assignment
{
    class Day_5_Assignment
    {
        public double HEAD;
        public double TAIL;
        public int HEAD_COUNT = 0;
        public int TAIL_COUNT = 0;
        public int FLIP_COIN;
        public int FLIP_COUNT;
        public double HEAD_VALUE;
        public double TAIL_VALUE;
        public void Head_tail()
        {
            Console.WriteLine("1) How many time you want to flip the coin :");
            FLIP_COIN = int.Parse(Console.ReadLine());
            while (FLIP_COIN != FLIP_COUNT && FLIP_COIN != FLIP_COUNT)
            {
                Random rand = new Random();
                var RESULT = rand.NextDouble();
                Console.WriteLine("result : " + RESULT);
                if (RESULT < 0.5)
                {
                    Console.WriteLine("Tail.. ");
                    TAIL_COUNT++;
                    TAIL_VALUE = (TAIL_VALUE + RESULT);
                }
                else
                {
                    Console.WriteLine("Head.. ");
                    HEAD_COUNT++;
                    HEAD_VALUE = (HEAD_VALUE + RESULT);
                }
                FLIP_COUNT++;
            }
            HEAD = ((HEAD_VALUE / HEAD_COUNT) * 100);
            TAIL = ((TAIL_VALUE / TAIL_COUNT) * 100);
            Console.WriteLine("Persentage of head : " + HEAD);
            Console.WriteLine(HEAD_COUNT);
            Console.WriteLine("persentage of tail : " + TAIL);
            Console.WriteLine(TAIL_COUNT);
        }
        public void Leap_year()
        {
            Console.WriteLine("\n 2) Enter the year");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 == 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not leap year", year);
            }
        }
        public void Power_2()
        {
            int baseNumber = 2;
            int powerNumber;
            int i = 1;
            Console.Write("\n 3) Enter power number :");
            powerNumber = int.Parse(Console.ReadLine());
            while (i <= powerNumber)
            {
                var returnNumber = Math.Pow(baseNumber, i);
                Console.Write("{0}^{1}={2}\n", baseNumber, i, returnNumber);
                i++;
            }
        }
        public void Harmonic_number()
        {
            int i, n;
            Console.WriteLine("\n 4)Enter the Nth value : ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(" 1/{0} +", i);
            }
        }
        public void Factorial()
        {
            int user_enter;
            int factorial = 1;
            Console.WriteLine("\n 5) Enter the Factorial value : ");
            user_enter = int.Parse(Console.ReadLine());
            for (int i = user_enter; i > 1; i--)
            {
                factorial = i * factorial;
            }
            Console.WriteLine("factorial value : " + factorial);
        }
        public void Quotient_remainder()
        {
            int DIVIDENT;
            int DIVISOR;
            int REMAINDER;
            int QUOTIENT;
            Console.WriteLine("\n 6)Enter the divident :");
            DIVIDENT = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor :");
            DIVISOR = int.Parse(Console.ReadLine());
            QUOTIENT = DIVIDENT / DIVISOR;
            REMAINDER = DIVIDENT % DIVISOR;
            Console.WriteLine("Quotient value : " + QUOTIENT);
            Console.WriteLine("Remainder value : " + REMAINDER);
        }
        public void Swap_number()
        {
            int a;
            int b;
            Console.WriteLine("\n 7) Enter the Swap program A value = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the Swap program B value = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swap a={0} b={1}", a, b);
            a = (a * b);
            b = (a / b);
            a = (a / b);
            Console.WriteLine("After swap a={0} b={1}", a, b);
        }
        class Display
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("1.Head and Tail");
                Console.WriteLine("2.Leap year");
                Console.WriteLine("3.Power of 2");
                Console.WriteLine("4.Harmonic number");
                Console.WriteLine("5.Factorial");
                Console.WriteLine("6.Quotient and Remainder");
                Console.WriteLine("7.Swap two number");
                int USE_NUMBER;
                Console.WriteLine("Enter youer choice :");
                USE_NUMBER = int.Parse(Console.ReadLine());
                Day_5_Assignment program = new Day_5_Assignment();
                switch (USE_NUMBER)
                {
                    case 1:
                        program.Head_tail();
                        break;
                    case 2:
                        program.Leap_year();
                        break;
                    case 3:
                        program.Power_2();
                        break;
                    case 4:
                        program.Harmonic_number();
                        break;
                    case 5:
                        program.Factorial();
                        break;
                    case 6:
                        program.Quotient_remainder();
                        break;
                    case 7:
                        program.Swap_number();
                        break;

                    default:
                        Console.WriteLine("INVALID INPUT....");
                        break;
                }
            }
        }
    }
}