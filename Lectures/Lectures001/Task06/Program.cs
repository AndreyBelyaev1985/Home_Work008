
int a = 1;
int b = 5;
int c = 8;
int d = 4;
int f = 3;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (f > max) max = f;

System.Console.Write("max = ");
System.Console.WriteLine(max);