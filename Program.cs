double Cross(double k2,double b2,double x)
{
    return k2*x+b2;
}
void CrossPoint(double k1,double b1,double k2,double b2)
{
    double x=b1-b2;
    x/=k1-k2;
    x=-x;
    Console.WriteLine(x +" : "+ Cross(k2,b2,x));
}

Console.WriteLine("Hello, World!");
int M,count=0;
int[] array;
Console.WriteLine("ввод с клавиатуры М чисел, подсчет сколко чисел больше 0 введено");
Console.Write("введите количество чисел \"M\"");
M=Convert.ToInt32(Console.ReadLine());
array=new int[M];
Console.WriteLine("вводите числа, после каждого числа нажмите клавишу enter");
for(int i=0;i < array.Length;i++)
    array[i]=Convert.ToInt32(Console.ReadLine());
for (int i=0;i < array.Length;i++)
{
    if(array[i] <= 0)
        continue;
    else count++;
}
Console.WriteLine(count + " чисел больше 0");
Console.WriteLine("найти точку пересечения двух прямых, заданных уравнениями");
Console.WriteLine("y=k1x+b1; y=k2x+b2. значения k и b задаются пользователем");
Console.Write("введите k1: ");
double k1=Convert.ToDouble(Console.ReadLine());
Console.Write("введите b1: ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.Write("введите k2: ");
double k2=Convert.ToDouble(Console.ReadLine());
Console.Write("введите b2: ");
double b2=Convert.ToDouble(Console.ReadLine());
if (k1==k2)
 Console.WriteLine("отрезки параллельны или совпадают");
 else
    CrossPoint(k1,b1,k2,b2);
