#region TASK1
int Score = 0;
if (Score>=0 && Score<=100)
{
    if (Score>90)
    {
        Console.WriteLine("A");
    }
    else if (Score > 80)
    {
        Console.WriteLine("B");
    }
    else if (Score > 70)
    {
        Console.WriteLine("C");
    }
    else if (Score > 60)
    {
        Console.WriteLine("D");
    }
    else if (Score > 50)
    { 
        Console.WriteLine("E");
    }
    else if (Score <51)
    {
        Console.WriteLine("FAILED");
    }
    else
    {
        Console.WriteLine("daxil edilen melumat yalnisdir");
    }
}
#endregion
#region TASK2
int[] Array = {1,-3,5,2,-7 };
int NegativeCount = 0;
int PositiveCount = 0;
foreach (int num in Array)
{
    if (num>0)
    {
        PositiveCount++;
    }
    else if (num<0)
    {
        NegativeCount++;
    }
}
Console.WriteLine(PositiveCount++);
Console.WriteLine(NegativeCount++);
#endregion
#region TASK3
int[] array = { 1, 2, 3, 4, 5 };
int enBoyukeded = array[0];
foreach (int num in array)
{
    if (num>enBoyukeded)
    {
        enBoyukeded = num;
    }
}
Console.WriteLine(enBoyukeded);
#endregion

