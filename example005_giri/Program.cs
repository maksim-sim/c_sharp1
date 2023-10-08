int a = 1;
int b = 4;
int c = 7;
int d = 3;
int e = 11;

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;
if (e>max) max = e;

Console.Write("Максималное число: ");
Console.WriteLine(max);