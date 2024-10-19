int n = 5;
int[] arr = new int[n];
int i = 0;
while(i < n){
    arr[i] = i + 1;
    Console.Write(arr[i] + " ");
    i += 1;
}

Console.WriteLine();

int[] arr2 = {5, 10, 4, 3, 11, 20, 13, 6, 17, 8};
int j = 0;
while (j < arr2.Length){
    if (arr2[j] % 2 == 0){
         Console.Write(arr2[j] + " ");
    }
    j += 1;
}

