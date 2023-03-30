using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Hhh;

public static class Program
{
	/// <summary>
	///Создание списка целых чисел
	///основные методы рабрты с элементами
	/// </summary>
	public static void Main()
	{
		//1.Создание пустой коллекции
List<int> ints = new List<int>();
//2.Добавление целых значений
ints.Add(1);
ints.Add(10);
ints.Add(25);
ints.Add(17);
ints.Add(10);
foreach(int elem in ints)
{
Console.Write($"{elem}\t");
}
Console.WriteLine();
ints.Add(30);
foreach(int elem in ints)
{
Console.Write($"{elem}\t");
}
//3.Вставка элемента по указанному индексу
Console.WriteLine();
ints.Insert(0,500);
foreach(int elem in ints)
{
Console.Write($"{elem}\t");
}
//4.Добавление в список одномерного массива
Console.WriteLine();
ints.AddRange(new[] {-5,0,14});
foreach(int elem in ints)
{
Console.Write($"{elem}\t");
}
//5. Определение колличества эллементов коллекции
Console.WriteLine();
//int size=ints.Count;
//Console.WriteLine($"Текущие колличество элементов = {size}");
Console.WriteLine($"Текущие колличество элементов = {ints.Count}");
//6.Определение индекса элемента со значением 25
Console.WriteLine();
Console.WriteLine($"Индекс элемента со значением 25 = {ints.IndexOf(25)}");
//7. Удаление из коллекции первого вхождение элемента со значением 10
ints.Remove(10);
foreach(int elem in ints)
{
Console.Write($"{elem}\t");
}
//8.Удаление из коллекции элемента с указанным индексом
Console.WriteLine();
ints.RemoveAt(3);
foreach(int elem in ints)
{
Console.Write($"{elem}\t");
}
//9. Сортировка коллекции по возростанию
Console.WriteLine();
ints.Sort();
foreach(int elem in ints)
{
Console.Write($"{elem}\t");
}

//9. Сортировка коллекции по убыванию
Console.WriteLine();
ints.Reverse();
foreach(int elem in ints)
{
Console.Write($"{elem}\t");
}

 Console.ReadLine();
	}
}
