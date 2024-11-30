

namespace ExamModul1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
        }


        // task1 varinat 3
        public static int DoubleCounter(List<int> number)
        {
            var counter = 0;
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] >= 10 && number[i] <= 99)
                {
                    ++counter;
                }
            }
            return counter;

        }
        //task2
        public static string DeleteLastTwoChar(string text)
        {
            var removingText = text.Remove(text.Length - 2);

            return removingText;
        }

        ////task3

        public static bool CheckBigLetter(List<string> text)
        {
            var result = true;
            foreach (var letter in text)
            {
                if (letter.IsUpper is false)
                {
                    break;
                    result = false;
                }
            }
            return result;
        }

        //task4

        public static bool CheckQovun(string text)
        {

            if (text.StartsWith("qovun") && text.EndsWith("qovun"))
            {
                return true;
            }
            return false;
        }


        //task5
        //crud

    }
}
