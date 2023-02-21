// Проверить число на полиндром, в том числе с различной разрядностью, например: 100000 и 1 (нули перед единицей нет, но он является полиндромом)

// МЕТОД, принимающий сообщение и возвращающий число, введенное пользователем в консоль

int Promt (string message)
{
  Console.WriteLine(message);
  string numberString = Console.ReadLine();
  int result = Convert.ToInt32(numberString);
  return result;
}

// МЕТОД, преобразующий число в массив элементов разрядностей типа int этого числа

int [] ConvertingANumberToAnArray (int value)
{ 
  string str = Convert.ToString(value);
  int [] valueArray = new int [str.Length];
  for (int i = 0; i < str.Length; i++)
  {
    valueArray[i] = int.Parse(str[i].ToString());
  }
  return valueArray;
}

// МЕТОД, переворачивающий элементы массива на взаимопротивоположные ячейки массива (не беру по ссылке массив, поскольку в дальнейшем, возможно, может понадобиться оригинальный)

int [] FlipAnArray (int [] arrayToFlip)
{
  int tempararyFirst;
  for (int i = 0; i < arrayToFlip.Length/2; i++)
  {
    tempararyFirst = arrayToFlip [i];
    arrayToFlip [i] = arrayToFlip [arrayToFlip.Length-1-i];
    arrayToFlip [arrayToFlip.Length-1-i] = tempararyFirst;
  }
  return arrayToFlip;
}

// МЕТОД проверки соразмерности массивов и дополненния меньшего массива недостающими нулями

int [] AddigZerosToAnArray (ref int [] arrayMaxLength, ref int [] arrayMinLength)
{
    int difference = arrayMaxLength.Length - arrayMinLength.Length;
    int [] temparary = new int [arrayMaxLength.Length];
    for (int i = 0; i < difference; i++)
    {
      temparary [i] = 0;   
    }
    for (int i = difference, j = 0; i < arrayMaxLength.Length; i++, j++)
    {
      temparary [i] = arrayMinLength[j];    
    }
    
  return temparary;
}

//METOД вывода массива в консоль
void ShowArray (int [] arrayToShow)
{
  Console.WriteLine("Your array is:");
  for (int i = 0; i < arrayToShow.Length; i++)
  {
    Console.Write(arrayToShow[i]);
  }
  Console.WriteLine();
}

//МЕТОД проверки массивов на палиндром
void ArrayValidation (int [] array1, int [] array2)
{ bool palindromes = false;
  if (array1.Length == array2.Length)
  {
    for(int i = 0; i < array1.Length; i++)
    { if (array1 [i] == array2 [i])
      {
        palindromes = true;
      }
      else
      {
        palindromes = false;
        break;
      }
    }
  }
  if (palindromes)
  {
    Console.WriteLine ("Yes, your numbers: are a palindromes");
  }
  else 
  {
    Console.WriteLine ("No, your numbers: are not palindromes");
  }
  
}
//РЕЗУЛЬТИРУЮЩИЙ МЕТОД
void CheckForPalindrome (ref int [] numberArray1, ref int [] numberArray2)
{
  if (numberArray1.Length > numberArray2.Length)
  {
    int [] numberArray3 = FlipAnArray(AddigZerosToAnArray (ref numberArray1, ref numberArray2));
    ShowArray(numberArray1);
    ShowArray(numberArray3);
    ArrayValidation(numberArray1, numberArray3);
    return;
  }
  if (numberArray2.Length > numberArray1.Length)
  { 
    int [] numberArray3 = FlipAnArray(AddigZerosToAnArray (ref numberArray2, ref numberArray1));
    ShowArray(numberArray2);
    ShowArray(numberArray3);
    ArrayValidation(numberArray2, numberArray3);
    return;
  }
  if (numberArray1.Length == numberArray2.Length)
  {
    int [] numberArray3 = FlipAnArray(numberArray2);
    ShowArray(numberArray1);
    ShowArray(numberArray3);
    ArrayValidation(numberArray1, numberArray3);
    return;
  }
}

// Точка входа в программу
int number1 = Promt("Enter your first number, please!");
int number2 = Promt("Enter your second number, please!");
int [] numberInArray1 = ConvertingANumberToAnArray(number1);
int [] numberInArray2 = ConvertingANumberToAnArray(number2);
ShowArray(numberInArray1);
ShowArray(numberInArray2);
CheckForPalindrome (ref numberInArray1, ref numberInArray2);






