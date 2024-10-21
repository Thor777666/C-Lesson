int size = 5;
int[] arr = new int[size];
int i = 0;
while (i < size)
{
    Console.WriteLine("Введите элемент масссива: ");
    string input = Console.ReadLine();
    arr[i] = Convert.ToInt32(input);
    i++;
}

foreach(int n in arr){
    Console.Write(n + " ");
}