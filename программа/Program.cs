

string [] Array1 = { "1234", "167", "-2", "Wednsdfsdfs", "231", "qwase", "=)"};
string [] Array2 = new string[Array1.Length];
Result(Array1, Array2);
PrintArray(Array2);



void Result (string [] arr1, string [] arr2 )
{
    int j=0;
    for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i].Length <=3)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
            
        }
}
    
 void PrintArray (string [] arr)
 {
    for(int i=0; i<arr.Length; i++)
        {
        Console.Write($"{arr[i]} ");
        }
 }   

    
