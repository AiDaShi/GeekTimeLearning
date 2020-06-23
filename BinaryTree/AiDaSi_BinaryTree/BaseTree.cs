using System;
using System.Collections.Generic;
using System.Text;

namespace AiDaSi_BinaryTree
{
    public abstract class BaseTree<T>
    {
        public INode<T> Root { get; set; }

        public virtual INode<T> Search(T t) 
        {
            return this.Root.Search(t);
        }
        public virtual IEnumerable<INode<T>> GetAllNode(bool LeftOrRight = true)
        {
            return this.Root.GetAllNode(LeftOrRight);
        }
        public virtual IEnumerable<T> GetAllValue(bool LeftOrRight = true)
        {
            return this.Root.GetAllValue(LeftOrRight);
        }
        public virtual void AddNode(INode<T> t)
        {
            if (this.Root==null)
            {
                this.Root = t;
            }
            else
            {
                this.Root.AddNode(t);
            }
        }

    }
}
