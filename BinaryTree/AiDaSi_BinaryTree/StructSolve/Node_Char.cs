using System;
using System.Collections.Generic;
using System.Text;

namespace AiDaSi_BinaryTree.StructSolve
{
    public class Node_Char : Node<char>
    {
        public override void AddNode(INode<char> t)
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

        public override IEnumerable<INode<char>> GetAllNode(bool LeftOrRight = true, List<INode<char>> baseLI = null)
        {
            List<INode<char>> III = baseLI ?? new List<INode<char>>();
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

        public override IEnumerable<char> GetAllValue(bool LeftOrRight = true, List<char> baseLI = null)
        {
            List<char> III = baseLI ?? new List<char>();
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

        public override INode<char> Search(char t)
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
