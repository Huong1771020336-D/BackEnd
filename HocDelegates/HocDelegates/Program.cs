static int TinhTong(int a, int b)
{
    return a + b;
}
static void LoiChao(string name)
{
    Console.WriteLine("Xin chao " + name);
}
//2. khoi tao
Func<int, int, int> tt = TinhTong;
// Co cah nao viet truc tiep ham TinhTng tai day ?
//--> sdung Anonymous methods ( phuong thuc nac danh)
Func<int,int,int> tt2 = delegate ( int a, int b)
{
return a + b; 
};
// Bieu thuc Lambda la cach viet rut gon cua phuong thuc nac danh
Func<int, int, int> tt3 = (int a, int b) => { return a + b; };
Func<int, int, int> tt4 = (int a, int b) => a + b;
Func<int, int, int> tt5 = (a,b) => a + b;

Action<string> ht = LoiChao;
Action<string> ht1 = name => { Console.WriteLine(" Xin chao" + name); };
//3. Thuc thi
//int kq = tt(3, 4);
Console.WriteLine("Ket qua " + tt(3,4));
ht("Hung");
//1. Khai bao delegates
//public delegate int TinhToan(int x, int y);
//public delegate void HienThi(string s);
//Thay vi su dung TinhToan, su dung delegate co san Func
