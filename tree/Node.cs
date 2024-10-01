using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class Node
    {
        public int value;
        public Node LeftChild { get; private set; }
        public Node RightChild { get; private set; }
        public Node(int number)
        {
            value = number;
        }

        /*public List<int> returnList(Node one)
        {
            List<int> data = new List<int>();
            if (one.LeftChild == null)
            {
                data.Add(value);
            }
            return data;
        }*/

        public void addChild(int num)
        {
            if (value < num)
            {
                if (RightChild == null)
                {
                    RightChild = new Node(num);
                }
                else
                {
                    RightChild.addChild(num);
                }
            }
            else
            {
                if (LeftChild == null)
                {
                    LeftChild = new Node(num);
                }
                else
                {
                    LeftChild.addChild(num);
                }
            }
        }
    }
}