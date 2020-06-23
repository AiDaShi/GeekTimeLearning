using System;
using System.Collections.Generic;
using System.Text;

namespace AiDaSi_BinaryTree
{
    public interface INode<T>
    {
        T Value { get; set; }
        dynamic Obj { get; set; }
        INode<T> Left { get; set; }
        INode<T> Right { get; set; }
        IEnumerable<INode<T>> GetAllNode(bool LeftOrRight = true, List<INode<T>> baseLI = null);
        IEnumerable<T> GetAllValue(bool LeftOrRight=true, List<T> baseLI = null);
        void AddNode(INode<T> t);
        INode<T> Search(T t);
    }
}
