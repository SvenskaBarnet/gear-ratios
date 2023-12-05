string[] input = File.ReadAllLines("input.txt");
int sum = 0;

for (int x = 0; x < input.Length; x++)
{
    for (int y = 0; y < input[x].Length; y++)
    {
        int numbersFound = 0;
        int firstNum = 0;
        int secondNum = 0;
        if (input[x][y].Equals('*'))
        {
            if (x == 0)
            {
                for (int i = x; i <= x + 1; i++)
                {
                    if (y == 0)
                    {
                        for (int j = y; j <= y + 1; j++)
                        {
                            if (char.IsNumber(input[i][j]) && numbersFound == 0)
                            {
                                firstNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound == 1)
                            {
                                secondNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound > 1)
                            {
                                numbersFound++;
                            }
                        }
                    }
                    if (y == input[i].Length - 1)
                    {
                        for (int j = y -1; j <= y; j++)
                        {
                            if (char.IsNumber(input[i][j]) && numbersFound == 0)
                            {
                                firstNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound == 1)
                            {
                                secondNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound > 1)
                            {
                                numbersFound++;
                            }
                        }

                    }
                    if (y > 0 && y < input[i].Length - 1)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (char.IsNumber(input[i][j]) && numbersFound == 0)
                            {
                                firstNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound == 1)
                            {
                                secondNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound > 1)
                            {
                                numbersFound++;
                            }
                        }

                    }
                }
            }
            if (x == input.Length - 1)
            {
                for (int i = x - 1; i <= x; i++)
                {
                    if (y == 0)
                    {
                        for (int j = y; j <= y + 1; j++)
                        {
                            if (char.IsNumber(input[i][j]) && numbersFound == 0)
                            {
                                firstNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound == 1)
                            {
                                secondNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound > 1)
                            {
                                numbersFound++;
                            }
                        }
                    }
                    if (y == input[i].Length - 1)
                    {
                        for (int j = y -1; j <= y; j++)
                        {
                            if (char.IsNumber(input[i][j]) && numbersFound == 0)
                            {
                                firstNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound == 1)
                            {
                                secondNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound > 1)
                            {
                                numbersFound++;
                            }
                        }

                    }
                    if (y > 0 && y < input[i].Length - 1)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (char.IsNumber(input[i][j]) && numbersFound == 0)
                            {
                                firstNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound == 1)
                            {
                                secondNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound > 1)
                            {
                                numbersFound++;
                            }
                        }

                    }
                }
            }
            if (x > 0 && x < input.Length - 1)
            {
                for (int i = x - 1; i <= x + 1; i++)
                {
                    if (y == 0)
                    {
                        for (int j = y; j <= y + 1; j++)
                        {
                            if (char.IsNumber(input[i][j]) && numbersFound == 0)
                            {
                                firstNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound == 1)
                            {
                                secondNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound > 1)
                            {
                                numbersFound++;
                            }
                        }
                    }
                    if (y == input[i].Length - 1)
                    {
                        for (int j = y -1; j <= y; j++)
                        {
                            if (char.IsNumber(input[i][j]) && numbersFound == 0)
                            {
                                firstNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound == 1)
                            {
                                secondNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound > 1)
                            {
                                numbersFound++;
                            }
                        }

                    }
                    if (y > 0 && y < input[i].Length - 1)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (char.IsNumber(input[i][j]) && numbersFound == 0)
                            {
                                firstNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound == 1)
                            {
                                secondNum = FindNumber(i, j);
                                numbersFound++;
                            }
                            else if (char.IsNumber(input[i][j]) && numbersFound > 1)
                            {
                                numbersFound++;
                            }
                        }

                    }
                }
            }
            if (numbersFound < 2)
            {
                Console.WriteLine($"FirstNumber: {firstNum}\nSecondNumber: {secondNum}");
            }
        }
    }
}

int FindNumber(int X, int Y)
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
        while (char.IsNumber(input[x][y]))
        {
            number = $"{number}{input[x][y]}";
            y++;
        }
        y = Y - 1;
        while (char.IsNumber(input[x][y]))
        {
            number = $"{input[x][y]}{number}";
            y--;
        }
    }
    int num = int.Parse(number);
    return num;
}
