// tính diện tích và chu vi hình tròn
Console.Write("Nhập r = ");
int r = Convert.ToInt32(Console.ReadLine());
double s = Math.PI * r * r;
double c = 2 * Math.PI * r;
Console.WriteLine("Diện tích hình tròn là: " + s);
Console.WriteLine("Chu vi hình tròn là: " + c);

// tính chu vi hình tam giác
Console.Write("Nhập a = ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhập b = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhập c = ");
int c1 = Convert.ToInt32(Console.ReadLine());
double chuvi = a1 + b1 + c1;
Console.WriteLine("Chu vi hình tam giác là: " + chuvi);

// giải phương trình bậc 2 ax^2 + bx + c = 0 (a#0)
Console.Write("Nhập a = ");
double a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Nhập b = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Nhập c = ");
double c2 = Convert.ToDouble(Console.ReadLine());
double d = b2 * b2 - 4 * a2 * c2;
if (d < 0)
{
    Console.WriteLine("Phương trình vô nghiệm");
}
else if (d == 0)
{
    double nodon = -b2 / (2 * a2);
    Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = " + nodon);
}
else
{
    double x1 = (-b2 + Math.Sqrt(d)) / (2 * a2);
    double x2 = (-b2 - Math.Sqrt(d)) / (2 * a2);
    Console.WriteLine("Phương trình có hai nghiệm phân biệt:");
    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}

// nhập vào giác trị của x và tính y theo công thức sau:
// y = 5^x + sqrt(x^2 + 4) nếu x >= 5
// y = |x| + log5(x^2 + 4) nếu x < 5
Console.Write("Nhập x = ");
double x4 = Convert.ToDouble(Console.ReadLine());
if (x4 >= 5)
    {
    double y1 = Math.Pow(5, x4) + Math.Sqrt(x4 * x4 + 4);
    Console.WriteLine("y = " + y1);
}
else
{
    double y2 = Math.Abs(x4) + Math.Log(x4 * x4 + 4, 5);
    Console.WriteLine("y = " + y2);
}

// nhập và tháng và năm dương lịch, in ra số ngày của tháng đó
Console.Write("Nhập tháng (1-12): ");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhập năm: ");
int year = Convert.ToInt32(Console.ReadLine());
if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
    Console.WriteLine("Tháng " + month + " năm " + year + " có 31 ngày.");
else if (month == 4 || month == 6 || month == 9 || month == 11)
    Console.WriteLine("Tháng " + month + " năm " + year + " có 30 ngày.");
else {
    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        Console.WriteLine("Tháng " + month + " năm " + year + " có 29 ngày.");
    else
        Console.WriteLine("Tháng " + month + " năm " + year + " có 28 ngày.");
}

// nhập n vào rồi tính x theo công thức sau:
// x/4 = 1 - 1/3 + 1/5 - 1/7 + ... + (-1)^(n)/(2n+1)
Console.Write("Nhập n = ");
int n6 = Convert.ToInt32(Console.ReadLine());
double x = 0;
for (int i = 0; i <= n6; i++)
{
    x = x + Math.Pow(-1, i) / (2 * i + 1);
}
Console.WriteLine("x = " + (4 * x));

// tìm các số nguyên tố trong khoảng từ 1 đến n
Console.WriteLine("Nhập n = ");
int n8 = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n8; i++)
{
    bool isPrime = true;
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.Write(i + " ");
    }
}