internal class Program
{
    private static void Main(string[] args)
    {
           //call solution class
            Solution solution = new Solution();
             char[][] matrix1 = {
            new char[] {'1', '0', '1', '0', '0'},
            new char[] {'1', '0', '1', '1', '1'},
            new char[] {'1', '1', '1', '1', '1'},
            new char[] {'1', '0', '0', '1', '0'}
        };
        Console.WriteLine("Example 1: " + solution.MaximalRectangle(matrix1)); // Output: 6

        // Example 2
        char[][] matrix2 = {
            new char[] {'0'}
        };
        Console.WriteLine("Example 2: " + solution.MaximalRectangle(matrix2)); // Output: 0

        // Example 3
        char[][] matrix3 = {
            new char[] {'1'}
        };
        Console.WriteLine("Example 3: " + solution.MaximalRectangle(matrix3)); // Output: 1
    }
}