
Console.WriteLine("Введите число: ");
//Считываем данные с консоли
string inputNum = Console.ReadLine();
//Проверим ,чтобы данные были не пустые
if(inputNum!=null)
{
   //Просим введенное число
   int num = int.Parse(inputNum);
   //Находим квадрат числа
   int res = num*num;
   //Вводим данные в консоль
   Console.WriteLine(res);
}

Console.WriteLine("Квадрат числа: "+(int)Math.Pow(int.Parse(inputNum),2));

