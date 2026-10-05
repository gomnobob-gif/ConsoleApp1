//Console.WriteLine("Рецепт кофе");
//Console.WriteLine("это мой любимый наапиток");
//Console.WriteLine("кофе");
//Console.WriteLine()



Console.WriteLine("улучшеный калькулятор");
Console.WriteLine("введите первое число");
double firstNum = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("введите второе число");
double twoNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите оператор +,-,*,/");
string oper = Console.ReadLine();
switch (oper)
{
    case "+":
        Console.WriteLine($"сожение:{firstNum}+{twoNum} = {firstNum + twoNum}");
        break;


    case "-":
        Console.WriteLine($"вычитание: {firstNum}-{twoNum} = {firstNum - twoNum}");
        break;

    case "*":
        Console.WriteLine($"вычитание: {firstNum}*{twoNum} = {firstNum * twoNum}");
        break;

    case "/":
        if (firstNum == 0)
        {
            Console.WriteLine("делить на ноль нельзя");
        }
        else
        Console.WriteLine($"вычитание: {firstNum}/{twoNum} = {firstNum / twoNum}");
        break;
     default : Console.WriteLine("вы ввели неправильное значение");
        break;
}