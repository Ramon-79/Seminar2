// 12. Напишите программу, которая будет принимать на вход два числа и 
// выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

Console.WriteLine("Введите первое чсило: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе чсило: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number2 % number1 == 0)
{
    //int result = number2 % number1;
    Console.Write($"Число {number2} кратное {number1}");
}
else
{
    Console.Write($"Число {number2} не кратное {number1}, остаток {number2 % number1}");
    //Console.WriteLine("Чичла кратные");
}