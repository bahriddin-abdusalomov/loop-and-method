using LoopAndMethod.Service;

namespace LoopAndMethod;
public class AlgoritmService : IAlgoritm
{
    public List<char> FirstLetter(List<string> names)
    {
        List<char> result = new List<char>();

        foreach (var item in names)
        {
            if (item.ToLower().All(char.IsLower))
            {
                string nameAndFirstLetter = string.Format("{0} -> {1}", item, item[0]);
                Console.WriteLine(nameAndFirstLetter);
            }
        }

        return result;
    }

    public long InverseNumber(long number)
    {
        long result = 0;
        bool lamp = number < 0 ? false : true;
        number = lamp ? number : -1 * number;

        while (number > 0)
        {
            result += number % 10;
            number /= 10;
            result *= number != 0 ? 10 : 1;
        }

        return lamp ?  result : -1 * result;
    }

    public bool IsPalindrome(long value)
    {
        return value == InverseNumber(value)? true : false;
    }

    public void StarRhombus(int number)
    {
         for (int i = 0; i < number; i++)
        {
            for(int j = 0; j < number; j++)
            {
                if(i + j >= number/2 && i + j <= 1.5 * number && Math.Abs(i - j) <= number/2)
                {
                    Console.Write(" *");
                }
                else
                {
                    Console.Write("  ");
                }
            }
                Console.WriteLine();
        }
    }
}
