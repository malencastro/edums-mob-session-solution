namespace EduMSMobSession
{
    public static class Fibonacci
    {
        // Given a number n, print n-th Fibonacci Number, considering the sequence to be zero-based numbering
        // Examples:
        // input 0
        // output 0
        // input 9
        // output 34
        // input 15
        // output 610
        public static int GetFibonaccPosition(int position)
        {
            int a = 0, b = 1, c = 0;
            if (position == 0)
            {
                return a;
            }

            for (int i = 2; i <= position; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}
