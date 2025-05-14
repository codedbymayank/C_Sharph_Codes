int a = 50;

//Implicit Conversion
float b = a;
Console.WriteLine(b);

float c = 100f;

//Explicit Conversion
int d = Convert.ToInt32(c);
Console.WriteLine(d);

string s1 = "1000";
string s2 = "1992";

//Explicit Conversion
int value = Convert.ToInt32(s1) + Convert.ToInt32(s2);
Console.WriteLine(value);
