//урок 2 
using System;

class program{
        static void Main(){
        //задание 1 
      double firstvalue, secondvalue;

      Console.WriteLine("минимальная температура");

      firstvalue = double.Parse(Console.ReadLine());

      Console.WriteLine("максимальная температура");

      secondvalue = double.Parse(Console.ReadLine());

      double result = (firstvalue + secondvalue) / 2;

      Console.WriteLine("средняя температура " + result);
      // задание 2 
      Console.WriteLine("введите порядковый номер месяца");

      int month;

      month = int.Parse(Console.ReadLine());
      
      if(month == 1)
      Console.WriteLine("январь");
      if(month == 2)
      Console.WriteLine("февраль");
      if(month == 3)
      Console.WriteLine("март");
      if(month == 4)
      Console.WriteLine("апрель");
      if(month == 5)
      Console.WriteLine("май");
      if(month == 6)
      Console.WriteLine("июнь");
      if(month == 7)
      Console.WriteLine("июль");
      if(month == 8)
      Console.WriteLine("август");
      if(month == 9)
      Console.WriteLine("сентябрь");
      if(month == 10)
      Console.WriteLine("октябрь");
      if(month == 11)
      Console.WriteLine("ноябрь");
      if(month == 12)
      Console.WriteLine("декабрь");
       
    
      // задание 3
      Console.WriteLine("проверка числа на четность");
       
      int a;

      a = int.Parse(Console.ReadLine());

      if(a % 2 == 0)
      Console.WriteLine("число четное ");
      else
      {
          Console.WriteLine("число не четное");
      }

      // задание 4
      

    }
}

