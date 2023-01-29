using System;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Угадай число
            /*int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 1, number + 10);

            Console.WriteLine($"Мы загадали число от 0 до 100, оно больше чем {lower}, но меньше чем {higher}.");
            Console.WriteLine($"Что это за число? У вас {triesCount} попыток отгадать.");

            while (triesCount-- > 0)
            {
                Console.WriteLine("Ваш ответ: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number)
                {
                    Console.WriteLine("Вы правы, это было число " + number + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Не верно, попробуйте ещё раз.");
                }
            }

            if (triesCount < 0)
            {
                Console.WriteLine($"Вы проиграли, увы, но повезёт в следующий раз. Это было число {number}.");
            }*/

            //Бой гладиаторов
            Random rand = new Random();
            float health1 = rand.Next(90, 110);
            int damage1 = rand.Next(7, 35);
            int armor1 = rand.Next(45, 100);

            float health2 = rand.Next(80, 120);
            int damage2 = rand.Next(5, 40);
            int armor2 = rand.Next(65, 100);

            Console.WriteLine($"Гладиатор 1 - {health1} здоровье, {damage1} наносимый урон, {armor1} броня.");
            Console.WriteLine($"Гладиатор 2 - {health2} здоровье, {damage2} наносимый урон, {armor2} броня.");

            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;

                Console.WriteLine("Здоровье гладиатора 1: " + health1);
                Console.WriteLine("Здоровье гладиатора 2: " + health2);
            }

            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья. Оба гладиатора погибли.");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Гладиатор 1 пал.");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Гладиатор 2 пал.");
            }
        }
    }
}
