// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[][] jaggedArr = new int[][]
{
  new int[ ] {1,8,2,7,9},
  new int[ ] {2,4,6},
  new int[ ] {33,42}
};

string[][] fruits = { new string[] { "Apple", "Apricot" }, new string[] { "Mango", "Orange", "Melon" } };
for (int i; i<2; i++)
{
    for (int j; j<3; j++)
    {
        Console.WriteLine(fruits[i][j]);
    }
}