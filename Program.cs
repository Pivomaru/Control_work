void methodArray(string[] array)
{
    string[] newarr = new string[array.Length]
     for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarr[i] = array[i]; ;
            Console.WriteLine(newarr[i]);
        }
    }
    Console.WriteLine();
}
