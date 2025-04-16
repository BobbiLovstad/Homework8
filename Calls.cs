using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
// Written By bobbi Lovstad
// 4-16-25

namespace Homework_8
{
    public class Calls
    {
        public class RecentCounter
        {
            private List<int> RequestTimes = new List<int>();

            // Constructor initialize an emppty list 

            public RecentCounter()
            {
                RequestTimes = new List<int>();

                // Method adds a request and returns a number of request

                int Ping(int t)
                {
                    RequestTimes.Add(t);

                    int start = 0;
                    while (start < RequestTimes.Count)
                    {
                        if (RequestTimes[start] < t - 3000)
                        {
                            start++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (start > 0)
                    {
                        List<int> myList = new List<int>();

                        for (int i = 0; i < RequestTimes.Count; i++)
                        {
                            myList.Add(RequestTimes[i]);
                        }

                        RequestTimes = myList;
                    }
                    return RequestTimes.Count;
                }
            }
        }
    }
}
