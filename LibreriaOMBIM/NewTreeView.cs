using LibreriaOMBIM.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibreriaOMBIM
{
    public partial class NewTreeView : TreeView
    {
        Color backColor = Color.FromArgb(227, 251, 244);
        Font foreFont = new Font("Microsoft Yahei", 9F, FontStyle.Bold);

        Brush foreBrush = new SolidBrush(Color.FromArgb(81, 81, 81));
        Brush recBrush = new SolidBrush(Color.FromArgb(82, 218, 163));
        Brush recSelectedBrush = new SolidBrush(Color.FromArgb(248, 248, 255));

        Pen recPen = new Pen(new SolidBrush(Color.FromArgb(226, 226, 226)));
        Pen recHoverPen = new Pen(new SolidBrush(Color.FromArgb(82, 218, 163)));
        Pen linePen = new Pen(Color.FromArgb(226, 226, 226), 1);

        Image icon;

        public NewTreeView()
        {
            InitializeComponent();

            this.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            this.ItemHeight = 30; // node row height
            this.BackColor = backColor;
            this.ShowLines = true;
            this.HotTracking = true;
            this.Indent = 20;//node X value indent
            this.Scrollable = true;
            this.BorderStyle = BorderStyle.None;
            this.Font = foreFont;
        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            if (e.Node.Level == 0)//root node
            {
                if (!e.Node.IsExpanded)//The root node is not expanded
                {
                    icon = Resources.EyeOn16x16;
                }
                else // root node expansion
                {
                    icon = Resources.EyeOff16x16;
                }
                // Refresh the background color to prevent the font icon redraw overlay
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(227, 251, 244)), e.Bounds);
                // Redraw the icon, the first node X value defaults to 23, padding - left to 6, 17 = 23 - 6
                e.Graphics.DrawImage(icon, e.Node.Bounds.X - 17, e.Node.Bounds.Y + 5);
                //Redraw the font
                e.Graphics.DrawString(e.Node.Text, foreFont, foreBrush, e.Node.Bounds.Left + 16, e.Node.Bounds.Top + 4);
            }
            else
            {
                if (!e.Bounds.IsEmpty)//if the Bounds property of the child node is not empty (Empty), draw the node
                {
                    e.Graphics.FillRectangle(Brushes.White, e.Bounds);


                    // draw the connection line, 30 = 20 + 10, 10 is half the width of the icon, to ensure that the topEnd point is at the center of the icon, 15 is half the height of the line
                    Point start = new Point(e.Node.Bounds.X + 15, e.Node.Bounds.Y + 15);
                    Point middle = new Point(e.Node.Bounds.X - 30, e.Node.Bounds.Y + 15);
                    Point topEnd = new Point(e.Node.Bounds.X - 30, e.Node.Bounds.Y);
                    Point bottomEnd = new Point(e.Node.Bounds.X - 30, e.Node.Bounds.Y + 30);
                    e.Graphics.DrawLine(linePen, start, middle);
                    e.Graphics.DrawLine(linePen, middle, topEnd);
                    if (null != e.Node.NextNode)
                    {
                        e.Graphics.DrawLine(linePen, middle, bottomEnd);
                    }


                    // draw a text box, 145px wide can hold ten 10.5pt words, 55 = 23 + 20 + 12, text box distance from the upper and lower boundaries 4px
                    Rectangle box = new Rectangle(e.Bounds.Left + 55, e.Bounds.Top + 4, this.Width - 55 - 25, e.Bounds.Height - 8);

                    if (e.Node.IsSelected) // secondary node is selected
                    {
                        e.Graphics.FillRectangle(recBrush, box);
                        e.Graphics.DrawString(e.Node.Text, foreFont, recSelectedBrush, e.Node.Bounds.Left + 12, e.Node.Bounds.Top + 4);
                    }
                    else
                    {
                        if ((e.State & TreeNodeStates.Hot) != 0)//The mouse pointer is on the secondary node
                        {
                            e.Graphics.DrawRectangle(recHoverPen, box);
                        }
                        else
                        {
                            e.Graphics.DrawRectangle(recPen, box);
                        }
                        e.Graphics.DrawString(e.Node.Text, foreFont, foreBrush, e.Node.Bounds.Left + 12, e.Node.Bounds.Top + 4);
                    }
                }
            }

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            TreeNode tn = this.GetNodeAt(e.Location);
            if (0 != tn.Level)//Clicking on the first-level node does not make the selection effect of the secondary node disappear
            {
                this.SelectedNode = tn;
            }

            //The area to the right of the center point of the icon can also click to collapse and expand.
            Rectangle bounds = new Rectangle(tn.Bounds.Left - 17, tn.Bounds.Y, tn.Bounds.Width - 16, tn.Bounds.Height);
            if (tn != null && bounds.Contains(e.Location) == false)
            {
                if (tn.IsExpanded == false)
                    tn.Expand();
                else
                    tn.Collapse();
            }
        }

        TreeNode currentNode = null;
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            TreeNode tn = this.GetNodeAt(e.Location);
            Graphics g = this.CreateGraphics();
            if (currentNode != tn)
            {
                // draw the hover background of the current node
                if (null != tn)
                {
                    OnDrawNode(new DrawTreeNodeEventArgs(g, tn, new Rectangle(0, tn.Bounds.Y, this.Width - 4, tn.Bounds.Height), TreeNodeStates.Hot));
                }


                // Cancel the background of the node before the hover
                if (null != currentNode)
                {
                    OnDrawNode(new DrawTreeNodeEventArgs(g, currentNode, new Rectangle(0, currentNode.Bounds.Y, this.Width - 4, currentNode.Bounds.Height), TreeNodeStates.Default));
                }
            }
            currentNode = tn;
            g.Dispose();//Release Graphics resources
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            // Cancel the Hover background when removing the control
            if (currentNode != null)
            {
                Graphics g = this.CreateGraphics();
                OnDrawNode(new DrawTreeNodeEventArgs(g, currentNode, new Rectangle(0, currentNode.Bounds.Y, this.Width - 4, currentNode.Bounds.Height), TreeNodeStates.Default));

                currentNode = null; // the same node Leave after the Move has a Hover effect

            }
        }



        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            TreeNode tn = this.GetNodeAt(e.Location);
            //// icon center point to the right area double click fold and expand
            Rectangle bounds = new Rectangle(tn.Bounds.Left - 17, tn.Bounds.Y, tn.Bounds.Width - 16, tn.Bounds.Height);
            if (tn != null && bounds.Contains(e.Location) == false)
            {
                if (tn.IsExpanded == false)
                    tn.Expand();
                else
                    tn.Collapse();
            }
        }

    }

}
