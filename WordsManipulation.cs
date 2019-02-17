using System.Text;
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if (text == null)
                throw new ArgumentNullException("Argument cannot be null");
            var split = text.Split(new char[] { '.', ',', '!', '?', '-', ':', ';', ' ' },
                StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> resultDictionary = new Dictionary<string, int>();
            foreach (var s in split)
            {
                if (!resultDictionary.ContainsKey(s))
                    resultDictionary.Add(s, 0);
                else
                    resultDictionary[s]++;
            }

            foreach (KeyValuePair<string, int> item in resultDictionary)
            {
                if (item.Value == 0)
                    continue;
                for (int i = 1; i <= item.Value; i++)
                {
                    int index = text.LastIndexOf(item.Key);
                    text = text.Remove(index, item.Key.Length);

                }
            }

        }
    }
}