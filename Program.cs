// Задача 41 Устройство для определения количества введенных + чисел
Console.Clear();
int M=new Random().Next(3,8);
int cnt=0;
int temp;
for (int i=1;i<=M;i++)
    {
    Console.WriteLine("Введите число №"+i);
    temp=Convert.ToInt32(Console.ReadLine());
    if (temp>0)           
        cnt++;
    }
Console.WriteLine("Среди введенных "+M+" чисел"+" "+cnt+" положительных чисел (-ла)");