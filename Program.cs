
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write("Input " + i + " number: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int CountEvenElements(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             count++;
//     }
//     return count;
// }

// Console.WriteLine("How many numbers you want to input?");
// int quantity = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateArray(quantity);
// ShowArray(newArray);
// Console.WriteLine();
// Console.WriteLine($"WOW! {CountEvenElements(newArray)} numbers are positive");




// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// void Fibonacci(int size)
// {
//     int[] array = new int[size];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//         Console.Write(array[i] + " ");
//     }
// }

// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("0 1 ");
// Fibonacci(number);

// какое-то читерское решение получилось









