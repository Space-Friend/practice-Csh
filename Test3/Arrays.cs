int[][] jaggedArr =
[
  [1,2,3,4],
  [2,2,3,33]
];

string[][] fruits = { new string[] { "Apple", "Apricot" }, new string[] { "Mango", "Orange", "Melon" } };
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 5; j++)
    {
        try
        {
            Console.WriteLine(jaggedArr[i][j] + " i={0}, j={1}; ", i, j); 
        }
        catch
        {
            Console.WriteLine("  Failed! i={0}, j={1}; ", i, j);
        }
    }
}