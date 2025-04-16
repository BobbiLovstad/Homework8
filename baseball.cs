using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written By Bobbi Lovstad
// 4/15/25

namespace Homework_8
{
    public class Baseball
    {
        public static int CalPoints(string[]ops)
        {
            List<int> record = new List<int>();
            foreach (string op in ops)
            {
                if (op == "C")
                {
                    if (record.Count > 0)
                    {
                        record.RemoveAt(record.Count - 1);
                    }
                }
                else if ( op == "D")
                {
                    if(record.Count > 0)
                    {
                        record.Add(record[record.Count -1] *2);
                    }
                }
                else if (op == "+")
                {
                    if (record.Count >= 2)
                    {
                        int sum = record[record.Count - 1] + record[record.Count - 2];
                        record.Add(sum);
                    }
                }
                else
                {
                    // parse integer and add 
                    int num = int.Parse(op);
                    record.Add(num);
                }
            }
            // return the sum of all scores
            int total = 0;
            foreach ( int score in record)
            {
                total += score;
                
            }
            return total;
        }
    }
}
