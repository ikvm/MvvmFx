﻿using System;
using System.Collections;
#if !WEBGUI
using System.Windows.Forms;
#else
using Gizmox.WebGUI.Forms;
#endif

namespace MvvmFx.Windows.Forms
{
    internal class TreeNodeSorter : IComparer
    {
        // Compare the length of the strings, or the strings
        // themselves, if they are the same length.
        public int Compare(object x, object y)
        {
            var tx = x as TreeNode;
            if (tx == null)
                throw new ArgumentNullException("x", "Not a TreeNode");

            var ty = y as TreeNode;
            if (ty == null)
                throw new ArgumentNullException("x", "Not a TreeNode");

            return string.Compare(tx.Text, ty.Text, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
