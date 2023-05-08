// See https://aka.ms/new-console-template for more information
#region selection sort algorthms
/*
int[] arr = { 4, 1, 9, 3, 0, 11, 7 };
int minindex;
for (int i = 0; i < arr.Length-1; i++)
{
    minindex = i;
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[j] < arr[minindex])
        {
            minindex = j;
        }
    }
    if (minindex!=i)
    {
        int temp = arr[minindex];
        arr[minindex] = arr[i];
        arr[i] = temp;
    }
}
foreach (var item in arr)
{
    Console.WriteLine(item);
}
*/
#endregion

#region buble sort and binary search

int[] arr = { 4, 1, 9, 3,6, 0, 11, 7 };
Boolean sorted = false;
int len = arr.Length-1;
while (!sorted)
{
    sorted = true;
    for (int i = 0; i < len; i++)
    {
        if (arr[i] > arr[i+1])
        {
            int temp = arr[i+1];
            arr[i+1] = arr[i];
            arr[i] = temp;
            sorted = false;
        }

    }
   
    len--;
}
foreach (var item in arr)
{
    //Console.WriteLine(item);
}
//sorted array {0,1,3,4,7,9,11}
//binary search
int search = 11;
int l = 0;
int r = arr.Length;
int m;
int iter = 0;
while (l<r)
{
    iter++;
    m = (r + l) / 2;
    if (search ==arr[m])
    {
        Console.WriteLine($" seaching number finded {iter}-th iteration");
        break;
    }
    else if (search > arr[m])
    {
        l = m;
    }
    else  
    {
        r = m;
    }
   
    
}


#endregion

#region linear search
/*
int[] arr = { 4, 1, 8, 5, 0, 2,-11,-9, 7,-3, 9, 3, 6 };
int max=0;
int min=0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>max)
    {
        max = arr[i];
    }
    else if (arr[i]<min)
    {
        min = arr[i];
    }
}
Console.WriteLine($"minimin number is  {min} maximun number is {max} in array");
*/
#endregion