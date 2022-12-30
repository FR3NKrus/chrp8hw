int [,] Creat2dArray(int rows, int cols){
int [,] array = new int [rows,cols];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < cols; j++){
            array[i,j] = Convert.ToInt32(new Random().Next(0, 10));
        }    
     }
    return array;
  }
    
void Show2dArray(int [,] array) {
        for (int i = 0; i < array.GetLength(0); i++){
          for (int j = 0; j < array.GetLength(1); j++){
              Console.Write($"{array[i,j]}  ");  
          }    
          System.Console.WriteLine();
      }
  }
    
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] SortArray(int [,] array) {
    int count = 0;
    while (count < array.GetLength(0) || count < array.GetLength(1)){
      for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 1; j < array.GetLength(1); j++){
          if (array[i,(j-1)] < array[i,j]) {
            int temp = array[i,(j-1)];
            array[i,(j-1)] = array[i,j];
            array[i,j] = temp;
          } 
       }
    }
    count++;
  }   
  return array;
}  

Console.Write("Введите количество столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int cols = Convert.ToInt32(Console.ReadLine());    
int [,] newArray =  Creat2dArray(rows, cols);
Console.WriteLine("Исходный массив: "); 
Show2dArray(newArray);
int [,] array = SortArray(newArray);
Console.WriteLine("");
Console.WriteLine("Отсортированный массив:"); 
Show2dArray(array);
    
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int MinColsArray (int [,] array) {
  int [] temp = new int [array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0);i++){
    for (int j = 0; j < array.GetLength(1); j++){
       temp[i] += array[i,j];
    }  
  }
  int min = temp[0];
  int cols = 0;
  for (int i = 1; i < temp.Length; i++){
    if (temp[i] < min) {
      min = temp[i];
      cols = i;
    } 
  }
  return cols;
} 
    
// Console.Write("Введите количество столбцов: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк: ");
// int cols = Convert.ToInt32(Console.ReadLine());   
// int [,] newArray =  Creat2dArray(rows, cols);
// Show2dArray(newArray);
// int result = MinColsArray(newArray);
// Console.WriteLine($"Строка с наименьшей суммой элементом: {result +1}");
  
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int [,] CreatMatrixArray2 (int size){
  int [,] matrix = new int [size,size];
  for (int i = 0; i < size;i++){
    for (int j = 0; j < size; j++){
      matrix[i,j] = new Random().Next(1,10);
    }
  }
  return matrix;
}

int [,] ProductMatrix (int [,] array1, int [,] array2){
  int [,] array = new int [array1.GetLength(0),array1.GetLength(1)];
  return array;
} 

int[,] matrixRez(int [,] array, int [,] array2){       
  int [,] array3 = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++){
      for (int j = 0; j < array2.GetLength(1); j++){
        array3[i, j] = 0;
          for(int m = 0; m < array.GetLength(0); m++){
            array3[i, j] += array[i, m] * array2[m, j];
             }
         }
     }
  return array3;
}
    
// int size = 2;
// int [,] array = CreatMatrixArray2(size);
// int [,] array2 = CreatMatrixArray2(size);
// Show2dArray(array);
// System.Console.WriteLine("");
// Show2dArray(array2);
// int [,] array3 = matrixRez(array, array2);
// System.Console.WriteLine("Произведение Матрицы А и Б: ");
// Show2dArray(array3);  
  
// int [,] prd = ProductMatrix(array, array2);
    
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [,,] Creat3dArray (int size, int [] array){
  int [,,] matrix = new int [size,size,size];
  for (int i = 0; i < size;i++){  
    for (int j = 0; j < size; j++){ 
      for (int k = 0; k < size; k++){
        RandomGenerator(array, size);
        matrix[i,j,k] = NumReturn(array);
      }
    }
  }
  return matrix;
}

int [] RandomGenerator (int [] array, int size){
  int num = new Random().Next(10,100);
  for (int i = 0; i < array.Length; i++){

    if (array[i] == num){
      num++;
      array[i] = num;

    } 
    else {
      array[i] = num;

    }   
  }  
  return array;
}

int NumReturn (int [] array){
  return array[0];
}

void Show3dArray (int [,,] array){
  for (int i = 0; i < array.GetLength(0);i++){
    for (int j = 0; j < array.GetLength(1); j++){
      System.Console.WriteLine($"");
      for (int k=0; k < array.GetLength(2); k++)
      System.Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
      System.Console.WriteLine($"");
    }    
  }   
}

// int size = 2;
// int [] numArray = new int [size*size*size];
// int [,,] array = Creat3dArray(size, numArray);
// Show3dArray(array);  

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

  int [,] CreatArraySP(int size){
    int [,] array = new int [size,size];
      array[0,0] = 1;
      int count = 2;
      int i = 0;
      int j = 0;
  for (int k = 0; k < (size * size); k++){
      for (; j < size -1 && array[i,j+1] == 0; j++){
        if (array[i,j+1] == 0){
          array[i,j+1] = count;
          count++;
        }
      }   
      for (; i < size -1 && array[i+1,j] == 0; i++){
        if (array[i+1,j] == 0){
          array[i+1,j] = count;
          count++;
        }
      }
      for (; j > 0 && array[i,j-1] == 0; j--){
        if (array[i,j-1] == 0){
          array[i,j-1] = count;
          count++;
        }
      }  
      for (; i > 0 && array[i-1,j] == 0; i--){
          array[i-1,j] = count;
          count++;
        }
    }
      return array;
    }
  void Show2dArraySP(int [,] array) {
        for (int i = 0; i < array.GetLength(0); i++){
          for (int j = 0; j < array.GetLength(1); j++){
              Console.Write($"{array[i,j].ToString().PadLeft(2,'0')}  ");  
          }    
          System.Console.WriteLine();
      }
  }
    
// Console.Write("Введите размер Матрицы: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [,] array = CreatArraySP(size);
// Show2dArraySP(array);

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
