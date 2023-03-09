int[,] table = new int[3, 3];
int[,] aux = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        table[i, j] = (i+1)*(j+1);
        aux[2-i, 2-j] = table[i, j];
        Console.Write(table[i, j]);
    }
    Console.WriteLine("\n");
}
Console.WriteLine("\n");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(aux[i,j]);
    }
    Console.WriteLine("\n");
}

