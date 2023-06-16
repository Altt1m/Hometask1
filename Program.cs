using System.Security.AccessControl;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        while (true) // Нескінченний цикл вибору завдання
        {
            int taskNum;
            Console.Write("Введіть номер завдання (1-12, 0 для виходу): ");
            taskNum = Convert.ToInt32(Console.ReadLine());
            if (taskNum == 1)
            {
                // №1 Відобразіть число пі різними способами
                double pi = Math.PI;
                Console.WriteLine(pi); // Звичайне відображення
                Console.WriteLine(pi.ToString("F2")); // Перші два знаки після коми
                Console.WriteLine(Math.Floor(pi) + "\n"); // Ціла частина
            }

            else if (taskNum == 2)
            {
                // №2 Клас System.Environment. Напишіть програму для відображення інформації про комп'ютер на консолі.
                string machineName = Environment.MachineName; // Назва пристрою
                string operatingSystem = Environment.OSVersion.ToString(); // Версія ОС
                string userName = Environment.UserName; // Ім'я користувача

                Console.WriteLine("\nІнформація про комп'ютер: ");
                Console.WriteLine("Назва комп'ютера: " + machineName);
                Console.WriteLine("Операційна система: " + operatingSystem);
                Console.WriteLine("Користувач: " + userName + "\n");
            }

            else if ( taskNum == 3)
            {
                // №3 Відстань дається в сантиметрах. Знайдіть в ньому кількість повних метрів.
                Console.Write("\nВведіть відстань у см: ");
                float height = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"Кількість повних метрів у відстані дорівнює {Math.Floor(height/100)}\n");
            }

            else if (taskNum == 4)
            {
                // №4 З якогось моменту минуло 234 дні. Скільки повних тижнів пройшло за цей період?
                int daysGone = 234; // Кількість пройдених днів
                Console.WriteLine($"За 234 дні пройшло повних {daysGone / 7} тижні.\n");
            }

            else if (taskNum == 5)
            {
                // №5 Наведено прямокутник з розмірами 543 х 130 мм. Скільки квадратів зі стороною 130 мм можна з нього вирізати?
                int length = 543; // Довжина прямокутника
                int width = 130; // Ширина прямокутника, вона ж сторона квадрата
                int rectangleArea = length * width; // Площа прямокутника
                int squareArea = width * width; // Площа квадрата
                Console.WriteLine($"У прямокутник з розмірами {length}x{width} мм поміститься щонайбільше {rectangleArea / squareArea} квадрати стороною {width} мм\n");
            }

            else if (taskNum == 6)
            {
                // №6 Створіть програму, яка обчислює середнє арифметичне двох чисел.
                float firstNum, secondNum;
                Console.Write("Введіть перше число: ");
                firstNum = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введіть друге число: ");
                secondNum = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"Середнє арифметичне двох чисел дорівнює {(firstNum + secondNum) / 2}\n");
            }

            else if (taskNum == 7)
            {
                // №7 Створіть програму, яка обчислює квадрат будь-якого введеного числа.
                float numToPow;
                Console.Write("Введіть число, яке хочети возвести в квадрат: ");
                numToPow = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"Отже, {numToPow} у квадраті дорівнює {Math.Pow(numToPow, 2)}.\n");
            }

            else if (taskNum == 8)
            {
                // №8 Створіть програму, яка запитує в користувача два числа та виводить на екран їх суму, різницю, добуток та частку.
                float firstNum, secondNum;
                Console.Write("Введіть перше число: ");
                firstNum = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введіть друге число: ");
                secondNum = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"{firstNum}+{secondNum}={firstNum+secondNum}"); // Сума
                Console.WriteLine($"{firstNum}-{secondNum}={firstNum-secondNum}"); // Різниця
                Console.WriteLine($"{firstNum}*{secondNum}={firstNum*secondNum}"); // Добуток
                Console.WriteLine($"{firstNum}/{secondNum}={firstNum/secondNum}"); // Частка
            }

            else if (taskNum == 9)
            {
                // №9 Створіть програму, яка запитує в користувача його рік народження та обчислює його вік.
                int birthYear;
                bool isCelebrated; // Чи був день народження в цьому році
                Console.Write("Введіть ваш рік народження: ");
                birthYear = Convert.ToInt32(Console.ReadLine());
                while (true) // Цикл питання про день народження
                {
                    Console.Write("У вас був день народження в цьому році? (1 чи 0): ");
                    isCelebrated = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
                    if (isCelebrated)
                    {
                        Console.WriteLine($"Вам {2023 - birthYear} рік/років.\n");
                        break;
                    }
                    else if (!isCelebrated)
                    {
                        Console.WriteLine($"Вам {2022 - birthYear} рік/років.\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Тільки \"1\" або \"0\".\n");
                    }
                }
                
            }

            else if (taskNum == 10)
            {
                // №10 Створіть програму, яка запитує в користувача довжину сторін прямокутного трикутника, а потім обчислює його гіпотенузу за формулою c = √(a² +b²).
                int a, b, c;
                Console.Write("Введіть довжину катета а: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть довжину катета b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Гіпотенуза трикутника дорівнює с = {Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2))}.\n");
            }

            else if (taskNum == 11)
            {
                // №11 Створіть програму, яка запитує в користувача кількість грошей в доларах та перетворює їх в євро за поточним курсом.
                float dollars;
                Console.Write("Введіть кількість USD, яку б хотіли перевести у EUR (1$=0,91€): ");
                dollars = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"{dollars}$ буде {dollars*0.91}€.\n");
            }

            else if (taskNum == 12)
            {
                // №12 Створіть програму, яка запитує в користувача його зріст у футах та дюймах,
                // а потім перетворює його в сантиметри за формулою 1 фут = 30.48 см, 1 дюйм = 2.54 см.
                int heightFoot, heightInch;
                Console.Write("Введіть частину вашого зросту у футах (x'): ");
                heightFoot = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть частину вашого зросту у дюймах (у''): ");
                heightInch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"У метричній системі ваш зріст дорівнює {(heightFoot*30.48+heightInch*2.54):f2}см\n");
            }

            else if (taskNum == 0) // Вихід з циклу
            {
                break;
            }

            else
            {
                Console.WriteLine("Такого завдання не існує!");
            }
        }
    }
}