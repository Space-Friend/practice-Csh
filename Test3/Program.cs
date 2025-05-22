int[][] jaggedArr = new int[][]
{
  new int[ ] {1,8,2,7,9},
  new int[ ] {2,4,6},
  new int[ ] {33,42}
};

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