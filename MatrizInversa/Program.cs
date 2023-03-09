int[,] table = new int[10, 6];
int[,] aux = new int[10, 6];

int contaLinha = table.GetLength(0);
int contaColuna = table.GetLength(1);

for (int row = 0; row < contaLinha; row++)
{
    for (int col = 0; col < contaColuna; col++)
    {
        table[row, col] = (row + 1) * (col + 1);
        aux[(contaLinha - 1) - row, (contaColuna - 1) - col] = table[row, col];
        Console.Write(table[row, col] + " | ");
    }
    Console.WriteLine("\n");
}
Console.WriteLine("\n");
for (int i = 0; i < contaLinha; i++)
{
    for (int j = 0; j < contaColuna; j++)
    {
        Console.Write(aux[i, j] + " | ");
    }
    Console.WriteLine("\n");
}

