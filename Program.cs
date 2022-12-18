//implicit Conversion
Console.WriteLine("********IMPLICIT CONVERSION**********");
byte a = 5;
sbyte b = 4;
short c = 9;

int d = a + b + c;
Console.WriteLine("d " + d);

long h = d ;
Console.WriteLine("h " + h);

float k = h; 
Console.WriteLine("k " + k);

string e = "Batuhan";
char t = 'o';
object j = e + t + h;
Console.WriteLine("j " + j);

// Explicit Conversion

Console.WriteLine("********EXPLICIT CONVERSION********");

int x = 5; 
byte y = (byte)x;
Console.WriteLine("x" + x); 

float w = 14.2f;
byte q = (byte)w;
Console.WriteLine("q" + q); 

// ToString Methodu 

Console.WriteLine("********ToString Methodu**********");

int  xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy " + yy );

string zz = 12.2f.ToString();
Console.WriteLine("zz " + zz ); 

//System.Convert 

Console.WriteLine("********System.Convert Methodu**********");

string s1 = "13", s2 = "14";
int sayi1 , sayi2 ;
int toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);
toplam = sayi1 + sayi2 ; 

Console.WriteLine(toplam);

// Parse

Console.WriteLine("********Parse Methodu**********");

ParseMethod();


static void ParseMethod()
{
    string metin1 = "10";
    string metin2 = "10.53";
    int rakam1;
    double double1;

    rakam1 = Int32.Parse(metin1);
    double1 = double.Parse(metin2);

    Console.WriteLine("rakam1 : " + rakam1);
    Console.WriteLine("double 1 : " + double1);





}

















