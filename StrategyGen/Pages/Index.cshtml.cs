using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyGen.Pages
{
    public class IndexModel : PageModel
    {
        private readonly List<string> Nouns = new List<string>
        {
            "efficiency", "competitive advantage", "ecosystem", "learning organisation", "social media", "revolution", "big data", "internet of things", "growth", "value", "digital business","data leaders", "insight from data", "platform", "revolution", "culture"
        };
        private readonly List<string> Adjectives = new List<string>
        {
            "digital first", "agile", "open", "innovative", "networked", "collaborative", "cloud based", "secure", "customer focused", "disruptive", "sustainable"
        };



        public List<string> NounSalad { get; set; }
        public List<string> AdjectiveSalad { get; set; }

        public void OnGet()
        {
            NounSalad = Nouns.Shuffle<string>();
            AdjectiveSalad = Adjectives.Shuffle<string>();
        }
    }

    public static class ListExtensions {
        private static readonly Random rng = new Random();
        public static List<T> Shuffle<T>(this IList<T> list)
        {
            var newList = new List<T>(list);
            int n = newList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = newList[k];
                newList[k] = newList[n];
                newList[n] = value;
            }
            return newList;
        }
    }

    public static class StringExtensions
    {
        public static string WithArticle(this string word)
        {
            if ("aeiouAEIOU".Contains(word[0]))
            {
                return $"an {word}";
            }
            return $"a {word}";
        }
    }
}
