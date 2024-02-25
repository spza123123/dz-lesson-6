internal class Program
{
    public static void Main(string[] args)
    {
        char[,] array = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
        string result = CreateString(array);
        System.Console.WriteLine(result);
        
    }
    public static string CreateString(char [,] array) 
    {
        string result = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result += array[i, j];
            }
        
            
        }    
        
        return result;
    }

}