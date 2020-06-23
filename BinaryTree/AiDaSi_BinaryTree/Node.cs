using System;
using System.Collections.Generic;
using System.Text;

namespace AiDaSi_BinaryTree
{
    public abstract class Node<T>
        : INode<T>
    {
        public Node() 
        {
        
        }
        public T Value { get; set; }
        public INode<T> Left { get; set; }
        public INode<T> Right { get; set; }
        
        public dynamic Obj { get; set; }

        public abstract void AddNode(INode<T> t);

        public abstract IEnumerable<INode<T>> GetAllNode(bool LeftOrRight = true, List<INode<T>> baseLI = null);

        public abstract IEnumerable<T> GetAllValue(bool LeftOrRight = true, List<T> baseLI = null);

        public abstract INode<T> Search(T t);

    }
}
