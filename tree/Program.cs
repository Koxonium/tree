using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Program
    {
        static List<int> numbers = new List<int>();
        static void Main(string[] args)
        {
            Node root = new Node(5);
            root.addChild(4);
            root.addChild(7);
            root.addChild(3);
            root.addChild(2);
            root.addChild(1);
            inorder(root);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }

        static void inorder(Node N)
        {
            if (N.LeftChild != null)
            {
                inorder(N.LeftChild);
            }
            numbers.Add(N.value);
            if(N.RightChild != null)
            {
                inorder(N.RightChild);
            }
            return;
        }
    }
}
