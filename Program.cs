// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

            Random rnd = new Random();
            int[] arr = new int[5];
            int max=0, min=50;
            for (int i = 0; i<arr.Length; i++ )  arr[i] = rnd.Next(50);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
           
               for (int i = 0; i < arr.Length; i++) 
               Console.Write(" "+arr[i]);
               Console.WriteLine();
                 Console.WriteLine("макс:  " + max);
                 Console.WriteLine("мин:  " +min);
                 Console.WriteLine("Разница максимального и минимального:  "+(max - min));

                Console.ReadKey();

