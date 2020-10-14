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
        private readonly List<string> Words = new List<string>
        {
            "digital first", "agile", "open", "innovative", "efficiency", "competitive advantage", "ecosystem", "networked", "collaborative", " learning organisation", "social media", "revolution", "cloud based", "big data", "secure", "internet of things", "growth", "value", "customer focused", "digital business", "disruptive", "data leaders", "big data", "insight from data", "platform", "sustainable", "revolution", "culture"
        };

        public List<string> WordSalad { get; set; }

        public void OnGet()
        {
            WordSalad = Words.Shuffle<string>();
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
}
