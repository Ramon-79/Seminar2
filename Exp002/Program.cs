// 11. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

// Вот тут я наверное напишу, как сделать ввод совсем корректнеым, что б мы получали только трехзначное число и не было других ошибок (иных цифр, пробелов, пустых вводов, букв и т.д.)
// Вообще, можно как бы сделать так - int number = new Random().Next(100, 1000); и у нас будет рандомное число
// Но сделаю с вводом

// здесь зацикленный while, т.е. while(true) - бесконечный цикл.
// оборвется он только тогда, когда try будет удачным
int number;
while(true){
    // Принимаем на ввод число и проверяем, точно ли тут число? Например, могут ввести букву или, не вводя ничего, нажать Enter
    // Пытаемся сделать следующее, буквально try - пытаемся
    try{
        Console.Write("Укажите любое целое трехзначное положительное число: ");
        number = Convert.ToInt32(Console.ReadLine());
        // Если у нас число, то проверим положительное ли оно и трехзначное ли
        if(number >= 100 && number < 1000)
        {
            //выйдем из цикла если условие верно
            break;
        }
        else
        {
            // У нас тут число но не трехзначное, сообщим об этом
            Console.WriteLine("Число не положителное или не трехзначное.");
        }
        // если попытка записать число не удалась, у нас возникает ошибка ввода (прям во всех случаях ввода чего-то, отличного от целого числа со знаком
        // отлавливаем эту ошибку через catch, буквально catch - поймать
        // в скобочках указываем, что именно мы ловим - FormatException.
        // FormatException – некорректный формат операнда или аргумента. Именно он и будет у нас возникать при вводе чего-угодно, кроме целого числа
    }catch (FormatException){
        // сообщаем пользователю, что у нас ошибка и просим ввести число
        // т.е. опять прыгаем в try
        // и будем туда прыгать, пока не получим на вводе число
        Console.WriteLine("Ошибка ввода. Введите целое положительное трехзначное число");
    }
}

// Теперь у нас есть нужное число, начнем решать задачу

// Объявим переменную result, в которую запишем наши вычисления
// Можно сделать одной строкой, как на семинаре показывал Габиль
int result = ((number / 100) * 10 + number % 10);
Console.WriteLine($"Если у числа {number} удалим вторую цифру, получим {result}");

// А можно разбить на несколько переменных, и с каждой из них произвести необходимые действия

// Вот тут мы наше число разделили на 100 и получили первую цифру
// Но т.к. удалив вторую цифру из нашего трехзнака мы получим двузнак, полученную первую цифру нужно умножить на 10
int num1 = (number / 100) * 10;

// Тут получим последнюю цифру трехзнака. Просто число поделим на 10 с остатком
int num2 = number % 10;

// Теперь еще одна переменная, где мы сложим два получившихмя значения
int sum = num1 + num2;

// Покажем результат в консоли
Console.WriteLine($"Число {number} без цифры в серединке - это {sum}");

// Теперь метод
void Number(int data)
{
    // Объявляем ту же логику, что и в задаче, только вместо number поставим тот агрумент, который принимаем на вход - data (можно обозвать как угодно)
    int some_num1 = (data / 100) * 10;
    int some_num2 = data % 10;
    int some_sum = num1 + num2;
    Console.WriteLine("А это вернется из метода с void: "+some_sum);
}

// Используем метод
Number(number);

// Теерь метод без void
int Last_Metod(int data)
{
    int summa = ((data / 100) * 10 + data % 10);
    return summa;
}

// Используем метод
int summa = Last_Metod(number);
Console.WriteLine($"Вот это вернет метод без Void {summa}");

