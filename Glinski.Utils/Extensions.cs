using System.Collections.Generic;
using System.Text;


namespace Gliski.Utils
{
    public static class Extensions
    {
        public static void AddIfNew(this List<StringBuilder> list, StringBuilder word)
        {
            foreach (var w in list)
            {
                if (w.Equals(word))
                {
                    return;
                }

            }
            list.Add(word);
        }

        public static string AllWordsToString(this List<StringBuilder> textCollection)
        {
            StringBuilder text = new StringBuilder();
            foreach (var w in textCollection)
            {
                text.Append(w);
            }
            if(text.Length>0)
            {
                
                return text.ToString();
            }
            return null;
            
        }
    }
}
