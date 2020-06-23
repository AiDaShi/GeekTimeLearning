using System;
using System.Collections.Generic;
using System.Text;

namespace AiDaSi_BinaryTree.StructSolve
{
    public class Node_String : Node<string>
    {

        public override void AddNode(INode<string> t)
        {
            if (t.Value[0] < this.Value[0])
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
            else if (t.Value[0] > this.Value[0])
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

        public override IEnumerable<INode<string>> GetAllNode(bool LeftOrRight = true, List<INode<string>> baseLI = null)
        {
            List<INode<string>> III = baseLI ?? new List<INode<string>>();
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

        public override IEnumerable<string> GetAllValue(bool LeftOrRight = true, List<string> baseLI = null)
        {
            List<string> III = baseLI ?? new List<string>();
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

        public override INode<string> Search(string t)
        {
            
            if (this.Value == t)
            {
                return this;
            }
            else if (t[0] < this.Value[0] && this.Left != null)
            {
                return this.Left.Search(t);
            }
            else if (t[0] > this.Value[0] && this.Right != null)
            {
                return this.Right.Search(t);
            }
            return null;
        }
    }
}
