﻿using Microsoft.Win32.SafeHandles;

int[] numbers = new int[3];
numbers[0] = 1;
numbers[1] = 15;
numbers[2] = 2;

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

