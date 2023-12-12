string[] input = File.ReadAllLines("input.txt");
int sum = 0;
int numbersFound = 0;
int firstNum = 0;
int secondNum = 0;
for (int x = 0; x < input.Length; x++)
{
    for (int y = 0; y < input[x].Length; y++)
    {
        numbersFound = 0;
        firstNum = 0;
        secondNum = 0;
        if (input[x][y].Equals('*'))
        {
            if (x == 0)
            {
                for (int i = x; i <= x + 1; i++)
                {
                    GetRange(y, i);
                }
            }
            if (x == input.Length - 1)
            {
                for (int i = x - 1; i <= x; i++)
                {
                    GetRange(y, i);
                }
            }
            if (x > 0 && x < input.Length - 1)
            {
                for (int i = x - 1; i <= x + 1; i++)
                {
                    GetRange(y, i);
                }
            }
            if (numbersFound == 2)
            {
                sum += firstNum * secondNum;
            }
        }
    }
}

Console.WriteLine(sum);

int GetNumber(int X, int Y)
{
    int x = X;
    int y = Y;
    string? number = null;
    if (y == 0)
    {
        while (char.IsNumber(input[x][y]))
        {
            number = $"{number}{input[x][y]}";
            y++;
        }
    }
    else if (y == input[x].Length - 1)
    {
        while (char.IsNumber(input[x][y]))
        {
            number = $"{input[x][y]}{number}";
            y--;
        }

    }
    else if (y > 0 && y < input[x].Length - 1)
    {
        while (y <= input[x].Length - 1 && char.IsNumber(input[x][y]))
        {
            number = $"{number}{input[x][y]}";
            y++;
        }
        y = Y - 1;
        while (y >= 0 && char.IsNumber(input[x][y]))
        {
            number = $"{input[x][y]}{number}";
            y--;
        }
    }
    int num = int.Parse(number);
    return num;
}

void LocateNumber(int i, int j)
{
    if (char.IsNumber(input[i][j]) && numbersFound == 0)
    {
        firstNum = GetNumber(i, j);
        numbersFound++;
    }
    else if (char.IsNumber(input[i][j]) && numbersFound == 1)
    {
        if (GetNumber(i, j) != firstNum && GetNumber(i, j) != secondNum)
        {
            secondNum = GetNumber(i, j);
            numbersFound++;
        }
    }
    else if (char.IsNumber(input[i][j]) && numbersFound > 1)
    {
        if (GetNumber(i, j) != secondNum && GetNumber(i, j) != firstNum)
        {
            numbersFound++;
        }
    }
}

void GetRange(int y, int i)
{
    if (y == 0)
    {
        for (int j = y; j <= y + 1; j++)
        {
            LocateNumber(i, j);
        }
    }
    if (y == input[i].Length - 1)
    {
        for (int j = y - 1; j <= y; j++)
        {
            LocateNumber(i, j);
        }

    }
    if (y > 0 && y < input[i].Length - 1)
    {
        for (int j = y - 1; j <= y + 1; j++)
        {
            LocateNumber(i, j);
        }

    }
}
