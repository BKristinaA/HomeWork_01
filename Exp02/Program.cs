
int[] array = {44, 5 ,78};


int index = 0;
int max = 0;

while (index < array.Length)
{
  if (array[index] > max) 
    {
    max = array[index];
    }
index = index + 1;
}

Console.WriteLine("max " + max);