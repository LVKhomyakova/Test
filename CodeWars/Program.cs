using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public static class Kata
    {
        public static int MaxSequence(int[] arr)  //MaxSequence - подмассив с максимальной суммой
        {
            int max = 0, res = 0, sum = 0;
            foreach (var item in arr)
            {
                sum += item;
                max = sum > max ? max : sum;
                res = res > sum - max ? res : sum - max;
            }
            return res;
            /*
            List<int> sequencesSum = new List<int>();
            sequencesSum.Add(0);
            if (arr.Length == 0) return 0;
            if (arr.All(n => n <= 0)) return 0;
            else if(arr.All(n => n >= 0)) return arr.Sum();
            GetSequence(arr, 0, sequencesSum);
            return sequencesSum.Max();*/
        }
       /* static void GetSequence(int[] arr, int index,List<int> sequencesSum)
        {
            int arrLength = arr.Length;
            if (index == arrLength) return;
            int sum = 0;
            for (int i = index; i < arrLength; i++)
            {
                sum += arr[i];
                if(sum>sequencesSum[0])
                    sequencesSum[0]=sum;
            }
            GetSequence(arr, index+1, sequencesSum);
        }*/

        public static string Likes(string[] str)   //who likes it? - кто отметил лайком
        {
            int length = str.Length;
            string result = "";
            if (length == 0) result = "no one likes this";
            if (length == 1) result = str[0] + " likes this";
            if (length == 2) result = str[0] + " and " + str[1] + " like this";
            if (length == 3) result = str[0] + ", " + str[1] + " and " + str[2] + " like this";
            if (length >= 4) result = str[0] + ", " + str[1] + " and " + (length - 2) + " others like this";
            return result;
        }
    } 
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            return String.Format("{0:d2}:{1:d2}:{2:d2}",seconds/60/60,seconds/60%60,seconds%60);
        }
    } //Human Readable time - перевод секунд в формат чч:мм:сс
    public class DirReduction //DirReduction - направление
    {
        public static string[] dirReduc(String[] arr)
        {
            if (arr.Length == 0) return null;
            Stack<string> direct = new Stack<string>();
            foreach(var dir in arr)
            {
                if(direct.Count==0)
                    direct.Push(dir);
                else if ((dir.CompareTo("NORTH") == 0 && direct.Peek().CompareTo("SOUTH") == 0) ||
                    (dir.CompareTo("SOUTH") == 0 && direct.Peek().CompareTo("NORTH") == 0) ||
                    (dir.CompareTo("EAST") == 0 && direct.Peek().CompareTo("WEST") == 0) ||
                    (dir.CompareTo("WEST") == 0 && direct.Peek().CompareTo("EAST") == 0))
                    direct.Pop();
                else
                    direct.Push(dir);
            }
            return direct.Reverse().ToArray();
        }
    }


}
