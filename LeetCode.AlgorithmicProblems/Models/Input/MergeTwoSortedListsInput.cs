using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.Models.Input
{
    public class MergeTwoSortedListsInput
    {
        public DataStructures.Lists.LinkedListNode<int> ListA { get; set; }
        public DataStructures.Lists.LinkedListNode<int> ListB { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            var currentNodeA = ListA;
            while (currentNodeA != null)
            {
                output.Append($"{currentNodeA.Value}, ");

                currentNodeA = currentNodeA.Next;
            }

            output = new StringBuilder($"ListA: [ {output.Remove(output.Length - 2, 2)} ]\n");

            var currentNodeB = ListB;
            while (currentNodeB != null)
            {
                output.Append($"{currentNodeB.Value}, ");

                currentNodeB = currentNodeB.Next;
            }

            output = new StringBuilder($"ListB: [ {output.Remove(output.Length - 2, 2)} ]\n");

            return output.ToString();
        }
    }
}
