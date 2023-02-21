// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double Promt (string message)
{
  Console.WriteLine(message);
  string numberString = Console.ReadLine() ?? String.Empty;
  double result = Convert.ToDouble(numberString);
  return result;
}

//МЕТОД, который создает массив кубов чисел по принимаемому параметру

double [] RaisingToTheThirdPower (double inValue)
{ 
  double result = 0;
  int tempCounter = Convert.ToInt32(inValue);
  double [] arrayThirdPower = new double [tempCounter];
  for (int i = 1; i <= tempCounter; i++)
  {
    result = Math.Pow(Convert.ToDouble(i), 3);
    arrayThirdPower [i-1] = result;
  }
  return arrayThirdPower;
}
//МЕТОД, который выводит массив кубов в консоль

void ShowArray (ref double [] inArrayToShow)
{
  for (int i = 0; i < inArrayToShow.Length; i++)
  {
    Console.WriteLine($"Cube number {i+1} is = {inArrayToShow[i]}");
  }
}

//МЕТОД, осуществляющий проверку на истинность вводимого числа.

bool RangeCheckNumber (double valueInRange)
{
  bool temp = true;
  if (valueInRange<=0)
  {
    Console.WriteLine($"Error! Your number {valueInRange} is out of range!!");
    temp = false;
    return temp;
  }
  else 
  {
    return temp;
  }
}

//Точка входа в программу
double number = Promt("Enter your first number, please!");
if (RangeCheckNumber(number))
{
  double [] resultConvertArrayCubes = RaisingToTheThirdPower(number);
  ShowArray(ref resultConvertArrayCubes);
}
