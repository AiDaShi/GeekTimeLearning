using System;
using System.Collections.Generic;
using System.Text;

namespace AiDaSi_BinaryTree.StructSolve
{
    public class Node_Int : Node<int>
    {
        public override void AddNode(INode<int> t)
        {
            if (t.Value < this.Value)
            {
                if (this.Left == null)
                {
                    this.Left = t;
                }
                else
                {
                    this.Left.AddNode(t);
                }
            }
            else if (t.Value > this.Value)
            {
                if (this.Right == null)
                {
                    this.Right = t;
                }
                else
                {
                    this.Right.AddNode(t);
                }
            }
        }

        public override IEnumerable<INode<int>> GetAllNode(bool LeftOrRight = true, List<INode<int>> baseLI = null)
        {
            List<INode<int>> III = baseLI ?? new List<INode<int>>();
            if (LeftOrRight)
            {
                if (Left != null)
                {
                     Left.GetAllNode(LeftOrRight, III);
                }
                III.Add(this);
                if (Right != null)
                {
                    Right.GetAllNode(LeftOrRight, III);
                }

            }
            else
            {
                if (Right != null)
                {
                    Right.GetAllNode(LeftOrRight, III);
                }
                III.Add(this);
                if (Left != null)
                {
                    Left.GetAllNode(LeftOrRight, III);
                }
            }
            return III;
        }

        public override IEnumerable<int> GetAllValue(bool LeftOrRight = true, List<int> baseLI = null)
        {
            List<int> III = baseLI ?? new List<int>();
            if (LeftOrRight)
            {
                if (Left != null)
                {
                    Left.GetAllValue(LeftOrRight, III);
                }
                III.Add(this.Value);
                if (Right != null)
                {
                    Right.GetAllValue(LeftOrRight, III);
                }
            }
            else
            {
                if (Right != null)
                {
                    Right.GetAllValue(LeftOrRight, III);
                }
                III.Add(this.Value);
                if (Left != null)
                {
                    Left.GetAllValue(LeftOrRight, III);
                }
            }
            return III;
        }

        public override INode<int> Search(int t)
        {
            if (this.Value == t)
            {
                return this;
            }
            else if (t < this.Value && this.Left != null)
            {
                return this.Left.Search(t);
            }
            else if (t > this.Value && this.Right != null)
            {
                return this.Right.Search(t);
            }
            return null;
        }
    }
}
