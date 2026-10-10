// zadanie 1.1
// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// zadanie 1.2 
// for (int i = 1; i <= 50; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i); 
//     }
// }

// zadanie 2
// int summa_del_3 = 0;
// int count_del_7 = 0;

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         summa_del_3 = summa_del_3 + i; 
//     }
//     if (i % 7 == 0)
//     {
//         count_del_7++;
//     }
// }
// Console.WriteLine($"{summa_del_3}, {count_del_7}");

// zadanie 3

// int number = Convert.ToInt32(Console.ReadLine());
// int total = 0;
// int poloj = 0;
// int otric = 0;

// while (number != 0)
// {
//     total += number;
//     number = Convert.ToInt32(Console.ReadLine());

//     if (number >= 0)
//     {
//         poloj++;
//     } else
//     {
//         otric++;
//     }
// }

// Console.WriteLine($"vsego: {total}, otric: {otric}, poloj: {poloj}");

// zadanie 4
// string pravilniy_password;
// string password;
// bool pravilno = false;

// pravilniy_password = "qwerty";

// for (int i = 0; i < 3; i++) {
//     Console.Write("vvedite parol: ");
//     password = Console.ReadLine();

//     if (password == pravilniy_password)
//     {
//         Console.WriteLine("dostup razreshen");
//         pravilno = true;
//         break;
//     }
// }

// if (!pravilno)
// {
//     Console.WriteLine("dostup zapreshen");
// }

// zadanie 5 

// Console.Write("vvedite chislo: ");
// int chislo = Convert.ToInt32(Console.ReadLine());;

// for (int i = 1; i <= 9; i++)
// {
//     Console.WriteLine($"{chislo} x {i} = {chislo * i}");
// }

// zadanie 6 
// int i = 1;

// do
// {
//     if (i % 3 == 0)
//     {
//         i++;
//         continue;
//     }

//     if (i % 10 == 0 && i >= 20)
//     {
//         break;
//     }

//     Console.WriteLine(i);
//     i++;   
// }

// while (i <= 30);

// itogzadacha



int i = 0;
int secret = 50;
int chislo;

do
{
    Console.Write("vvedite chislo: ");
    chislo = Convert.ToInt32(Console.ReadLine());
    i++;

    if (chislo > secret)
    {
        Console.WriteLine("menishe");
    }

    if (chislo < secret)
    {
        Console.WriteLine("bolshe");
    }

    if (chislo == secret)
    {
        Console.WriteLine($"pobeda, popitok isp = {i}");
        break;
    }
    
}
while (i < 5);

if (chislo != secret)
{
    Console.WriteLine($"pozor {secret}.");
}

