        static void Main(string[] args)
        {
            /////q1
            //1
            int[] arr10 = new int[10];
            for (int i = 0; i < arr10.Length; i++)
                arr10[i] = 0;
            for (int i = 0; i < arr10.Length; i++)
            {
                arr10[i] = (i + 1) * 10;
                Console.Write($"{arr10[i]} ");
            }
            Console.WriteLine(" ");
            //2
            int[] arrPow = new int[10];
            int x = 1;
            for (int i = 0; i < arrPow.Length; x++, i++)
                arrPow[i] = x;
            for (int i = 0; i < arrPow.Length; i++)
            {
                arrPow[i] = arrPow[i] * arrPow[i];
                Console.Write($"{arrPow[i]} ");
            }
            Console.WriteLine(" ");
            //3
            int[] arrNumOdd = new int[10];
            int e = 1;
            for (int i = 0; i < arrNumOdd.Length; e++, i++)
                arrNumOdd[i] = e;
            for (int i = 0; i < arrNumOdd.Length; i++)
            {
                if (arrNumOdd[i] % 2 != 0)
                    Console.Write($"{arrNumOdd[i]} ");
                else
                    Console.Write("0 ");
            }
            Console.WriteLine(" ");
            //4
            int[] arr3 = new int[10];
            int f = 3;
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = f;
                f += 3;
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i] % 3 == 0)
                    Console.Write($"{arr3[i]} ");
            }
            Console.WriteLine(" ");
            //5
            int[] arrNumEven = new int[10];
            int a = 2;
            for (int i = 0; i < arrNumEven.Length; i++)
            {
                arrNumEven[i] = a;
                a += 2;
            }
            for (int i = 0; i < arrNumEven.Length; i++)
            {
                if (arrNumEven[i] % 4 == 0)
                    Console.Write($"-{arrNumEven[i]} ");
                else if (arrNumEven[i] % 2 == 0 && arrNumEven[i] % 4 != 0)
                    Console.Write($"{arrNumEven[i]} ");
            }
            Console.WriteLine(" ");
            //6
            int y = 7;
            int[] arrNum = new int[10];
            for (int i = 0; i < arrNum.Length; i++)
                arrNum[i] = 0;
            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = y + i;
                y = arrNum[i];
                Console.Write($"{arrNum[i]} ");
            }
            Console.WriteLine(" ");
            
            ///q2
            int[] numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            ///q3
            int maxNum = numbers[0], minNum = numbers[0], max = 0, minIndex = 0;
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                    max++;
                }
                else if (numbers[i] < minNum){
                    minNum = numbers[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"The max number is {maxNum},  there is {max} max numbers\n" +
                $"The min number is {minNum}, his index {minIndex}");
            ///q4
            int count = 0, minCount = 0;
            double avg = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                avg += numbers[i];
                count++;
            }
            avg /= count;
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] < avg)
                    minCount++;
            }
            Console.WriteLine($"Count of numbers that lower the average {minCount}");

            //q5
            int sumEven = 0, sumOdd = 0;
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] % 2 == 0)
                    sumEven += numbers[i];
                else
                    sumOdd += numbers[i];
            }
            if (sumEven == sumOdd)
                Console.WriteLine("The even sum and the odd sum are the same");
            else
                Console.WriteLine("The even sum and the odd sum are diffrent");
            
            //q6
            int doesExist = 0;
            int[] numbers2 = new int[10];
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers2.Length; i++) {
                Console.WriteLine("Enter a number for array: ");
                numbers2[i] = int.Parse(Console.ReadLine());

                if (numbers2[i] == num)
                    doesExist ++;
            }
            if (doesExist <= 1)
                Console.WriteLine("The number is in the array");
            else
                Console.WriteLine("The numbers isn't in the array");
            
            //q7
            int same = 0, num1;
            int[] numbers3 = new int[10];
            for (int i = 0; i < numbers3.Length; i++) {
                Console.WriteLine("Enter a number: ");
                numbers3[i] = int.Parse(Console.ReadLine());
            }
            num1 = numbers3[0];
            for (int i = 0; i < numbers3.Length; i++)
                if (numbers3[i] == num1)
                    same++;
            if (same == numbers3.Length)
                Console.WriteLine("All numbers are same");
            else
                Console.WriteLine("The numbers are diffrent");
            
            //q8
            int num2 = 0, higher = 0;
            int[] numbers4 = new int[10];
            for (int i = 0; i < numbers4.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                numbers4[i] = int.Parse(Console.ReadLine());
                if (num2 < numbers4[i])
                    higher++;
                num2 = numbers4[i];
            }
            if (higher == numbers4.Length)
                Console.WriteLine("The array is going up");
            else
                Console.WriteLine("Idk");

            Console.ReadLine();
