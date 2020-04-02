using System;
using System.Linq;

namespace StripComments
{
    public class StripCommentsKata
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            var lines = commentSymbols.Aggregate(text, (current, t) => current.Replace(t, commentSymbols[0])).Split('\n'); ;
            var replaced = lines.Select(x =>
                x.Contains(commentSymbols[0]) 
                    ? x.Remove(x.IndexOf(commentSymbols[0], StringComparison.Ordinal)).Trim() 
                    : x.TrimEnd()).ToArray();

            return string.Join('\n', replaced);
        }
    }
}
