string[] input = File.ReadAllLines("input.txt");
int sum = 0;

for (int i = 0; i < input.Length; i++)
{
    bool isNumber = false;
    bool firstDigit = true;
    bool isAdjacent = false;
    int firstPos = 0;
    int lastPos = 0;
    string number = string.Empty;
    for (int j = 0; j < input[i].Length - 1; j++)
    {
        if (char.IsNumber(input[i][j]))
        {
            number = $"{number}{input[i][j]}";
            isNumber = true;
            if (firstDigit)
            {
                firstPos = j;
                firstDigit = false;
            }
        }
        if (!char.IsNumber(input[i][j]) && isNumber)
        {
            Console.WriteLine(number);
            lastPos = j - 1;
            isNumber = false;
            firstDigit = true;
            if (i == 0)
            {
                for (int k = i; k < i + 1; k++)
                {
                    if (firstPos > 0 && lastPos < input[i].Length - 1)
                    {
                        for (int l = firstPos - 1; l < lastPos + 1; l++)
                        {
                            if (!char.IsNumber(input[k][l]) && !input[k][l].Equals('.'))
                            {
                                isAdjacent = true;
                            }
                        }
                    }
                    else if (firstPos == 0)
                    {
                        for (int l = firstPos; l <= lastPos + 1; l++)
                        {
                            if (!char.IsNumber(input[k][l]) && !input[k][l].Equals('.'))
                            {
                                isAdjacent = true;
                            }
                        }
                    }
                    else if (lastPos == input[i].Length - 1)
                    {
                        for (int l = firstPos - 1; l <= lastPos; l++)
                        {
                            if (!char.IsNumber(input[k][l]) && !input[k][l].Equals('.'))
                            {
                                isAdjacent = true;
                            }
                        }

                    }

                }
            }
            else if (i < input.Length - 1)
            {
                for (int k = i - 1; k < i; k++)
                {
                    if (firstPos > 0 && lastPos < input[i].Length - 1)
                    {
                        for (int l = firstPos - 1; l <= lastPos + 1; l++)
                        {
                            if (!char.IsNumber(input[k][l]) && !input[k][l].Equals('.'))
                            {
                                isAdjacent = true;
                            }
                        }
                    }
                    else if (firstPos == 0)
                    {
                        for (int l = firstPos; l <= lastPos + 1; l++)
                        {
                            if (!char.IsNumber(input[k][l]) && !input[k][l].Equals('.'))
                            {
                                isAdjacent = true;
                            }
                        }
                    }
                    else if (lastPos == input[i].Length - 1)
                    {
                        for (int l = firstPos - 1; l <= lastPos; l++)
                        {
                            if (!char.IsNumber(input[k][l]) && !input[k][l].Equals('.'))
                            {
                                isAdjacent = true;
                            }
                        }

                    }
                }
            }
            else
            {
                for (int k = i - 1; k < i + 1; k++)
                {
                    if (firstPos > 0 && lastPos < input[i].Length - 1)
                    {
                        for (int l = firstPos - 1; l <= lastPos + 1; l++)
                        {
                            if (!char.IsNumber(input[k][l]) && !input[k][l].Equals('.'))
                            {
                                isAdjacent = true;
                            }
                        }
                    }
                    else if (firstPos == 0)
                    {
                        for (int l = firstPos; l <= lastPos + 1; l++)
                        {
                            if (!char.IsNumber(input[k][l]) && !input[k][l].Equals('.'))
                            {
                                isAdjacent = true;
                            }
                        }
                    }
                    else if (lastPos == input[i].Length - 1)
                    {
                        for (int l = firstPos - 1; l <= lastPos; l++)
                        {
                            if (!char.IsNumber(input[k][l]) && !input[k][l].Equals('.'))
                            {
                                isAdjacent = true;
                            }
                        }
                    }
                    
                }
            }
            if (!isAdjacent)
            {
                Console.WriteLine($"i:{i} number: {number}");
                sum += int.Parse(number);
            }
            isAdjacent = false;
            number = string.Empty;
        }

    }
}
