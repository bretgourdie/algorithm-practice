using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice.Common
{
    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode() : base() { }
        public BinaryTreeNode(T data) : base(data) { }
        public BinaryTreeNode(
            T data,
            BinaryTreeNode<T> left,
            BinaryTreeNode<T> right)
        {
            base.Value = data;
            var children = new NodeList<T>(2);
            children[0] = left;
            children[1] = right;

            base.Neighbords = children;
        }

        public BinaryTreeNode<T> Left 
        {
            get
            {
                return _getNode(Child.Left);
            }
            set
            {
                _setNode(Child.Left, value);
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                return _getNode(Child.Right);
            }
            set
            {
                _setNode(Child.Right, value);
            }
        }

        private enum Child
        {
            Left,
            Right
        }

        private BinaryTreeNode<T> _getNode(Child child)
        {
            if (base.Neighbords == null)
            {
                return null;
            }
            else
            {
                var index = _getChildIndex(child);
                return (BinaryTreeNode<T>)base.Neighbords[index];
            }
        }

        private void _setNode(Child child, BinaryTreeNode<T> value)
        {
            if (base.Neighbords == null)
            {
                base.Neighbords = new NodeList<T>(2);
            }
            var index = _getChildIndex(child);
            base.Neighbords[index] = value;
        }

        private int _getChildIndex(Child child)
        {
            int index = child == Child.Left ? 0 : 1;
            return index;
        }
    }
}
