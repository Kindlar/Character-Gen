namespace PlayerStatisics
{
    using System;

    public class DiceRoll
    {
        private static Random Number()
        {
            int seed = Guid.NewGuid().GetHashCode();
            Random r = new Random(seed);
            return r;
        }

        public int D4()
        {
            int randomNumber = Number().Next(1, 5);
            return randomNumber;
        }
        public int D6()
        {

            int randomNumber = Number().Next(1, 7);
            return randomNumber;
        }

        public int D8()
        {
            int randomNumber = Number().Next(1, 9);
            return randomNumber;  
        }

        public int D10()
        {
            int randomNumber = Number().Next(1, 11);
            return randomNumber;
        }

        public int D12()
        {
            int randomNumber = Number().Next(1, 13);
            return randomNumber;
        }

        public int D20()
        {
            int randomNumber = Number().Next(1, 21);
            return randomNumber;
        }

        public int D100()
        {
            int randomNumber = Number().Next(1, 101);
            return randomNumber;
        }

        public int BaseStat()
        {
            int a = D6();
            int b = D6();
            int c = D6();
            int d = D6();

            if (a <= b && a <= c && a <= d)
                return b + c + d;
            if (b <= a && b <= c && b <= d)
                return a + c + d;
            if (c <= a && c <= b && c <= d)
                return a + b + d;
            return a + b + c;
        }
    }
}
