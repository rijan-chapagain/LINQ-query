﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_query
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchItem item = new SearchItem();

            item.SearchWord();

            // Get data source
            string[] language = {"Communication", "Collaboration", "Love", "Peace",
                                    "Complementry", "Compassionate", "Calm", "Courteous", "Supportive", "Motivative", "Helpful"};
            // Create query
            var positiveWords = from lang in language
                         where lang.Contains('C')
                         select lang;
            // Execute Query
            foreach (var words in positiveWords)
            {
                Debug.WriteLine(words);
            }

        }
    }
}
