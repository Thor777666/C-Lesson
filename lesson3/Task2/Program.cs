void ZeroEvenEl(int[] arr){
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] % 2 == 0){
            arr[i] = 0;
        }
    }
}

void PrintArr(int[] arr){
    foreach(int el in arr){
        Console.Write(el + " ");
    }
}

int[] array = {2, 5, 10, 3, 9, 12};
ZeroEvenEl(array);
PrintArr(array);