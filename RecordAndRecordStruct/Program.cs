using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordAndRecordStruct
{
    using System;

    namespace RecordAndRecordStruct
    {
        public class Program
        {
            public static void Main()
            {
                string name1 = "";
                int age1 = 0;

                while (true)
                {
                    try
                    {
                        Console.Write("Введите имя первого человека: ");
                        name1 = Console.ReadLine()!;

                        Console.Write("Введите возраст первого человека: ");
                        age1 = int.Parse(Console.ReadLine()!);

                        if (age1 < 0 || age1 > 100)
                        {
                            throw new ArgumentException(
                                "Возраст должен быть от 0 до 100."
                            );
                        }

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(
                            "Ошибка: возраст должен быть целым числом."
                        );
                        Console.WriteLine("Попробуйте ещё раз.");
                        Console.WriteLine();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine("Попробуйте ещё раз.");
                        Console.WriteLine();
                    }
                }

                string name2 = "";
                int age2 = 0;

                while (true)
                {
                    try
                    {
                        Console.Write("Введите имя второго человека: ");
                        name2 = Console.ReadLine()!;

                        Console.Write("Введите возраст второго человека: ");
                        age2 = int.Parse(Console.ReadLine()!);

                        if (age2 < 0 || age2 > 100)
                        {
                            throw new ArgumentException(
                                "Возраст должен быть от 0 до 100."
                            );
                        }

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(
                            "Ошибка: возраст должен быть целым числом."
                        );
                        Console.WriteLine("Попробуйте ещё раз.");
                        Console.WriteLine();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine("Попробуйте ещё раз.");
                        Console.WriteLine();
                    }
                }

                Person person1 = new Person(name1, age1);
                Person person2 = new Person(name2, age2);

                Console.WriteLine();
                Console.WriteLine("Проверка record:");
                Console.WriteLine($"Первый человек: {person1}");
                Console.WriteLine($"Второй человек: {person2}");
                Console.WriteLine($"person1 == person2: {person1 == person2}");

                int newAge;

                while (true)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.Write("Введите новый возраст для копии: ");
                        newAge = int.Parse(Console.ReadLine()!);

                        if (newAge < 0 || newAge > 100)
                        {
                            throw new ArgumentException(
                                "Возраст должен быть от 0 до 100."
                            );
                        }

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(
                            "Ошибка: возраст должен быть целым числом."
                        );
                        Console.WriteLine("Попробуйте ещё раз.");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine("Попробуйте ещё раз.");
                    }
                }

                Person personCopy = person1 with { Age = newAge };

                Console.WriteLine();
                Console.WriteLine("Проверка with:");
                Console.WriteLine($"Оригинал: {person1}");
                Console.WriteLine($"Копия: {personCopy}");

                var (name, age) = person1;

                Console.WriteLine();
                Console.WriteLine("Проверка деконструкции:");
                Console.WriteLine($"Имя: {name}");
                Console.WriteLine($"Возраст: {age}");

                Console.WriteLine();
                Console.WriteLine("Проверка record struct:");

                PersonStruct personStruct = new PersonStruct(name1, age1);

                Console.WriteLine($"До изменения: {personStruct}");

                int structAge;

                while (true)
                {
                    try
                    {
                        Console.Write("Введите новый возраст для record struct: ");
                        structAge = int.Parse(Console.ReadLine()!);

                        if (structAge < 0 || structAge > 100)
                        {
                            throw new ArgumentException(
                                "Возраст должен быть от 0 до 100."
                            );
                        }

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(
                            "Ошибка: возраст должен быть целым числом."
                        );
                        Console.WriteLine("Попробуйте ещё раз.");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine("Попробуйте ещё раз.");
                    }
                }

                personStruct.Age = structAge;

                Console.WriteLine($"После изменения: {personStruct}");

                Console.WriteLine();
                Console.WriteLine("Программа завершена.");
            }
        }
    }
}
