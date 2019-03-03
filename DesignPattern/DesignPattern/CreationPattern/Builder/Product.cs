using System;
using System.Collections.Generic;

namespace CreationPattern.Builder
{
    public class Product
    {
        public List<string> partName = new List<string>();

        public void AddPart(string part)
        {
            partName.Add(part);
        }

        public void Show()
        {
            foreach (var item in partName)
            {
                Console.WriteLine(item);
            }
        }
    }
}