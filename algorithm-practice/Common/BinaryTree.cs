﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice.Common
{
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> root;

        public BinaryTree()
        {
            this.root = null;
        }

        public virtual void Clear()
        {
            root = null;
        }

        public BinaryTreeNode<T> Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }
    }
}