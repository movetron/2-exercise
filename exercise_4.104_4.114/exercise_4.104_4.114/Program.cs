
Console.WriteLine("Введите порядковый номер дня недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
  {
            case 1:
                Console.WriteLine(Wk.понедельник);
                break;
            case 2:
                Console.WriteLine(Wk.вторник);
                break;
            case 3:
                Console.WriteLine(Wk.среда);
                break;
            case 4:
                Console.WriteLine(Wk.четверг);
                break;
            case 5:
                Console.WriteLine(Wk.пятница);
                break;
            case 6:
                Console.WriteLine(Wk.суббота);
                break;
            case 7:
                Console.WriteLine(Wk.воскресенье);
                break;

        }

enum Wk
{
    понедельник,
    вторник,
    среда,
    четверг,
    пятница,
    суббота,
    воскресенье
}
          