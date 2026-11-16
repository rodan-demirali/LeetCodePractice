using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Easy
{
    public class Problem2409_CountDaysSpentTogether
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        static int sum = 0;
        public static TreeNode BstToGst(TreeNode root)
        {

            DFS(root);

            return root;

        }

        public static void DFS(TreeNode node)
        {
            // if(node != null) DFS(node.right);
            if (node == null) return;
            DFS(node.right);
            sum += node.val;
            node.val = sum;
            DFS(node.left);
            // if(node.left != null) DFS(node.left)


        }
    }
}

