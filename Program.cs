using System.Collections;
using System;
using System.Text;


String History = "2";
String ZhengZhi = "1";
String Way1 = "1";
String Way2 = "2";

StreamReader srHistory = new StreamReader(@".\History.txt", System.Text.Encoding.Default);
string strFileHistory = srHistory.ReadToEnd();
string[] arraFileHistory = strFileHistory.Split('\n');//or '\r'，仅限于读取Windows下的文件
int iLineHistory = arraFileHistory.Length;//文件行数

StreamReader srZhengZhi = new StreamReader(@".\ZhengZhi.txt", System.Text.Encoding.Default);
string strFileZhengZhi = srZhengZhi.ReadToEnd();
string[] arraFileZhengZhi = strFileZhengZhi.Split('\n');//or '\r'，仅限于读取Windows下的文件
int iLineZhengZhi = arraFileZhengZhi.Length;//文件行数

Console.WriteLine("选择背诵科目;政治请输入1，历史输入2");

String Subject = Console.ReadLine();

Console.WriteLine("选择背诵方式;顺序请输入1，乱序输入2");

String Way = Console.ReadLine();


if (Subject== History && Way == Way1)
{
    int counterHistory = 0;
 
    foreach (string line in System.IO.File.ReadLines(@".\History.txt"))
    {
        System.Console.WriteLine(line);
        counterHistory++;
        System.Console.ReadKey();
    }

    System.Console.WriteLine("There were {0} lines.", counterHistory); 
    System.Console.ReadLine();

    Console.ReadKey();

}

if (Subject == History && Way == Way2)
{
    StreamReader streamReader = new(@".\History.txt", Encoding.UTF8); //读取指定文本文档

    ArrayList arrayList = new ArrayList();//建立动态数组

    Random random = new Random();//随机数

    while (streamReader.Peek() >= 0) //逐行读取文本文档

    {
        arrayList.Add(streamReader.ReadLine());//将读取到的行写到数组中

    }

    for (int a = 0; ; a++)
    {

        int i = random.Next(0, iLineHistory); //定义随机数的范围(a,b)b为txt文件最大行数

        string str = arrayList[i].ToString(); //将读取到的随机数组值赋给str

        Console.WriteLine(str); //打印出str

        Console.ReadKey();

    }
}

if (Subject == ZhengZhi && Way== Way1)
{
    int counterZhengZhi = 0;

    foreach (string line in System.IO.File.ReadLines(@".\ZhengZhi.txt"))
    {
        System.Console.WriteLine(line);
        counterZhengZhi++;
        System.Console.ReadKey();
    }

    System.Console.WriteLine("There were {0} lines.", counterZhengZhi);
    System.Console.ReadLine();

    Console.ReadKey();
}

if (Subject == ZhengZhi && Way == Way2)
{
    StreamReader streamReader = new(@".\ZhengZhi.txt", Encoding.UTF8); //读取指定文本文档

    ArrayList arrayList = new ArrayList();//建立动态数组

    Random random = new Random();//随机数

    while (streamReader.Peek() >= 0) //逐行读取文本文档

    {
        arrayList.Add(streamReader.ReadLine());//将读取到的行写到数组中

    }

    for (int a = 0; ; a++)
    {

        int i = random.Next(0, iLineZhengZhi); //定义随机数的范围(a,b)b为txt文件最大行数

        string str = arrayList[i].ToString(); //将读取到的随机数组值赋给str

        Console.WriteLine(str); //打印出str


    }

}

else
{
    Console.WriteLine("你想要的模式还没开发呀OvO");
}
