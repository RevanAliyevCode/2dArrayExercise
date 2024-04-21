// See https://aka.ms/new-console-template for more information
using static System.Console;

FindPowArray();
void Print2dArr()
{
    int[,] arr =
    {
        {1, 3, 4, 5 },
        {4, 7, 9, 2 },
        {3, 2, 8, 1},
    };

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        WriteLine();
    }
}

void Sum2d()
{
    int[,] arr =
    {
        {1, 3, 4, 5 },
        {4, 7, 9, 2 },
        {3, 2, 8, 1},
    };

    int sum = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
    }

    WriteLine(sum);
}

void SumFirstRow()
{
    int[,] arr =
    {
        {1, 3, 4, 5 },
        {4, 7, 9, 2 },
        {3, 2, 8, 1},
    };
    int sum = 0;

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sum += arr[0, i];
    }

    WriteLine(sum);
}

void FindNegative()
{
    int[,] arr =
    {
        {1, -3, 4, 5 },
        {4, 7, -9, 2 },
        {3, -2, 8, -1},
    };
    int negativeCount = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 0) negativeCount++;
        }
    }

    WriteLine(negativeCount);
}

void FindMinMax()
{
    int[,] arr =
    {
        {1, -3, 4, 5 },
        {4, 7, -9, 2 },
        {3, -2, 8, -1},
    };
    int min = arr[0, 0];
    int max = arr[0, 0];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > max) max = arr[i, j];
            if (arr[i, j] < min) min = arr[i, j];
        }
    }

    WriteLine($"Min: {min}\nMax: {max}");
}

void FindEvenAndOdd()
{
    int[,] arr =
    {
        {1, 3, -4, 5 },
        {4, -7, 9, 2 },
        {3, 2, -8, 1},
    };

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == 0)
                continue;
            else if (arr[i, j] % 2 == 0)
                arr[i, j] = arr[i, j] < 0 ? -2 : 2;
            else
                arr[i, j] = arr[i, j] < 0 ? -1 : 1;

            Write($"{arr[i, j]} ");
        }
        WriteLine();
    }
}

void AssignZero()
{
    int[,] arr =
    {
        {1, -3, 4, 5 },
        {4, 7, -9, 2 },
        {3, -2, 8, -1},
        {5, 7, 9, 0}
    };

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        arr[1, i] = 0;
    }

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        WriteLine();
    }
}

void AssignZeroColumn()
{
    int[,] arr =
    {
        {1, -3, 4},
        {4, 7, -9},
        {3, -2, 8},
    };

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i, 2] = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        WriteLine();
    }
}

void FindDiaqonal()
{
    int[,] arr =
    {
        {1, -3, 4},
        {4, 7, -9},
        {3, -2, 8},
    };
    int sum = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, i];
    }

    WriteLine(sum);
}

void FindAnotherDiaqonal()
{
    int[,] arr =
    {
        {1, -3, 4, 7},
        {4, 7, -9, 5},
        {3, -2, 8, 2},
        {2, 6, 3, 9}
    };
    int j = arr.GetLength(1) - 1;
    int sum = 0;

    for (int i = 0; i < arr.GetLength(0); i++, j--)
    {
        sum += arr[i, j];
    }

    WriteLine(sum);
}

void ZeroDiaqonal()
{
    int[,] arr =
    {
        {1, -3, 4, 7, 6},
        {4, 7, -9, 5, 9},
        {3, -2, 8, 2, 2},
        {2, 6, 3, 9, 1},
        {2, 5, 7, 8, 2 },
    };

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j <= i - 1; j++)
        {
            arr[i, j] = 0;
        }
    }

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        WriteLine();
    }
}

void AnotherZeroDiaqonal()
{
    int[,] arr =
    {
        {1, -3, 4, 7, 6},
        {4, 7, -9, 5, 9},
        {3, -2, 8, 2, 2},
        {2, 6, 3, 9, 1},
        {2, 5, 7, 8, 2 },
    };


    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = arr.GetLength(1) - 1; j >= i + 1; j--)
        {
            arr[i, j] = 0;
        }
    }

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        WriteLine();
    }
}

void FindSumArray()
{
    int[,] arr1 =
    {
        {1, 3, 4},
        {4, 7, 9},
        {3, 2, 8},
    };

    int[,] arr2 =
    {
        {1, 3, 4},
        {4, 7, 9},
        {3, 2, 8},
    };

    if ((arr1.GetLength(0) != arr2.GetLength(0)) && (arr1.GetLength(1) != arr2.GetLength(1)))
    {
        WriteLine("You can not sum this arrays");
    }

    int[,] arr3 = new int[arr1.GetLength(0), arr1.GetLength(1)];

    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            arr3[i, j] = arr1[i, j] + arr2[i, j];
            Write($"{arr3[i, j]} ");
        }
        WriteLine();
    }


}

void SumRows()
{
    int[,] arr1 =
    {
        {1, 3, 4},
        {4, 7, 9},
        {3, 2, 8},
    };

    int sum = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            sum += arr1[i, j];
        }
        WriteLine($"Sum of {i + 1} row: {sum}");
        sum = 0;
    }
}

void SumColumns()
{
    int[,] arr1 =
    {
        {1, 3, 4},
        {4, 7, 9},
        {3, 2, 8},
    };

    int sum = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            sum += arr1[j, i];
        }
        WriteLine($"Sum of {i + 1} columns: {sum}");
        sum = 0;
    }
}

void FindPowArray()
{
    int[,] arr1 =
    {
        {1, 3, 4},
        {4, 7, 9},
        {3, 2, 8},
    };

    int[,] arr2 =
    {
        {1, 3, 4},
        {4, 7, 9},
        {3, 2, 8},
    };

    if ((arr1.GetLength(0) != arr2.GetLength(0)) && (arr1.GetLength(1) != arr2.GetLength(1)))
    {
        WriteLine("You can not sum this arrays");
    }

    int[,] arr3 = new int[arr1.GetLength(0), arr1.GetLength(1)];

    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            arr3[i, j] = arr1[i, j] * arr2[i, j];
            Write($"{arr3[i, j]} ");
        }
        WriteLine();
    }
}


void FindPrimitive()
{
    int[,] arr1 =
    {
        {1, 3, 4},
        {4, 7, 9},
        {3, 2, 8},
    };
    bool primitive = true;

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            primitive = true;
            if (arr1[i, j] < 0) continue;
            for (int k = 2; k <= (int)Math.Sqrt(arr1[i, j]); k++)
            {
                if (arr1[i, j] % k == 0)
                {
                    primitive = false;
                    break;
                }
            }
            if (primitive)
            {
                WriteLine(arr1[i, j]);
            }
        }
    }
}