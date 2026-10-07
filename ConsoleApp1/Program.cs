//Console.WriteLine("Рецепт кофе");
//Console.WriteLine("это мой любимый наапиток");
//Console.WriteLine("кофе");
////Console.WriteLine()



//Console.WriteLine("улучшеный калькулятор");
//Console.WriteLine("введите первое число");
//double firstNum = Convert.ToDouble(Console.ReadLine());


//Console.WriteLine("введите второе число");
//double twoNum = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("введите оператор +,-,*,/");
//string oper = Console.ReadLine();
//switch (oper)
//{
//    case "+":
//        Console.WriteLine($"сожение:{firstNum}+{twoNum} = {firstNum + twoNum}");
//        break;


//    case "-":
//        Console.WriteLine($"вычитание: {firstNum}-{twoNum} = {firstNum - twoNum}");
//        break;

//    case "*":
//        Console.WriteLine($"вычитание: {firstNum}*{twoNum} = {firstNum * twoNum}");
//        break;

//    case "/":
//        if (firstNum == 0)
//        {
//            Console.WriteLine("делить на ноль нельзя");
//        }
//        else
//        Console.WriteLine($"вычитание: {firstNum}/{twoNum} = {firstNum / twoNum}");
//        break;
//     default : Console.WriteLine("вы ввели неправильное значение");
//        break;
//}



Console.WriteLine("Введите значение от 0 до 10");
int firstNun = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("начало цикла if");
for (int i = firstNun; i <= 100; i++)
{
    Console.WriteLine($"Ваше значаения i:  {i}");
    if (i % 2 == 0)
    {
        Console.WriteLine($"четные значения числа:{i}");
    }
    else
    {
        Console.WriteLine($"нечетные значения числа: {i}");
    }
}
Console.WriteLine("конец цыкла for");
Console.ReadLine();

for (int i = 16; i <= 100; i++)
{
    if (i % 7 == 0)
    {
        Console.WriteLine($"первое значение которое делится на 7: {i}");
        break;
    }
}

while (true)
{
    Console.WriteLine("1.Вход в игру!");
    Console.WriteLine("2.сохранить игру!");
    Console.WriteLine("3.загрузить игру!");
    Console.WriteLine("4.выход с игры");

    int press = Convert.ToInt32(Console.ReadLine());

    if (press == 0)
    {
        Console.WriteLine("Выход из игры");
        break;
    }
    else if (press >= 5 || press <=0)
    {
        Console.WriteLine("для выхода нажмите кнопку 4");
    }
}

string user;
do {
    Console.WriteLine("1.Вход в игру!");
    Console.WriteLine("2.сохранить игру!");
    Console.WriteLine("3.загрузить игру!");
    Console.WriteLine("4.выход с игры");

    user =    Console.ReadLine();
} while (user != "4");
Console.WriteLine("спасибо за игру");