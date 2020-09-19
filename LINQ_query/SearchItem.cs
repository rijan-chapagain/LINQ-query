using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_query
{
    class SearchItem
    {
        public void SearchWord()
        {
            List<string> my_list = new List<string>() {
                "AI is the most powerful tech now.",
                "Technology that doesn't have AI is useless.",
                "Deep learning and machine learning are path to create AI project\n",
                "Google is IBM are are making Quantam Computer",
                "Quantam Computer is the key component that the world's largest company tech are working on."
                };

            var data = my_list.Where(text => text.Contains("AI"));

            // Executing LINQ Query

            foreach(var val in data)
            {
                Debug.WriteLine(val);
            }
        }


    }
}
