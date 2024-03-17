using System;

namespace QueryingNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80};
            int times = 0;
            int number;

            Console.Write("Lütfen bir sayı giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (number == numbers[i])
                {
                    times++;
                }
            }

            if (times == 0)
            {
                Console.WriteLine("Girdiğiniz sayı dizide bulunamadı!");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı dizide bulundu!");
                Console.WriteLine("Adet: " + times);
            }
            Console.ReadLine();
        }
    }
}
