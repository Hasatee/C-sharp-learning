// nhập vào 1 chuỗi và cho biết
// có bao nhiêu ký tự hoa, thường, số
// có bao nhiêu khoảng trắng

Console.Write("Nhập chuỗi s = ");
int upper = 0, lower = 0, number = 0, space = 0;
string s = Console.ReadLine();
foreach (char c in s){
    if (char.IsUpper(c)) upper++;
    else if (char.IsLower(c)) lower++;
    else if (char.IsDigit(c)) number++;
    else if (char.IsWhiteSpace(c)) space++;
    }
Console.WriteLine("Số ký tự hoa: " + upper);
Console.WriteLine("Số ký tự thường: " + lower);
Console.WriteLine("Số ký tự số: " + number);
Console.WriteLine("Số khoảng trắng: " + space);