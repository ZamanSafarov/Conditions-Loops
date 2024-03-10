using System.Text;


#region Task1  
//Verilmis ededin reqemlerinin hasilini tapin.

/*   With While    */

//int a = Math.Abs(ReadInteger("Eded daxil edin: "));
//int number = 0;
//int hasil = 1;

//    while (a > 0)
//    {
//        number = a % 10;
//        hasil *= number;
//        a /= 10;
//    }

//Console.WriteLine(hasil);



/*   With For (extra)    */

//int a = Math.Abs(ReadInteger("Eded daxil edin: "));
//string b = Convert.ToString(a);
//int number = 0;
//int hasil = 1;
//for (int i = 0; i < b.Length; i++)
//{
//    number = a % 10;
//    hasil *= number;
//    a /= 10;
//}
//Console.WriteLine(hasil);
#endregion


#region Task2 

//Verilmis ededin sade ve ya murekkeb oldugunu tapan alqoritm.

//l3:
//int a = ReadInteger("Eded daxil edin: ");

//int check = 0;

//if (a <= 1)
//{
//    Console.WriteLine($"{a} nə sadə nədə mürəkkəb ədəddir!!");
//    goto l3;
//}
//else
//{
//    for (int i = 2; i < a; i++)
//    {
//        if (a % i == 0)
//        {
//            check++;
//            break;
//        }
//    }
//}

//if (check == 0 )
//    Console.Write($"{a} sade ədəddir!!");
//else
//    Console.Write($"{a} mürəkkəb ədəddir!!");

#endregion


#region Task3      
//Verilmis ededin faktorialini tapin.
//l3:
//int a = ReadInteger("Eded daxil edin: ");// 0 daxil etsede faktorial 1 olduğuna göre qısa yol olur

//int faktorial = 1;

//for (int i = 1; i <= a; i++)
//{
//    faktorial *= i;
//}
//if (a >= 0)
//{
//    Console.WriteLine($"{a} Ededinin faktorialı: {faktorial}");
//}
//else
//{
//    Console.WriteLine($"{a} Ededinin faktorialı yoxdur");
//    goto l3;
//}


#endregion

#region Task4  

//Verilmiş ədədin polindrom olub olmadığını tapan alqoritm (Meselen: 1221->polindrom, 1231->polindrom deyil) (optional)

int a = ReadInteger("Eded daxil edin: ");
int sum = 0;
int polindrome = a;
int qaliq;


while (a > 0 && polindrome > 99)
{
    qaliq = a % 10;
    sum = sum * 10 + qaliq;
    a /= 10;
}

if (sum == polindrome)
{
    Console.WriteLine($"{polindrome} Polindrome Ededdir!");
}
else
{
    Console.WriteLine($"{polindrome} Polindrome Eded Deyl!!");
}

#endregion











#region methods for types

static int ReadInteger(string caption)
{
l1:
    Console.WriteLine(caption);
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    if (!int.TryParse(Console.ReadLine(), out int value))
    {
        PrintError("duzgun melumat deyil, yeniden cehd edin");
        goto l1;
    }
    Console.ResetColor();
    return value;
}



static string ReadString(string caption)
{
l1:


    Console.Write(caption);
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    string value = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(value))
    {
        PrintError("duzgun melumat deyil, yeniden cehd edin");
        goto l1;
    }
    Console.ResetColor();
    return value;
}

static void PrintError(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(message);
    Console.ResetColor();
}
#endregion