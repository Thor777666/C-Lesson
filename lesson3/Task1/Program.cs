double CalcForm(int a, int b, int c, int d){
    double numen = a + b;
    int denumen = c * d;
    double result = numen / denumen;
    return result;
}

double result = CalcForm(1, 2, 3, 4);
Console.WriteLine(result);

Console.WriteLine();

////////////////////////////////////////////////////////////////////  

void PrintSqr(int limit){
    int i = 1;
    while (i <= limit){
        Console.Write(i*i + " ");
        i++;
    }
}
PrintSqr(10);