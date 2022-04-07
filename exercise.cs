using System.Collections.Generic;
using System;

public class Exercises
{
    public static Dictionary<string, int> aboveBelow(List<int> values, int threshold)
    {
        Dictionary<string, int> answer = new Dictionary<string, int>();
        answer.Add("above", 0);
        answer.Add("below", 0);
        for (int i = 0; i < values.Count; i++)
        {
            if (values[i] < threshold)
            {
                answer["below"]++;
            }
            else if (values[i] > threshold)
            {
                answer["above"]++;
            }
        }
        return answer;
    }

    public static string stringRotation(string original, int rotation)
    {
        string answer = original.Substring(original.Length - rotation, rotation) + 
            original.Substring(0, original.Length - rotation);
        return answer;
    }
}
