using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Written By Bobbi Lovstad
// 4-16-25

namespace Homework_8
{
    public class Students
    {
        public int CountStudents(int[]students, int[] sandwhiches)
        {
            Queue<int> StudentQueue = new Queue<int>();
            Queue<int> SandwhichQueue = new Queue<int>();

            int rotation = 0;
            // Loop through until the first student wants the top sandwhich

            while(rotation < StudentQueue.Count)
            {
                if(StudentQueue.Peek() == SandwhichQueue.Peek())
                {
                    // IF student takes sanwhich then both are removed
                    StudentQueue.Dequeue();
                    SandwhichQueue.Dequeue();
                    rotation = 0; // made progress so needes to me reset
                }
                else
                {
                    // Student moves to the end of the queue
                    StudentQueue.Enqueue(StudentQueue.Dequeue());
                    rotation++; // how many have been removed 
                }
                  
            }
            //Students left in the queue cant eat
            return StudentQueue.Count;

        }
    }
}
