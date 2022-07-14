internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Список заданий:");
        Console.WriteLine("1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\r\n2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        Console.ResetColor();
        
        string decToDouble = "";
        int count = 0;
        string text="";
        void toDouble(int i, string text)
        {
          if (i>0)
          {
            toDouble(i / 2, text);
            decToDouble += (i % 2).ToString();
            text += (i % 2).ToString();
            Console.WriteLine("text: "+text);
          }    

        }

        void Pogovorka(int i)
        {
          int lenght = text.Length;
          if (i<=lenght)
          {
            if ((text[i].ToString() == "a") || (text[i].ToString() == "е") || (text[i].ToString() == "ё") || (text[i].ToString() == "и") || (text[i].ToString() == "о") || (text[i].ToString() == "э") || (text[i].ToString() == "ы") || (text[i].ToString() == "у") || (text[i].ToString() == "я")) 
          {
            count++;
            Console.WriteLine("count: ", count);
          }
            i++;
            Pogovorka(i);

          }
        }

        void Zadacha1()
        {
        Console.WriteLine("Задание 1");
        Console.WriteLine("Вводите числа, чтобы завершить программу нажмите <Escape>");
        Console.ResetColor();
        int count = 0;
        Console.Write("Введите число ");
        string resault = "";
        do
        {
               
          int number = Convert.ToInt32(Console.ReadLine());
          if (number>0) count++;
          resault = resault + " " + Convert.ToString(number);

        Console.WriteLine("Чтобы завершить программу, нажмите <Escape> ... ");
        }
        while (Console.ReadKey(true).Key  != ConsoleKey.Escape);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Пользователь ввел чисел больше 0 {count}");
        Console.WriteLine($"Введеные числа: {resault}");
        Console.ResetColor();
        }    

      void Zadacha2()
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Задание 2");
        Console.WriteLine("Введите значения b1, k1, b2, k2");
        Console.ResetColor();
        Console.WriteLine("Введите значение b1");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение k1");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение b2");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение k2");
        double k2 = Convert.ToDouble(Console.ReadLine());

        double x = (b2 - b1) / (k1-k2);
        double y = k1 * x + b1;

        Console.Write("точка перечечения x: ");
        Console.Write("{0:0.0000}",x);
        Console.Write(" точка перечечения y: ");
        Console.Write("{0:0.0000}",y);
      }

        Console.WriteLine("Список дополнительных заданий:");
        Console.WriteLine("1. Написать перевод десятичного числа в двоичное, используя рекурсию.\r\n2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.");
        Console.ResetColor();

      void Zadacha3()
      {
        Console.WriteLine("Задание ");
        Console.WriteLine("Введите чило");
        Console.ResetColor();
        int number = Convert.ToInt32(Console.ReadLine());
        
        toDouble(number, decToDouble);
        Console.WriteLine("Число в десятичной системе: " + decToDouble);

      }
      void Zadacha4()
    {
        Console.WriteLine("2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.");
        text = Console.ReadLine().ToString();
        Console.WriteLine("text  " + text);
        int count = 0;
        Pogovorka(0);
        Console.WriteLine("count:" + count);
    }
    Zadacha1();
    Zadacha2();
    Zadacha3();
    //Zadacha4();  в процессе
    }
}