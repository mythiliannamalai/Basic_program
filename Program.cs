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
        class Display
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("1.Head and Tail");
                Console.WriteLine("2.Leap year");
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
                    default:
                        Console.WriteLine("INVALID INPUT....");
                        break;
                }
            }
        }
    }
}