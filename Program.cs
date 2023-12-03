// See https://aka.ms/new-console-template for more information

//Console.Write("Введите значения: ");//
//int x = Convert.ToInt32(Console.ReadLine());//
//x++;//
//if (x > 100)//
//{Console.Write($"Больше ста {x}");//
//}//
//else//
//Console.Write($"меньше ста {x}");//

//Console.Write("Введите два значение a: ");//
//int a = Convert.ToInt32(Console.ReadLine());//
//Console.Write("Введите два значение b: ");//
//int b = Convert.ToInt32(Console.ReadLine());//
//int y = (b * b);//
//if (a == y)//
//Console.Write($"Да");//
//else//
//Console.Write($"Нет");//


//Console.Write("Введите номер дня недили: ");
//int a = Convert.ToInt32(Console.ReadLine());
//if (a == 1)
//Console.Write($"Понедельник");
//else//
//if (a == 2)
//Console.Write($"Вторник");
//else
//if (a == 3)
//Console.Write($"среда");
//else
//if (a == 4)
//Console.Write($"четверг");
//else
//if (a == 5)
//Console.Write($"пятница");
//else
//if (a == 6)
//Console.Write($"Суб");
//else
//if (a == 27)
//Console.Write($"Воск");

//Console.Write("Введите трехзначное число: ");
//int a = Convert.ToInt32(Console.ReadLine());
//int b =a % 10;
//Console.Write(b);

//Console.Write("Введите значение a: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите два значение b: ");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a > b)
//Console.Write($"MAX - {a}, MIN - {b}");
//else
//Console.Write($"MAX - {b}, MIN - {a}");

//Console.Write("Введите значение a: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите значение b: ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите значение c: ");
//int c = Convert.ToInt32(Console.ReadLine());
//if (a > b)
//if (a > c)
//Console.Write($"MAX - {a}");
//if (b > a)
//if (b > c)
//Console.Write($"MAX - {b}");
//if (c > a)
//if (c > b)
//Console.Write($"MAX - {c}");

//Console.Write("Введите значение a: ");
//int a = Convert.ToInt32(Console.ReadLine());
//if (a % 2 == 0)
//Console.Write($"Да");
//else
//Console.Write($"Нет");

//int numberA = new Random().Next(1,10);
//Console.WriteLine(numberA);
//int numberB = new Random().Next(1,10);
//Console.WriteLine(numberB);
//int result = numberA + numberB;
//Console.WriteLine(result);

//double numberA = 12;
//double numberB = 5;
//double result = numberA / numberB;
//Console.WriteLine(result);

//Console.Write("Введите имя пользователя");
//string username = Console.ReadLine();

//if (username.ToLower() == "маша")
//{
//  Console.WriteLine("Ура это же Маша");
//}
//else
//{
//  Console.Write("Привет холоп");
//  Console.WriteLine(username);
//}

//int a = 1;
//int b = 2;
//int c = 6;
//int d = 8;
//int e = 4;
//int max = a;
//if (a > max) max = a;
//if (b > max) max = b;
//if (c > max) max = c;
//if (d > max) max = d;
//if (e > max) max = e;
//Console.Write("MAX = ");
//Console.WriteLine(max);

//Console.Clear();
//Console.SetCursorPosition(10, 4);/////
//Console.WriteLine("+");////
//int xa = 40;
//int ya = 1;
//int xb = 1;
//int yb = 30;
//int xc = 60;
//int yc = 30;
//Console.SetCursorPosition(xa, ya);
//Console.WriteLine("+");
//Console.SetCursorPosition(xb, yb);
//Console.WriteLine("+");
//Console.SetCursorPosition(xc, yc);
//Console.WriteLine("+");
//int x = xa, y = xb;
//int count = 0;
//while(count < 10000)
//{
  //int what = new Random().Next(0, 3);
  //if (what == 0)
  //{
  //  x = (x + xa) / 2;
  //  y = (y + ya) / 2;
  //}
  //if (what == 1)
 // {
 //   x = (x + xb) / 2;
 //   y = (y + yb) / 2;
 // }
 // if (what == 2)
 // {
 //   x = (x + xc) / 2;
 //   y = (y + yc) / 2;
 // }
 // Console.SetCursorPosition(x, y);
 // Console.WriteLine("+");
 // count++;
//}


//STIHIINI PODHOD
//int a1 = 15;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 23;
//int c2 = 33;
//int a3 = 13;
//int b3 = 23;
//int c3 = 33;
//int max = a1;
//if (b1 > max) max = b1;
//if (c1 > max) max = c1;
//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;
//if (a3 > max) max = a3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3;
//Console.WriteLine(max);

//int Max(int arg1, int arg2, int arg3)
//{
  //int result = arg1;
  //if (arg2 > result) result = arg2;
  //if (arg3 > result) result = arg3;
  //return result;
//}
//int a1 = 15;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 555;
//int c2 = 33;
//int a3 = 13;
//int b3 = 2233;
//int c3 = 33;
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);
//Console.WriteLine(max);

//int Max(int arg1, int arg2, int arg3)
//{
  //int result = arg1;
  //if (arg2 > result) result = arg2;
  //if (arg3 > result) result = arg3;
  //return result;
//}
//int a1 = 15;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 555;
//int c2 = 33;
//int a3 = 13;
//int b3 = 2233;
//int c3 = 33;
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);
//Console.WriteLine(max);


//int Max(int arg1, int arg2, int arg3)
//{
//  int result = arg1;
//  if (arg2 > result) result = arg2;
//  if (arg3 > result) result = arg3;
//  return result;
//}
//int[] array = {11, 21, 22, 34, 45, 54, 43, 123, 313};
//int result = Max(
//  Max(array[0], array[1], array[2]),
//  Max(array[3], array[4], array[5]),
//  Max(array[6], array[7], array[8])
//);
//Console.WriteLine(result);


//int[] array = {1, 2, 3, 15, 5, 6, 7, 8};
//int n = array.Length;
//int find = 7;
//int index = 0;
//while (index < n)
//{
//  if(array[index] == find)
//  {
//    Console.WriteLine(index);
//    break;
//  }
//  index++;
//}
//
//void FillArray(int[] collection)
//{
//int length = collection.Length;
//int index = 0;
//while (index < length)
//  {
//collection[index] = new Random().Next(1, 10);
//index = index + 1;
//  }
//}
//void PrintArray(int[] col)
//{
//  int count = col.Length;
//  int position = 0;
//  while (position < count)
//  {
//    Console.WriteLine(col[position]);
//    position++;
//  }
//}
//int[] array = new int[10];
//FillArray(array);
//PrintArray (array);


//void FillArray(int[] collection)
//{
//int length = collection.Length;
//int index = 0;
//while (index < length)
//  {
//collection[index] = new Random().Next(1, 10);
//index = index + 1;
//  }
//}
//void PrintArray(int[] col)
//{
//  int count = col.Length;
//  int position = 0;
//  while (position < count)
//  {
//    Console.WriteLine(col[position]);
//    position++;
//  }
//}
//int indexOf(int[] collection, int find)
//{
//  int count = collection.Length;
//  int index = 0;
//  int position = 0;
//  while (index < count)
//  {
//    if(collection[index] == find)
//    {
//      position = index;
//      break;
//    }
//    index++;
//  }
//return position;
//}
//int[] array = new int[10];
//FillArray(array);
//PrintArray (array);
//Console.WriteLine();
//int pos = indexOf(array, 4);
//Console.WriteLine(pos);

//int a = 5;
//int b = 3;
//if (a > b)
//{
//  Console.WriteLine(a);
//}
//else
//{
//    Console.WriteLine(b);
//}
//}


//int a = 5;
//while (a < 10)
//{
//   a++;
//  if (a == 8)
//  {
//  continue;
//  Console.WriteLine("111");
//  }
//  Console.WriteLine(a);
//}
//Console.WriteLine("OK");


//int a = 5;
//for (int i = 0; i < 10; i++)
//{
//  if (i == 8 || i == 7)
//  {
//  continue;
//  Console.WriteLine("111");
//  }
//  Console.WriteLine(i);
//}
//Console.WriteLine("OK");

//int a;
//int x = 100;
//int y = -100;
//for (int i = 0; i < 10; i++)
//{
//  a = new Random().Next(y, x);
//Console.WriteLine(a);
//}


//int a;
//int x = 100;
//double y = 100.455454;
//Console.WriteLine(Math.Round(y, 3));

//int a;
//int y;
//int x;
//int max;
//a = new Random().Next(10, 99);
//y = a / 10;
//x = a % 10;
//max = y;
//if (max > x)
//{
//  Console.WriteLine("большее число");
//  Console.WriteLine(max);
//  Console.WriteLine(a);
//}
//else
//{
//  Console.WriteLine("большее число");
//  Console.WriteLine(x);
//  Console.WriteLine(a);
//}


//int a;
//int x;
//int y;
//int z;
//int find;
//a = new Random().Next(99, 1000);
//x = a / 100;
//y = (a - (x * 100)) / 10;
//z = (a % 100) % 10;
//find = x * 10 + z;
//Console.WriteLine(a);
//Console.WriteLine(x);
//Console.WriteLine(y);
//Console.WriteLine(z);
//Console.WriteLine(find);

//int a;
//int b;
//int c;
//a = new Random().Next(0, 100);
//b = new Random().Next(0, 100);
//if (a % b == 0)
//{
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine("Да кратно");
//}
//else
//{
//  c = a % b;
//  Console.WriteLine(c);
//  Console.WriteLine("некратно");
//  Console.WriteLine(a);
//  Console.WriteLine(b);
//}

//int a;
//a = new Random().Next(0, 1000);
//if (a % 7 == 0 && a % 23 == 0)
//{
//  Console.WriteLine(a);
//  Console.WriteLine("да кратно");
//}
//else
//{
//  Console.WriteLine(a);
//  Console.WriteLine("некратно");
//}

//
//int a;
//int x;
//int y;
//int z;
//int find;
//a = new Random().Next(99, 1000);
//x = a / 100;
//y = (a - (x * 100)) / 10;
//z = (a % 100) % 10;
//find = x * 10 + z;
//Console.WriteLine(a);
//Console.WriteLine(y);
//Console.WriteLine("вторя цифра над этой трокой");


//int a;
//int x;
//a = new Random().Next(0, 1000000);
//if (a < 100)
//{
//Console.WriteLine(a);
//Console.WriteLine("третей цифры нет");
//}
//if (a % 100 == 0 || a % 1000 == 0 || a % 10000 == 0 || a % 100000 == 0)
//{
//Console.WriteLine(a);
//Console.WriteLine("третья цифра 0");
//}
//if (a / 100 > 1 && a / 100 < 10)
//{
//x = a % 100 % 10;
//Console.WriteLine(a);
//Console.WriteLine($"третья цифра {x}");
//}
//if (a / 1000 > 1 && a / 1000 < 10)
//{
//x = a % 1000 % 100 / 10;
//Console.WriteLine(a);
//Console.WriteLine($"третья цифра {x}");
//}
//if (a / 10000 > 1 && a / 10000 < 10)
//{
//x = a % 10000 % 1000 / 100;
//Console.WriteLine(a);
//Console.WriteLine($"третья цифра {x}");
//}
//if (a / 100000 > 1 && a / 100000 < 10)
//{
//x = a % 100000 % 10000 / 1000;
//Console.WriteLine(a);
//Console.WriteLine($"третья цифра {x}");
//}

//int a;
//a = new Random().Next(1, 8);
//if (a <= 5)
//{
//  Console.WriteLine(a);
//  Console.WriteLine("Будний день емае!!!");
//}
//else
//{
//Console.WriteLine(a);
//Console.WriteLine("Выходной КАЙФУЕМ");
//}

// ВИД метода 1
//void Method1()
//{
//  Console.WriteLine("AVTOR...");
//}
//Method1();

// Вид метода 2
//void Method2(string msg)
//{
//  Console.WriteLine(msg);
//}
//Method2("Text soobshenia");

// Вид метода 3
//int Method3()
//{
//  return DateTime.Now.Year;
//}
//int Year = Method3();
//Console.WriteLine(Year);

// Вид метода 4
//string Method4(int count, string c)
//{
//  int i = 0;
//  string result = string.Empty;
//  while (i < count)
//  {
//    result = result + c;
//    i++;
//  }
//  return result;
//}
//string res = Method4(10, "WOW");
//Console.WriteLine(res);


// ФОР
//string Method4(int count, string c)
//{
//
//  string result = string.Empty;
//  for (int i = 0; i < count; i++)
//  {
//    result = result + c;
//  }
//  return result;
//}
//string res = Method4(10, "WOW");
//Console.WriteLine(res);

//for (int i = 2; i <= 10; i++)
//{
//  for (int j = 2; j <= 10; j++)
//  {
//    Console.WriteLine($"{i} * {j} = {i *j}");
//  }
//  Console.WriteLine();
//}




//string text = " Я думаю, – сказал князь, улыбаясь, – что, "
//+"ежели бы вас послали вместо нашего милого Винценгероде, "
//+ "вы бы взяли приступом согласие прусского короля. "
//+ "Вы так красноречивы. Вы дадите мне чаю?";

//string Replace(string text, char oldValue, char newValue)
//{
//  string result = String.Empty;

//  int length = text.Length;
//  for (int i = 0; i < length; i++)
//  {
//    if(text[i] == oldValue) result = result + $"{newValue}";
//    else result = result + $"{text[i]}";
//  }
//  return result;
//}
//string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(newText, 'к', 'К');
//Console.WriteLine(newText);





//int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
//void PrintArray(int[] array)
//{
//  int count = array.Length;
//
//  for (int i = 0; i < count; i++)
//  {
//    Console.Write($"{array[i]}");
//  }
//  Console.WriteLine();
//}
//void SelectionSort(int[] array)
//{
//  for (int i = 0; i < array.Length - 1 ; i++)
//  {
//    int minPosition = i;
//    for (int j = i + 1; j < array.Length; j++)
//    {
//      if(array[j] < array[minPosition]) minPosition = j;
//    }
//{
//  
//}
//
//    int temporary = array[i];
//    array[i] = array[minPosition];
//    array[minPosition] = temporary;
//  }
//}
//PrintArray(arr);
//SelectionSort(arr);
//
//PrintArray(arr);







//             spisok druzei
//string f1 = "Anna";
//string f2 = "BOB";
//string f3 = "ALEX";
//string f4 = "IRA";
//string f5 = "MILA";

//              string[] f;

//string[] f = {f1, f2, f3, f4, f5};

//                int[] num;
//                Int[] num = new int[5];
//int[] num = {5, 3, 7, 1, 9};

//Console.WriteLine(f[4]);
//Console.WriteLine(f[1]);

//f[1] = "Rpman";
//Console.WriteLine(f[1]);
//
//Console.WriteLine(f.Length);
//
//for (int i = 0; i < f.Length; i++)
//{
//  Console.WriteLine(f[i]);
//}
//Console.WriteLine(f.Length);

//foreach (string n in f)
//{
//  if (n != "IRA")
//    Console.WriteLine(n);
//}


//double num = Math.Sqrt(x); //kvadratnii koren
//double num = Math.Pow(x, 3); //Stepen



//ZAdacha 1
//Console.Write("Введите X: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите y: ");
//int y = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Координаты Х = {x} У = {y}");
//if(x != 0 || y != 0)
//{ 
//if(x > 0 && y > 0)
//{
//  Console.WriteLine($"Четверть 1");
//}
//if(x < 0 && y > 0)
//{
//  Console.WriteLine($"Четверть 2");
//}
//if(x < 0 && y < 0)
//{
//  Console.WriteLine($"Четверть 3");
//}
//if(x > 0 && y < 0)
//{
//  Console.WriteLine($"Четверть 4");
//}
//}
//else
//{
//Console.WriteLine($"Перезапустите");
//}




//ZADACHA 2
//Console.Write("Введите четверть: ");
//int a = Convert.ToInt32(Console.ReadLine());
//if (a < 2)
//{
//  int x = new Random().Next(1, 100);
//  int y = new Random().Next(1, 100);
//  Console.WriteLine(a);
//  Console.WriteLine($"Координаты Х = {x} У = {y}");
//}
//if (a < 3 && a > 1)
//{
//  int x = new Random().Next(-100, -1);
//  int y = new Random().Next(-100, -1);
//  Console.WriteLine(a);
//  Console.WriteLine($"Координаты Х = {x} У = {y}");
//}
//if (a < 4 && a > 2)
//{
//  int x = new Random().Next(1, 100);
//  int y = new Random().Next(-100, -1);
//  Console.WriteLine(a);
//  Console.WriteLine($"Координаты Х = {x} У = {y}");
//}
//if (a > 3)
//{
//  int x = new Random().Next(-100, -1);
//  int y = new Random().Next(1, 100);
//  Console.WriteLine(a);
//  Console.WriteLine($"Координаты Х = {x} У = {y}");
//}


//Zadacha 3
//Console.Write("Введите координаты для первой точки A: ");
//double x1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите координаты для первой Второй точки A: ");
//double y1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Координаты A ({x1} ; {y1})");
//Console.Write("Введите координаты для первой точки B: ");
//double x2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите координаты для первой Второй точки B: ");
//double y2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Координаты B ({x2} ; {y2})");
//Console.WriteLine("Данные приняты");
//Console.WriteLine($"Координаты двух точек A ({x1} ; {y2}) и B ({x2} ; {y2})");
//Console.WriteLine("расстоянние между точками");
//double numx = Math.Pow((x1 - x2), 2);
//double numy = Math.Pow((y1 - y2), 2);
//double numxy = numx - numy;
//double result = Math.Sqrt(numxy);
//Console.WriteLine($"{result}");


//Zadacha 4
//Console.Write("Введите число: ");
//int N = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < N; i++)
//{
//  Console.WriteLine(Math.Pow((i), 2));
//}

//Domashnee zadanie
//ZADANIE 1
//Console.Write("Введите пятизначное число: ");
//double x = 12321; //Convert.ToInt32(Console.ReadLine())
//double a = (x - (x % 10000))/10000;
//double b = ((x - a*10000) - ((x - a*10000) % 1000))/1000;
//double c = Math.Truncate((x - (a * 10000 + b * 1000))/100);
//double d = Math.Truncate((x - (a * 10000 + b * 1000))/10 - c * 10);
//double e = (x % 10000 % 1000 % 100 % 10);
//double aa = Math.Pow(a, 2);
//double bb = Math.Pow(b, 2);
//if (aa == a * e && bb == b * d)
//{
//Console.WriteLine($"Данное число полиндром");
//Console.WriteLine(x);
//}
//else
//{
//Console.WriteLine($"Данное число не зеркальное");
//Console.WriteLine(x);
//}


//ZADANIE 2
//Console.Write("Введите координаты для первой точки A: ");
//double x1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите координаты для второй точки A: ");
//double y1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите координаты для третьей точки A: ");
//double z1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Координаты A ({x1} ; {y1}; {z1})");
//Console.Write("Введите координаты для первой точки B: ");
//double x2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите координаты для второй точки B: ");
//double y2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите координаты для третьей точки B: ");
//double z2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Координаты B ({x2} ; {y2}; {z2})");
//Console.WriteLine("Данные приняты");
//Console.WriteLine($"Координаты двух точек A ({x1} ; {y1}; {z1}) и B ({x2} ; {y2}; {z2})");
//Console.WriteLine("расстоянние между точками");
//double result = Math.Sqrt(Math.Pow((x1 - x2), 2)+ Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
//Console.WriteLine($"{result}");

//ZADANIE 3
//Console.Write("Введите число: ");
//int N = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i < N + 1; i++)
//{
//  Console.WriteLine(Math.Pow((i), 3));
//}

//SEMINAR4

//void SayLang()//METOD
//{
//  Console.WriteLine("HELLO python");
//}

//SayLang();

//SayLang();

//SayLang();

//SayLang();

//SayLang();


//void SayLang(string lang)//METOD
//{
//  Console.WriteLine($"HELLO {lang}");
//}
//SayLang("C#");
//string lang1 = "JavaScript";
//SayLang(lang1);
//SayLang("PHP");
//SayLang("C++");
//SayLang("Python");




//int SumNum(int numA, int numB)
//{
//  if (numA > numB)
//  {
//  int result = numA - numB;
//  return result;
//  }
//  else
//  {
//  int result = numB - numA;
//  return result;
//  }
//}
//int x = SumNum(2, 3);
//Console.WriteLine(x);
//int y = SumNum(7, 4);
//Console.WriteLine(y);

// 24 zadacha
//Console.Write("Введите число: ");
//double N = Convert.ToInt32(Console.ReadLine());
//int result = 1;
//for (int i = 2; i < N + 1; i++)
//{
//  result = result + i;
//}
//Console.Write($"{result}");

// 26 zadacha
//Console.Write("Введите число: ");
//int x = Convert.ToInt32(Console.ReadLine());
//if (x >= 1 && x < 10)
//{
//Console.WriteLine(1);
//}
//if (x >= 10 && x < 100)
//{
//Console.WriteLine(2);
//}
//if (x >= 100 && x < 1000)
//{
//Console.WriteLine(3);
//}
//if (x >= 1000 && x < 10000)
//{
//Console.WriteLine(4);
//}
//if (x >= 10000 && x < 100000)
//{
//Console.WriteLine(5);
//}

// 28 zadacha
//Console.Write("Введите число: ");
//int x = Convert.ToInt32(Console.ReadLine());
//int result = 1;
//for (int i = 1; i < x + 1; i++)
//{
//  result = result * i;
//}
//Console.WriteLine(result);

//ZAdacha 30

//int [] array = new int[8];
//Console.WriteLine($"Длинна массива = {array.Length}");
//  for (int i = 0; i < array.Length; i++)
//  {
//    array[i] = new Random().Next(0, 2);
//    Console.Write($"{array[i]}");
//  }


//int Function(int numA, int numB)
//{
//  int result = 1;
//  for (int i = 0; i <numB; i++)
//  {
//    result = result * numA;
//  }
//  return result;
//}
//Console.WriteLine("Введите два числа ");
//int numA = Convert.ToInt32(Console.ReadLine());
//int numB = Convert.ToInt32(Console.ReadLine());
//Function(numA, numB);
//Console.WriteLine(Function(numA, numB));





//int Function(int numA)
//{
//  int result = 0;
//  while (numA > 0)
//  {
//    result += numA % 10;
//    numA = numA / 10;
//  }
//  return result;
//}
//Console.WriteLine("Введите число");
//int numA = Convert.ToInt32(Console.ReadLine());
//Function(numA);
//Console.WriteLine(Function(numA));


//int [] array = new int[8];
//Console.WriteLine($"Длинна массива = {array.Length}");
//  for (int i = 0; i < array.Length; i++)
//  {
//    array[i] = new Random().Next(-100, 100);
//    Console.Write($"{array[i]} ,");
//  }




//ЛЕКЦИЯ 4
//String[,] table = new string[2, 5];
//table[1, 2] = "SLOVO";
//for (int rows = 0; rows < 2; rows++)
//{
//  for (int columns = 0; columns < 5; columns++)
//  {
//    Console.WriteLine($"-{table[rows, columns]}-");
//  }
//}





//int[,] imageix = new int[3, 4];
//void PrintArray(int[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//  {
//    for (int j = 0; j <  imageix.GetLength(1); j++)
//    {
//      Console.Write($"{imageix[i, j]} ");
//    }
//  Console.WriteLine();
//}
//}
//void FillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//   for (int j = 0; j < image.GetLength(1); j++)
//   {
//    image[i,j] = new Random().Next(1,10);
//   } 
//  }
//}
//PrintArray(imageix);
//FillArray(imageix);
//Console.WriteLine();
//PrintArray(imageix);

















//int[,] pic = new int[,]
//{
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
//{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
//{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//};
//void PrintImage(int[,] image)
//{
//for (int i = 0; i < image.GetLength(0); i++)
//  {
//    for (int j = 0; j <  image.GetLength(1); j++)
//    {
//      //Console.Write($"{image[i, j]} ");
//      if(image[i,j] == 0) Console.Write($" ");
//      else Console.Write($"+");
//    }
//    Console.WriteLine();
//}
//}
//void FillImage(int row, int col)
//{
//  if(pic[row, col] == 0)
//  {
//    pic[row, col] = 1;
//    FillImage(row-1,col);
//    FillImage(row,col - 1);
//    FillImage(row+1,col);
//    FillImage(row,col+1);
//  }
//}
//
//PrintImage(pic);
//FillImage(13,13);
//PrintImage(pic);







//int Factorial (int n)
//{
//  if (n == 1) return 1;
//  else return n * Factorial(n - 1);
//}
//Console.WriteLine(Factorial(3));






//double Factorial (int n)
//{
//  if (n == 1) return 1;
//  else return n * Factorial(n - 1);
//}
//for (int i = 1; i < 40; i++)
//{
//  Console.WriteLine($"{i}! = {Factorial(i)}");
//}


//REKURSIA
//double Fibonacci(int n)
//{
//  if (n == 1 || n == 2) return 1;
//  else return Fibonacci(n - 1) + Fibonacci(n - 2);
//}
//
//for (int i = 1; i < 50; i++)
//{
//  Console.WriteLine($"f({i}) = {Fibonacci(i)}");
//}

//SEMINAR
//string s = "Hello World";
//Console.WriteLine(s[6]);

//string s = "Hello World";
//string s1 = "Hello";
//string s2 = "World";
//string s3 = s1 + s2;
//Console.WriteLine(s3);

//string s = "Hello World";
//string s1 = "Hello";
//string s2 = "World";
//string s3 = s1 + s2;
//string s4 = string.Concat(s1, s2);
//Console.WriteLine(s4);


//string s = "Hello World";
//string s1 = "Hello";
//string s2 = "World";
//int [] nums = {1, 2, 3, 4, 5};
//string s3 = s1 + s2;
//string s4 = string.Concat(s1, s2);
//string s5 = string.Join("-", nums);
//Console.WriteLine(s5);


//string s = "Hello World";
//string s1 = "Hello";
//string s2 = "World";
//int [] nums = {1, 2, 3, 4, 5};
//string s3 = s1 + s2;
//string s4 = string.Concat(s1, s2);
//string s5 = string.Join(" ", nums);


//string s = "1, 2, 3, 4, 5, 6, 7";
//foreach (var item in s)
//{
//  Console.WriteLine(item);
//}
//Console.WriteLine(s5);


//string s = "1, 2, 3, 4, 5, 6, 7.";
//string[] nums = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
//int[] n = nums.Select(Int32.Parse).ToArray();
//foreach (var item in nums)
//{
//  Console.WriteLine(item);
//}


//string s = "1, 2, 3, 4, 5, 6, 7.";
//string[] nums = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
//int[] n = nums.Select(Int32.Parse).ToArray();
//foreach (var item in nums)
//{
//  Console.WriteLine(item);
//}
//string s1 = "10 21 35 45 57 61 78";
//int[] num1 = Array.ConvertAll(s1.Split(), int.Parse);
//s[0] == s[4] && s[1] == s[3]



//string s = "SDAdasYDASDYDASdasSADYY";
//string[] nums = s.Split(new char[]{'Y'}, StringSplitOptions.RemoveEmptyEntries);
//foreach (var item in nums)
//{
//  Console.WriteLine(item);
//}


//ZADCHI
//int [] array = new int[12];
//Console.WriteLine($"Длинна массива = {array.Length}");
//int resultA = 0;
//int resultB =0;
//  for (int i = 0; i < array.Length; i++)
//  {
//    array[i] = new Random().Next(-9, 9);
//    Console.Write($"{array[i]} ,"
//    );
//  }
//  for (int i = 0; i < array.Length; i++)
//  {
//    if (array[i] > 0)
//    {
//    resultA = resultA + array[i];
//    }
//    else
//    resultB = resultB + array[i];
//  }
//Console.Write($"Сумма положительных {resultA} ");
//Console.Write($"Сумма отрицательных {resultB} ");


//int [] array = new int[4];
//Console.WriteLine($"Длинна массива = {array.Length}");
//  for (int i = 0; i < array.Length; i++)
//  {
//    array[i] = new Random().Next(-4, 4);
//    Console.Write($"{array[i]} ,");
//  }
//  Console.Write("Или");
//  for (int i = 0; i < array.Length; i++)
//  {
//    if (array[i] >= 0)
//    {
//    array[i] = array[i] *-1;
//    Console.Write($"{array[i]}, ");
//    }
//    else
//    {
//    array[i] = array[i] *-1;
//    Console.Write($"{array[i]}, ");
//    }
//  }



//int [] array = new int[4];
//Console.WriteLine($"Длинна массива = {array.Length}");
//  for (int i = 0; i < array.Length; i++)
//  {
//    array[i] = new Random().Next(-4, 4);
//    Console.Write($"{array[i]} ,");
//  }
//Console.WriteLine("Введите число");
//int numA = Convert.ToInt32(Console.ReadLine());
//  for (int i = 0; i < array.Length; i++)
//  {
//    if (numA == array[i])
//    {
//      Console.WriteLine($"есть число {numA} ");
//      break;
//    }
//    else
//    {
//      Console.WriteLine($"данного числа нет {numA} ");
//    }
//  }
 


//double [] array = new double[4];
//int count = 0;
//Console.WriteLine($"Длинна массива = {array.Length}");
//  for (int i = 0; i < array.Length; i++)
//  {
//    array[i] = new Random().Next(99, 1000);
//    Console.Write($"{array[i]} ,");
//  }
//for (int i = 0; i < array.Length; i++)
//   {
//    if (array[i] % 2 == 0)
//     count = count + 1;
//   }
//Console.Write($"{count} ,");



//int [] array = new int[4];
//int result = 0;
//Console.WriteLine($"Длинна массива = {array.Length}");
//  for (int i = 0; i < array.Length; i++)
//  {
//    array[i] = new Random().Next(99, 1000);
//    Console.Write($"{array[i]} ,");
//  }
//for (int i = 0; i < array.Length; i++)
//   {
//    if (i % 2 > 0)
//     result = result + array[i];
//   }
//Console.Write($"резульат сложения {result} ,");


//int [] array = new int[8];
//Console.WriteLine($"Длинна массива = {array.Length}");
//for (int i = 0; i < array.Length; i++)
//{
//array[i] = new Random().Next(0, 100);
//Console.Write($"{array[i]} ,");
//}
//int min = array[0];
//int max = array[0];
//  for (int i = 0; i < array.Length; i++)
//   {
//    if (array[i] > max)
//    {
//     max = array[i];
//    }
//    if(array[i] < min)
//    {
//    min = array[i];
//    }
//   }
//int result = max - min;
//Console.Write($" MAX {max}");
//Console.Write($" MIN {min}");
//Console.Write($" Разница между элиментами {result}");


//int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9};
//foreach (var item in nums)
//{
//  Console.WriteLine(item);
//}


//int[,] nums2 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9},{0, 4, 2}};
//int[,] nums3 = new int[4,3];
//foreach (var item in nums2)
//{
//  Console.WriteLine(item);
//}



//int[,] nums2 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9},{0, 4, 2}};
//for (int i = 0; i < nums2.GetLength(0); i++)
//{
//  Console.WriteLine(nums2[i,0]);
//}


//int[,] nums2 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9},{0, 4, 2}};
//for (int i = 0; i < nums2.GetLength(0); i++)
//{
//  for (int j = 0; j < nums2.GetLength(1); j++)
//  {
//    Console.Write($"{nums2[i, j]} ");
//  }
//  Console.WriteLine();
//}





//int [] array = new int[4];
//int [] arrayNEW = new int[4];
//Console.WriteLine($"Длинна массива = {array.Length}");
//for (int i = 0; i < array.Length; i++)
//{
//array[i] = new Random().Next(0, 10);
//Console.Write($"{array[i]} ,");
//}
//Console.Write("переворот");
//for (int i = 0; i < array.Length; i++)
//{
//  arrayNEW[i] = array[(array.Length - 1) -i];
//  Console.Write($"{arrayNEW[i]} ,");
//}


//Console.Write("Введите число: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число: ");
//int y = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число: ");
//int z = Convert.ToInt32(Console.ReadLine());
//{
//  if (x + y > z)
//  {
//    if (x + z > y)
//    {
//      if (y + z > x)
//      {
//        Console.Write("Да может существовать");
//        
//      }
//    }
//  }
//  else
//  {
//    Console.Write("Неможет существовать");
//  }
//}


//Console.WriteLine("Введите число:");
//int num = Convert.ToInt32(Console.ReadLine());
//String result = "";
//while (num > 0)
//{
//  result = Convert.ToString(num % 2) + result;
//  num /= 2;
//}
//Console.WriteLine(result);







//Console.WriteLine("Введите длинну массива:");
//int [] array = new int[Convert.ToInt32(Console.ReadLine())];
//int result = 0;
//Console.WriteLine("Введите число массива:");
//for (int i = 0; i < array.Length; i++)
//{
//  array[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("массив создан: ");
//for (int i = 0; i < array.Length; i++)
//{
//  Console.Write($"{array[i]} ,");
//}
//for (int i = 0; i < array.Length; i++)
//{
//  if (array[i] > 0)
//  {
//    result = result + 1;
//  }
//}
//Console.Write("Ответ:");
//Console.Write(result);


//Console.WriteLine("Задайте координаты прямой a:");
//double k1 = Convert.ToInt32(Console.ReadLine());
//double b1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Задайте координаты прямой b:");
//double k2 = Convert.ToInt32(Console.ReadLine());
//double b2 = Convert.ToInt32(Console.ReadLine());
//double x = - (b2 - b1)/(k2 - k1);
//double y = k2 * x + b2;
//Console.WriteLine("Точки");
//Console.WriteLine($"({x} ; {y})");

// ZAFACH 46
//int[,] imageix = new int[3, 4];
//void PrintArray(int[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//  {
//    for (int j = 0; j <  imageix.GetLength(1); j++)
//    {
//      Console.Write($"{imageix[i, j]} ");
//    }
//  Console.WriteLine();
//}
//}
//void FillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//   for (int j = 0; j < image.GetLength(1); j++)
//   {
//    image[i,j] = new Random().Next(-100,100);
//   } 
//  }
//}
//PrintArray(imageix);
//FillArray(imageix);
//Console.WriteLine();
//PrintArray(imageix);




// ZAFACH 48
//int[,] imageix = new int[3, 4];
//void PrintArray(int[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//  {
//    for (int j = 0; j <  imageix.GetLength(1); j++)
//    {
//      Console.Write($"{imageix[i, j]} ");
//    }
//  Console.WriteLine();
//}
//}
//void FillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//   for (int j = 0; j < image.GetLength(1); j++)
//   {
//    image[i,j] = j + i;
//   } 
//  }
//}
//PrintArray(imageix);
//FillArray(imageix);
//Console.WriteLine();
//PrintArray(imageix);





// ZAFACH 49
//int[,] imageix = new int[3, 4];
//void PrintArray(int[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//  {
//    for (int j = 0; j <  imageix.GetLength(1); j++)
//    {
//      Console.Write($"{imageix[i, j]} ");
//    }
//  Console.WriteLine();
//}
//}
//void FillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//   for (int j = 0; j < image.GetLength(1); j++)
//   {
//    image[i,j] = new Random().Next(1,10);
//   } 
//  }
//}
//void RefillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i = i + 1)
//  {
//   for (int j = 0; j < image.GetLength(1); j = j + 1)
//   {
//    if (i % 2 != 0 && j % 2 != 0)
//    image[i,j] =  image[i,j] *  image[i,j];
//   } 
//  }
//}
//PrintArray(imageix);
//Console.WriteLine();
//FillArray(imageix);
//PrintArray(imageix);
//Console.WriteLine();
//RefillArray(imageix);
//PrintArray(imageix);
//Console.WriteLine();



//ZAFACH 51
//int[,] imageix = new int[3, 4];
//void PrintArray(int[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//  {
//    for (int j = 0; j <  imageix.GetLength(1); j++)
//    {
//      Console.Write($"{imageix[i, j]} ");
//    }
//  Console.WriteLine();
//}
//}
//void FillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//   for (int j = 0; j < image.GetLength(1); j++)
//   {
//    image[i,j] = new Random().Next(1,10);
//   } 
//  }
//}
//int result = 0;
//void RefillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i = i + 1)
//  {
//   for (int j = 0; j < image.GetLength(1); j = j + 1)
//   {
//    if (j == i)
//    result = result + image[i,j];
//   } 
//  }
//}
//PrintArray(imageix);
//Console.WriteLine();
//FillArray(imageix);
//PrintArray(imageix);
//Console.WriteLine();
//RefillArray(imageix);
//PrintArray(imageix);
//Console.WriteLine();
//Console.WriteLine(result);










//ZADACHa 47
//double[,] imageix = new double[3, 4];
//void PrintArray(double[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//  {
//    for (int j = 0; j <  imageix.GetLength(1); j++)
//    {
//      Console.Write($"{imageix[i, j]} ");
//    }
//  Console.WriteLine();
//}
//}
//void FillArray(double[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//   for (int j = 0; j < image.GetLength(1); j++)
//   {
//    image[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//   } 
//  }
//}
//PrintArray(imageix);
//Console.WriteLine();
//FillArray(imageix);
//PrintArray(imageix);
//Console.WriteLine();



//Zadacha 50
//int[,] imageix = new int[3, 4];
//void PrintArray(int[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//  {
//    for (int j = 0; j <  imageix.GetLength(1); j++)
//    {
//      Console.Write($"{imageix[i, j]} ");
//    }
//  Console.WriteLine();
//}
//}
//void FillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//   for (int j = 0; j < image.GetLength(1); j++)
//   {
//    image[i,j] = new Random().Next(-10, 10);
//   } 
//  }
//}
//void FindNum(int[,] image)
//{
//Console.WriteLine("введите номер строки");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите номер столбца");
//int m = Convert.ToInt32(Console.ReadLine());
//if (n >  imageix.GetLength(0) || m >  imageix.GetLength(1))
//{
//    Console.WriteLine("такого элемента нет");
//}
//else
//{
//    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно { imageix[n-1,m-1]}");
//}
//}
//PrintArray(imageix);
//Console.WriteLine();
//FillArray(imageix);
//PrintArray(imageix);
//Console.WriteLine();
//FindNum(imageix);


//Zadacha 52
//Console.WriteLine("введите количество строк");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите количество столбцов");
//int y = Convert.ToInt32(Console.ReadLine());
//int[,] imageix = new int[x, y];
//void PrintArray(int[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//  {
//    for (int j = 0; j <  imageix.GetLength(1); j++)
//    {
//      Console.Write($"{imageix[i, j]} ");
//    }
//  Console.WriteLine();
//}
//}
//void FillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//   for (int j = 0; j < image.GetLength(1); j++)
//   {
//    image[i,j] = new Random().Next(1, 10);
//   } 
//  }
//}
//void FindResult(int[,] image)
//{
//  for (int j = 0; j < imageix.GetLength(1); j++)
//{
//    double avarage = 0;
//    for (int i = 0; i < imageix.GetLength(0); i++)
//    {
//        avarage = (avarage + image[i, j]);
//    }
//    avarage = avarage / x;
//    Console.Write(avarage + "; ");
//}
//}
//PrintArray(imageix);
//Console.WriteLine();
//FillArray(imageix);
//PrintArray(imageix);
//Console.WriteLine();
//FindResult(imageix);





//Console.WriteLine("введите количество строк");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите количество столбцов");
//int y = Convert.ToInt32(Console.ReadLine());
//int[,] imageix = new int[x, y];
//void PrintArray(int[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//  {
//    for (int j = 0; j <  imageix.GetLength(1); j++)
//    {
//      Console.Write($"{imageix[i, j]} ");
//    }
//  Console.WriteLine();
//}
//}
//void FillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//   for (int j = 0; j < image.GetLength(1); j++)
//   {
//    image[i,j] = new Random().Next(1, 10);
//   } 
//  }
//}
//void ChangeResult(int[,] image)
//{
//for(int i = 0; i < image.GetLength(1); i++)
 //{
 // var tmp = imageix[x - 1, i];
 // imageix[x  - 1, i] = imageix[0, i];
//  imageix[0, i] = tmp;
//    }
//    for(int i = 0; i < image.GetLength(0); i++)
//     {
//      for(int j = 0; j < image.GetLength(1); j++)
//        {
//        Console.Write(image[i,j] + " ");
//        }
//        Console.WriteLine();
//      }
// Console.ReadKey(true);
//}
//PrintArray(imageix);
//Console.WriteLine();
//FillArray(imageix);
//PrintArray(imageix);
//Console.WriteLine();
//ChangeResult(imageix);



    //int[,] someArray = new int[5, 5];
    //int rows = someArray.GetUpperBound(0) + 1;
    //int columns = someArray.GetUpperBound(1) + 1;
    //Random rand = new Random();
    //for (int i = 0; i < rows; i++)
    //{
    //    for (int j = 0; j < columns; j++)
    //    {
    //        someArray[i, j] = rand.Next(1, 10);
    //        Console.Write("{0,4}", someArray[i, j]);
    //    }
    //    Console.WriteLine();
    //}
    //for (int i = 0; i < columns; i++)
    //{
    //    int tmp = someArray[1,  i];
    //    someArray[1, i] = someArray[3, i];
    //    someArray[3, i] = tmp;
    //}
    //for (int i = 0; i < rows; i++)
    //{
    //    int tmp = someArray[i, 2];
    //    someArray[i, 2] = someArray[i, columns - 1];
    //    someArray[i, columns - 1] = tmp;
    //}
    //Console.WriteLine("Transformed array: ");
    //for (int i = 0; i < rows; i++)
    //{
    //    for (int j = 0; j < columns; j++)
    //   {
    //        Console.Write("{0,4}", someArray[i, j]);
    //    }
    //    Console.WriteLine();
    //}
//Console.WriteLine();







// ДЗ
//Console.WriteLine("введите количество строк");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите количество столбцов");
//int y = Convert.ToInt32(Console.ReadLine());
//int[,] imageix = new int[x, y];
//void PrintArray(int[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//  {
//    for (int j = 0; j <  imageix.GetLength(1); j++)
//    {
//      Console.Write($"{imageix[i, j]} ");
//    }
//  Console.WriteLine();
//}
//}
//void FillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//   for (int j = 0; j < image.GetLength(1); j++)
//   {
//    image[i,j] = new Random().Next(1, 10);
//   } 
//  }
//}
//void FiltrResult(int[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//{
//    for (int j = 0; j < imageix.GetLength(1) - 1; j++)
//    {
//        for (int k = 0; k < imageix.GetLength(1) - 1; k++)
//        {
//            if (imageix[i, k] < imageix[i, k + 1])
//            {
//                int temp = 0;
//                temp = imageix[i, k];
//                imageix[i, k] = imageix[i, k + 1];
//                imageix[i, k + 1] = temp;
//            }
//        }
//    }
//}
//}
//PrintArray(imageix);
//Console.WriteLine();
//FillArray(imageix);
//PrintArray(imageix);
//Console.WriteLine();
//FiltrResult(imageix);
//PrintArray(imageix);
//Console.WriteLine();



//DOMASHKA
//Console.WriteLine("введите количество строк");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите количество столбцов");
//int y = Convert.ToInt32(Console.ReadLine());
//int[,] imageix = new int[x, y];
//PrintArray(imageix);
//Console.WriteLine();
//FillArray(imageix);
//Console.WriteLine();
//PrintArray(imageix);
//Console.WriteLine();
//void PrintArray(int[,] image)
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//  {
//    for (int j = 0; j <  imageix.GetLength(1); j++)
//    {
//      Console.Write($"{imageix[i, j]} ");
//    }
//  Console.WriteLine();
//}
//}
//void FillArray(int[,] image)
//{
//  for (int i = 0; i < image.GetLength(0); i++)
//  {
//   for (int j = 0; j < image.GetLength(1); j++)
//   {
//    image[i,j] = new Random().Next(1, 10);
//   } 
//  }
//}
//int minsum = Int32.MaxValue;
//int ind = 0;
//{
//for (int i = 0; i < imageix.GetLength(0); i++)
//{
//    int sum = 0;
//    for (int j = 0; j < imageix.GetLength(1); j++)
//    {
//        sum = sum + imageix[i, j];        
//    }
//    if (sum < minsum)
//    {
//        minsum = sum;
//        ind++;
//    }
//}
//Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (ind) + ", с суммой елементов равной: " + (minsum));
//}


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//DOMASHKA



//int InputInt(string output)
//{
//    Console.Write(output);
//    return int.Parse(Console.ReadLine());
//}
//void FillArrayRandomNumbers(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = new Random().Next(1, 3); 
//        }
//    }
//}
//
//void PrintArray(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write(array[i, j] + " ");
//        }
//        Console.WriteLine("");
//    }
//}
//
//int size = InputInt("размерность матриц: ");
//int[,] matrixA = new int[size, size];
//int[,] matrixB = new int[size, size];
//FillArrayRandomNumbers(matrixA);
//FillArrayRandomNumbers(matrixB);
//int[,] matrixC = new int[size, size];
//
//for (int i = 0; i < size; i++)
//{
//    for (int j = 0; j < size; j++)
//    {
//        for (int k = 0; k < size; k++)
//        {
//            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
//        }
//    }
//}
//Console.WriteLine("А");
//PrintArray(matrixA);
//Console.WriteLine();
//Console.WriteLine("В");
//PrintArray(matrixB);
//Console.WriteLine();
//Console.WriteLine("А*В");
//PrintArray(matrixC);



//int x = InputInt("A: ");
//int y = InputInt("B: ");
//int z = InputInt("C: ");
//int Gangsta = 99;
//if (z * y * z > Gangsta)
//{
//    Console.Write("НЕРЕАЛЬНО");
//    return;
//}
//int[,,] resultNums = Create3DMassive(x, y, z);
//for (int i = 0; i < resultNums.GetLength(0); i++)
//{
//    for (int j = 0; j < resultNums.GetLength(1); j++)
//    {
//        for (int k = 0; k < resultNums.GetLength(2); k++)
//        {
//            Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
//int[,,] Create3DMassive(int size1, int size2, int size3)
//{
//    int[,,] array = new int[size1, size2, size3];
//    int[] values = new int[Gangsta];
//    int num = 10;
//    for (int i = 0; i < values.Length; i++)
//        values[i] = num
//        ++;
//    for (int i = 0; i < values.Length; i++)
//    {
//        int randomInd = new Random().Next(0, values.Length);
//        int temp = values[i];
//        values[i] = values[randomInd];
//        values[randomInd] = temp;
//    }
//    int valueIndex = 0;
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            for (int k = 0; k < array.GetLength(2); k++)
//            {
//                array[i, j, k] = values[valueIndex++];
//            }
//        }
//    }
//    return array;
//}
//int InputInt(string output)
//{
//    Console.Write(output);
//    return int.Parse(Console.ReadLine());
//}





//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("Размер змея");
int size = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[size, size];
int num = 1;
int i = 0;
int j = 0;
while (num <= size * size)
{
   nums[i, j] = num;
   if (i <= j + 1 && i + j < size - 1)
       ++j;
   else if (i < j && i + j >= size - 1)
       ++i;
   else if (i >= j && i + j > size - 1)
       --j;
   else
       --i;
   ++num;
}
PrintArray(nums);
void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
       for (int j = 0; j < array.GetLength(1); j++)
       {
           Console.Write(array[i, j] + " ");
       }
       Console.WriteLine("");
   }
}


//int Fact(int num)
//{
//    if (num ==1)
//        return 1;
//    return num * Fact(num - 1);
//}
//Console.WriteLine(Fact(5));
//Convert.ToInt32(Console.ReadLine());




//Console.WriteLine("Введите значение N: ");
//int num = Convert.ToInt32(Console.ReadLine());
//void Fact(int num)
//{
//    if (num == 1)
//    {
//        Console.Write($"{num} ");
//    }
//    else
//    {
//    Fact(num - 1);
//    Console.Write($"{num} ");
//    }
// 
//}
//Fact(num);





//Console.WriteLine("Введите число");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число");
//int num2 = Convert.ToInt32(Console.ReadLine());
//void Count(int num2, int num1)
//{
//
//if (num2 == num1)
//{
//Console.Write($"{num1} ");
//}
//else
//{
//
//Count(num2 - 1, num1);
//Console.Write($"{num2} ");
//}
//}
//Count(num2,num1);






//Console.WriteLine("Введите число");
//int num = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//int Summ(int num)
//{
//if (num == 0)
//return sum;
//return sum = num % 10 + Summ(num/10);
//}
//Console.WriteLine(Summ(num));




//Console.WriteLine("Введите число");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число");
//int num2 = Convert.ToInt32(Console.ReadLine());
//int result = num1;
//void Count(int num2, int num1, int result)
//{
//
//if (num2 == 1)
//{
//Console.Write($"{result} ");
//}
//else
//{
//
//Count(num2 - 1, num1,result * num1);
//}
//}
//Count(num2,num1,result);





//Console.WriteLine("Введите число");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число");
//int num2 = Convert.ToInt32(Console.ReadLine());
//void Count(int num2, int num1)
//{
//if (num2 > 1)
//{
//  Console.Write($"{num2} ");
//  Count(num2 - 1, num1);
//}
//else
//{
//Console.Write($"{num2} ");
//}
//}
//Count(num2,num1);



//int InputNumber(string input)
//{
//     Console.Write(input);
//    int output = Convert.ToInt32(Console.ReadLine());
//    return output;
// }
//
// void PrintSum(int m, int n, int sum)
//{
//     sum = sum + n;
//     if (n <= m)
//    {
//         Console.Write($" {sum} ");
//         return;
//     }
//     PrintSum(m, n - 1, sum);
//
// }
// int m = InputNumber("Ввод m: ");
// int n = InputNumber("Ввод n: ");
// int temp = m;
//
// if (m > n)
// {
//     m = n;
//     n = temp;
// }
// Console.Write($"{m}, {n} ->");
// PrintSum(m, n, temp = 0);


//Console.WriteLine("Введите число m");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число n");
//int n = Convert.ToInt32(Console.ReadLine());
//int AKF(int m, int n)
//{
//	if(m == 0)
//	{
//		return n + 1;
//	}
//	if(m > 0 && n == 0)
//	{
//		return AKF(m - 1, 1);
//	}
//	return AKF(m - 1, AKF(m, n - 1));
//}
//Console.WriteLine("результат: ");
//Console.WriteLine(AKF(m,n));

//string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
//string[] array2 = new string[array1.Length];
//void SecondArrayWithIF(string[] array1, string[] array2)
//{
//    int count = 0;
//    for (int i = 0; i < array1.Length; i++)
//    {
//    if(array1[i].Length <= 3)
//        {
//        array2[count] = array1[i];
//        count++;
//        }
//    }
//}
//void PrintArray(string[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write($"{array[i]} ");
//    }
//    Console.WriteLine();
//}
//SecondArrayWithIF(array1, array2);
//PrintArray(array2);


// using System;
// using System.Collections.Generic;
// using System.Linq;

// public enum PaymentType
// {
//     Annuity,
//     Differentiated
// }

// public class CreditCalculator
// {
//     public double LoanAmount { get; set; }
//     public double InterestRate { get; set; }
//     public int LoanTerm { get; set; }
//     public PaymentType PaymentType { get; set; }
//     public List<int> GracePeriodMonthsPrincipal { get; set; }
//     public List<int> GracePeriodMonthsInterest { get; set; }

//     public CreditCalculator(double loanAmount, double interestRate, int loanTerm, PaymentType paymentType, List<int> gracePeriodMonthsPrincipal, List<int> gracePeriodMonthsInterest)
//     {
//         LoanAmount = loanAmount;
//         InterestRate = interestRate;
//         LoanTerm = loanTerm;
//         PaymentType = paymentType;
//         GracePeriodMonthsPrincipal = gracePeriodMonthsPrincipal;
//         GracePeriodMonthsInterest = gracePeriodMonthsInterest;
//     }

//     public List<(double payment, double principal, double interest)> CalculateDetailedPayments()
//     {
//         List<double> payments = CalculatePayments();
//         List<(double payment, double principal, double interest)> detailedPayments = new List<(double payment, double principal, double interest)>();

//         for (int i = 1; i <= LoanTerm; i++)
//         {
//             double principal = PaymentType == PaymentType.Annuity ? LoanAmount / LoanTerm : (LoanAmount - LoanAmount / LoanTerm * (i - 1));
//             double interest = payments[i - 1] - principal;

//             if (GracePeriodMonthsPrincipal.Contains(i))
//             {
//                 principal = 0;
//             }
//             if (GracePeriodMonthsInterest.Contains(i))
//             {
//                 interest = 0;
//             }

//             detailedPayments.Add((payments[i - 1], principal, interest));
//         }

//         return detailedPayments;
//     }

//     private List<double> CalculatePayments()
//     {
//         List<double> payments = new List<double>();

//         switch (PaymentType)
//         {
//             case PaymentType.Annuity:
//                 payments = CalculateAnnuityPayments();
//                 break;
//             case PaymentType.Differentiated:
//                 payments = CalculateDifferentiatedPayments();
//                 break;
//         }

//         return payments;
//     }

//     private List<double> CalculateAnnuityPayments()
//     {
//         List<double> payments = new List<double>();
//         double monthlyInterestRate = InterestRate / 100 / 12;
//         double annuityCoefficient = monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, LoanTerm) / (Math.Pow(1 + monthlyInterestRate, LoanTerm) - 1);
//         double annuityPayment = LoanAmount * annuityCoefficient;

//         for (int i = 1; i <= LoanTerm; i++)
//         {
//             double payment = annuityPayment;

//             if (GracePeriodMonthsPrincipal.Contains(i))
//             {
//                 payment -= LoanAmount / LoanTerm;
//             }
//             if (GracePeriodMonthsInterest.Contains(i))
//             {
//                 payment -= LoanAmount * monthlyInterestRate;
//             }

//             payments.Add(payment);
//         }

//         return payments;
//     }

//     private List<double> CalculateDifferentiatedPayments()
//     {
//         List<double> payments = new List<double>();
//         double principalPayment = LoanAmount / LoanTerm;
//         double monthlyInterestRate = InterestRate / 100 / 12;

//         for (        int i = 1; i <= LoanTerm; i++)
//         {
//             double interestPayment = (LoanAmount - principalPayment * (i - 1)) * monthlyInterestRate;
//             double payment = principalPayment + interestPayment;

//             if (GracePeriodMonthsPrincipal.Contains(i))
//             {
//                 payment -= principalPayment;
//             }
//             if (GracePeriodMonthsInterest.Contains(i))
//             {
//                 payment -= interestPayment;
//             }

//             payments.Add(payment);
//         }

//         return payments;
//     }
// }

// public class Program
// {
//     public static List<int> ReadGracePeriodMonths(string example)
//     {
//         Console.WriteLine(example);
//         string[] input = Console.ReadLine().Split(' ');
//         return input.Select(x => int.Parse(x)).ToList();
//     }

//     public static void Main()
//     {
//         Console.WriteLine("Введите сумму кредита:");
//         double loanAmount = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Введите процентную ставку:");
//         double interestRate = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Введите срок кредита в месяцах:");
//         int loanTerm = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Выберите тип платежа (1 - аннуитетный, 2 - дифференцированный):");
//         int paymentTypeInput = Convert.ToInt32(Console.ReadLine());
//         PaymentType paymentType = paymentTypeInput == 1 ? PaymentType.Annuity : PaymentType.Differentiated;

//         Console.WriteLine("Введите льготные месяцы по основному долгу через пробел:");
//         List<int> gracePeriodMonthsPrincipal = ReadGracePeriodMonths("Например: 1 2 3");

//         Console.WriteLine("Введите льготные месяцы по процентам через пробел:");
//         List<int> gracePeriodMonthsInterest = ReadGracePeriodMonths("Например: 4 5 6");

//         CreditCalculator calculator = new CreditCalculator(loanAmount, interestRate, loanTerm, paymentType, gracePeriodMonthsPrincipal, gracePeriodMonthsInterest);
//         List<(double payment, double principal, double interest)> detailedPayments = calculator.CalculateDetailedPayments();

//         Console.WriteLine("Кредитный график:");
//         Console.WriteLine($"{"Платеж",10}{"Основной долг",15}{"Вознаграждение",15}");
//         for (int i = 0; i < detailedPayments.Count; i++)
//         {
//             Console.WriteLine($"Платеж {i + 1}: {detailedPayments[i].payment,10:0.00}{detailedPayments[i].principal,15:0.00}{detailedPayments[i].interest,15:0.00}");
//         }
//     }
// }

