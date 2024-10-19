int[] arr = {5, 10, 12, 3, 5};
for(int i = 0; i < arr.Length; i += 1){
    Console.Write(arr[i] + " ");
}

Console.WriteLine();
////////////////////////////////////////////////////////////////////////////


int n = 100;
int sum = 0;
for(int i = 0; i < n; i += 1){
    sum += i;
}
Console.Write(sum);

Console.WriteLine();
////////////////////////////////////////////////////////////////////////////

foreach(int e in arr){
    Console.Write(e + " ");
}

Console.WriteLine();
////////////////////////////////////////////////////////////////////////////

int max = arr[0];
for(int j = 0; j < arr.Length; j++){
    if(arr[j] > max){
        max = arr[j];
    }
}
Console.Write(max);