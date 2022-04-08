

namespace LambdaOgrenimi
{
    class LambdaOgrenimi
    {
        static void Main()
        {

            // Func<int, int, int> maximum = (x, y) =>
            // {
            //     if (y > x)
            //         return y;
            //     return x;
            // };

            var  maximum = (int x, int y) =>
            {
                if (y > x)
                    return y;
                return x;
            };
            Console.WriteLine("{0}", maximum(5, 60));

        }

    }
}

