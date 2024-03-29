﻿/*
Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

= rows int ReadInt("Введите количество строк: ");
= colums int ReadInt("Введите количество столбцов: ");
[двойныеновые= числа ] , [двойныестроки, столбцы];
FillArray2D(числа);
PrintArray2D(числа);

// Заполнение массива рандомными вещественными числами
пустота FillArray2D(двойной[,] массив)
{
    < i; 0 = iint ( для массива.Получаем длину (0); я++)
    {
        < j; 0 = jint ( для массива.Получаем длину (1); j++)
        {
 массив[i, j] = новый случайный().Следующий(-99, 99) / 10.0;
        }
    }
}

// Функция вывода массива в терминал
пустота PrintArray2D(двойной[,] массив)
{
    < i; 0 = iint ( для массива.Получаем длину (0); я++)
    {
        < j; 0 = jint ( для массива.Получаем длину (1); j++)
        {
 Консоль.Записать(массив[i, j] + " ");,,
        }
 Консоль.Строка записи();
    }
 Консоль.Строка записи();
}

// Функция ввода 
int readInt(строковое сообщение)
{
 Консоль.Написать(сообщение);
    верните преобразование.В int32(консоль.Строка чтения();,,
}

/*
 Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
 значение этого элемента или же указание, что такого элемента нет.
 Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
 Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 17 -> такого числа в массиве нет
 */

= rows int ReadInt("Введите индекс строки: ");
= colums int ReadInt("Введите индекс столбца: ");
int[,] числа = новый int[6, 8];
FillArray2D(числа);
PrintArray2D(числа);

< строк( если числа.Получаем длину(0) && столбцы < числа.Получить длину (1)консоли.Строка записи(числа[строки, столбцы]);
другая консоль.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// Заполнение массива рандомными числами от 1 до 9
void FillArray2D(int[,] массив)
{
    < i; 0 = iint ( для массива.Получаем длину (0); я++)
    {
        < j; 0 = jint ( для массива.Получаем длину(1); j++)
        {
 массив[i, j] = новый случайный().Следующий(1, 10);
        }
    }
}

// Функция вывода массива в терминал
аннулирует PrintArray2D(int[,] массив)
{
    < i; 0 = iint ( для массива.Получаем длину(0); i++)
    {
        < j; 0 = jint ( для массива.Получаем длину(1); j++)
        {
 Консоль.Записать(массив[i, j] + " ");
        }
 Консоль.Строка записи();
    }
 Консоль.Строка записи();
}

// Функция ввода 
int readInt(строковое сообщение)
{
 Консоль.Написать(сообщение);
    верните преобразование.В int32(консоль.Строка чтения();,,
}

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// int rows = ReadInt("Введите номер строки: ");
// int colums = ReadInt("Введите номер столбца: ");

int строк = 3;
int столбцы = 4;
[intnew= числа ] , [intстроки, столбцы];
FillArray2D(числа);
PrintArray2D(числа);

[удваиватьновые = средние номера ] [удваиватьчисла.Получаемая длина(;,,

< i; 0 = iint ( для чисел.Получить длину (1); i++)
{
    двойной результат = 0.0;
    < j; 0 = jint ( для чисел.Получаем длину (0); j++)
    {
        += результирующие числа[j, i];
    }
 Средние числа[i] = результат / числа.Получаем длину(0);,,
}
printArray(средние номера);


// Заполнение массива рандомными вещественными числами
void FillArray2D(int[,] массив)
{
    < i; 0 = iint ( для массива.Получаем длину (0); я++)
    {
        < j; 0 = jint ( для массива.Получаем длину (1); j++)
        {
 массив[i, j] = новый случайный().Следующий(1, 10);
        }
    }
}

// Функция вывода двумерного массива в терминал
void PrintArray2D(int[,] массив)
{
    < i; 0 = iint ( для массива.Получаем длину (0); я++)
    {
        < j; 0 = jint ( для массива.Получаем длину (1); j++)
        {
 Консоль.Записать(массив[i, j] + " ");
        }
 Консоль.Строка записи();
    }
 Консоль.Строка записи();
}

// Функция вывода массива в терминал 
void printArray(двойной[] массив)
{
    < i; 0 = iint ( для массива.Длина; i++)
    {
 Консоль.Записать(массив[i] + " ");,,
    }
 Консоль.Строка записи();
}

// Функция ввода 
int readInt(строковое сообщение)
{
 Консоль.Написать(сообщение);
    верните преобразование.В int32(консоль.Строка чтения();,,
}

