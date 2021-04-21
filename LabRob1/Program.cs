using System;
using System.Collections;
using System.Collections.Generic;

namespace LabRob1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new("Vlao", "1232434", '1');
            Student student2 = new("Lolo", "1323225", '5');
            Console.WriteLine($"{student1} \t {student2}");
          
            Dictionary<string, int>[] valuePairs = new Dictionary<string, int>[3];
            {
                string[] subject = new[] { "Algebra", "English", "History", "Biology", "Chemistry",
                        "Geometry", "Musica", "Adeptness", "Health", "Literture"  };
                int[] val2 = new int[20];
                valuePairs[0] = new Dictionary<string, int>();
                valuePairs[1] = new Dictionary<string, int>();
                valuePairs[2] = new Dictionary<string, int>();
                for (int i = 0; i < subject.Length; i++)
                {
                    for (int j = 0 , l = 10; j <val2.Length ;l++, j++)
                    {
                        foreach (var item in student1.ReitingMasss())
                        {
                            if (valuePairs[0].ContainsKey(subject[i]))
                                continue;
                            valuePairs[0].Add(subject[i], item);
                            val2[j] = item;

                        }
                        foreach (var itemyyy in student2.ReitingMasss())
                        {
                            if (valuePairs[1].ContainsKey(subject[i]))
                                continue;
                            valuePairs[1].Add(subject[i], itemyyy);
                            val2[l] = itemyyy;
                        }
                        if (valuePairs[2].ContainsKey(subject[i]))
                            continue;
                        if (val2[j]>=val2[l])
                        {
                            valuePairs[2].Add(subject[i], val2[j] - val2[l]);
                        }
                        else
                        {
                            valuePairs[2].Add(subject[i], val2[l] - val2[j]);
                        }
                    }
                }
                foreach (var item in valuePairs)
                {
                    foreach ( var it in item)
                    {
                        Console.WriteLine(it.Key + "=" + it.Value);
                    }
                }






            }
        }

    }
}
