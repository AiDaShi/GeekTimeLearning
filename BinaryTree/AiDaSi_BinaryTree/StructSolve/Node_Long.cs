using System;
using System.Collections.Generic;
using System.Text;

namespace AiDaSi_BinaryTree.StructSolve
{
    public class Node_Long : Node<long>
    {
        public override void AddNode(INode<long> t)
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

        public override IEnumerable<INode<long>> GetAllNode(bool LeftOrRight = true, List<INode<long>> baseLI = null)
        {
            List<INode<long>> III = baseLI ?? new List<INode<long>>();
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

        public override IEnumerable<long> GetAllValue(bool LeftOrRight = true, List<long> baseLI = null)
        {
            List<long> III = baseLI ?? new List<long>();
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

        public override INode<long> Search(long t)
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
