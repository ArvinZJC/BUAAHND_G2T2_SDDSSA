#region Using Directives
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
#endregion Using Directives

namespace Paint
{
    public partial class CanvasRectTracker : UserControl
    {
        public CanvasRectTracker(Panel canvas)
        {
            InitializeComponent();

            canvasTracked = canvas;
            Name += ("_" + canvasTracked.Name);
            Paint += new PaintEventHandler(CanvasRectTracker_Paint);
            MouseDown += new MouseEventHandler(CanvasRectTracker_MouseDown);
            MouseMove += new MouseEventHandler(CanvasRectTracker_MouseMove);
            MouseUp += new MouseEventHandler(CanvasRectTracker_MouseUp);

            CreateControlArea();
        } // end constructor RectTracker

        #region Enum Definition
        private enum CanvasResizeHandleLocation
        {
            None = 0,
            Bottom = 1,
            Right = 2,
            BottomRight = 3
        } // end enum CanvasResizeHandleLocation
        #endregion Enum Definition

        #region Members
        private const int canvasTrackedWidth_Min = 12;
        private const int canvasTrackedHeight_Min = 12;
        private const int canvasResizeHandleWidth = 10;
        private const int canvasResizeHandleHeight = 10;
        private readonly ApplicationInfo applicationInfo = new ApplicationInfo();
        private readonly Panel canvasTracked;
        private readonly Rectangle[] canvasResizeHandles = new Rectangle[3];
        private readonly Rectangle[] controlBorders = new Rectangle[4];
        private static Graphics g;
        private Size canvasResizeHandleSize = new Size(canvasResizeHandleWidth, canvasResizeHandleHeight);
        private CanvasResizeHandleLocation activeCanvasResizeHandle;
        private Point mouseDownLocation;
        private Point prevMouseLocation;
        private bool hasMoved = false;
        #endregion Members

        #region Private Methods
        private void CreateControlArea()
        {
            Bounds = new Rectangle(
                canvasTracked.Bounds.X - canvasResizeHandleWidth,
                canvasTracked.Bounds.Y - canvasResizeHandleHeight,
                canvasTracked.Bounds.Width + (canvasResizeHandleWidth * 2) + 1,
                canvasTracked.Bounds.Height + (canvasResizeHandleHeight * 2) + 1); // define the location and size of the control
            
            // create canvas resize handles
            canvasResizeHandles[0] = new Rectangle(
                new Point((Width - canvasResizeHandleWidth) / 2, Height - canvasResizeHandleHeight - 1),
                canvasResizeHandleSize); // bottom
            canvasResizeHandles[1] = new Rectangle(
                new Point(Width - canvasResizeHandleWidth - 1, (Height - canvasResizeHandleHeight) / 2),
                canvasResizeHandleSize); // right
            canvasResizeHandles[2] = new Rectangle(
                new Point(Width - canvasResizeHandleWidth - 1, Height - canvasResizeHandleHeight - 1),
                canvasResizeHandleSize); // bottom-right

            // define the window region associated with the control
            GraphicsPath path = new GraphicsPath();
            controlBorders[0] = new Rectangle(
                0,
                0,
                Width - canvasResizeHandleWidth - 1,
                canvasResizeHandleHeight + 1); // top
            controlBorders[1] = new Rectangle(
                canvasResizeHandleWidth + 1,
                Height - canvasResizeHandleHeight - 1,
                Width - canvasResizeHandleWidth - 1,
                canvasResizeHandleHeight + 1); // bottom
            controlBorders[2] = new Rectangle(
                0,
                canvasResizeHandleHeight + 1,
                canvasResizeHandleWidth + 1,
                Height - canvasResizeHandleHeight - 1); // left
            controlBorders[3] = new Rectangle(
                Width - canvasResizeHandleWidth - 1,
                0,
                canvasResizeHandleWidth + 1,
                Height - canvasResizeHandleHeight - 1); // right
            path.AddRectangle(controlBorders[0]);
            path.AddRectangle(controlBorders[1]);
            path.AddRectangle(controlBorders[2]);
            path.AddRectangle(controlBorders[3]);
            Region = new Region(path);

            g = CreateGraphics();
        } // end method CreateControlArea

        private void UpdateCursorStyle(int x, int y)
        {
            Point point = new Point(x, y);

            if (canvasResizeHandles[0].Contains(point))
            {
                activeCanvasResizeHandle = (CanvasResizeHandleLocation)1; // bottom
                Cursor.Current = Cursors.SizeNS;
            }
            else if (canvasResizeHandles[1].Contains(point))
            {
                activeCanvasResizeHandle = (CanvasResizeHandleLocation)2; // right
                Cursor.Current = Cursors.SizeWE;
            }
            else if (canvasResizeHandles[2].Contains(point))
            {
                activeCanvasResizeHandle = (CanvasResizeHandleLocation)3; // bottom-right
                Cursor.Current = Cursors.SizeNWSE;
            }
            else
            {
                activeCanvasResizeHandle = 0; // none
                Cursor.Current = Cursors.Arrow;
            } // end nested if...else
        } // end method UpdateCursorStyle
        #endregion Private Methods

        #region Control Events
        // execute when the control is redrawn
        private void CanvasRectTracker_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangles(Brushes.WhiteSmoke, canvasResizeHandles); // fill each canvas resize handle with the white smoke colour
            g.DrawRectangles(Pens.Black, canvasResizeHandles); // draw the borders of each canvas resize handle with the black colour and a width of 1
        } // end method CanvasRectTracker_Paint

        // execute when the mouse pointer is over the control and a mouse button is pressed
        private void CanvasRectTracker_MouseDown(object sender, MouseEventArgs e)
        {
            // keep the cursor style when the left mouse button is pressed.
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = new Point(e.X, e.Y);

                UpdateCursorStyle(e.X, e.Y);
            } // end if
        } // end method CanvasRectTracker_MouseDown

        // execute when the mouse pointer is moved over the control
        private void CanvasRectTracker_MouseMove(object sender, MouseEventArgs e)
        {
            // resize the canvas tracked when the left mouse button is pressed.
            if (e.Button == MouseButtons.Left)
            {
                // the control will not hidden immediately when the left mouse button is pressed unless the canvas tracked is being resized
                if (hasMoved)
                {
                    try
                    {
                        Visible = false;

                        // ensure that the width of the canvas tracked is not smaller than the minimum width
                        if (canvasTracked.Width < canvasTrackedWidth_Min)
                        {
                            canvasTracked.Width = canvasTrackedWidth_Min;
                            return;
                        } // end if

                        // ensure that the height of the canvas tracked is not smaller than the maximum height
                        if (canvasTracked.Height < canvasTrackedHeight_Min)
                        {
                            canvasTracked.Height = canvasTrackedHeight_Min;
                            return;
                        } // end if

                        switch ((int)activeCanvasResizeHandle)
                        {
                            // bottom
                            case 1:
                                canvasTracked.Height += (e.Y - prevMouseLocation.Y);
                                break;

                            // right
                            case 2:
                                canvasTracked.Width += (e.X - prevMouseLocation.X);
                                break;

                            // bottom-right
                            case 3:
                                canvasTracked.Width += (e.X - prevMouseLocation.X);
                                canvasTracked.Height += (e.Y - prevMouseLocation.Y);
                                break;
                        } // end switch-case

                        prevMouseLocation = new Point(e.X, e.Y);
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("There is not enough free memory or resources to complete operation.\nClose some programs, then try again.", applicationInfo.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // restore the size of the canvas tracked according to the latest mouse-down location
                        canvasTracked.Width -= (e.X - mouseDownLocation.X);
                        canvasTracked.Height -= (e.Y - mouseDownLocation.Y);

                        CreateControlArea();

                        Visible = true;
                    } // end try-catch
                }
                else
                {
                    prevMouseLocation = new Point(e.X, e.Y);
                    hasMoved = true;
                } // end if...else
            }
            else
            {
                hasMoved = false;
                Visible = true;

                UpdateCursorStyle(e.X, e.Y);
            } // end if...else
        } // end method CanvasRectTracker_MouseMove

        // execute when the mouse pointer is over the control and a mouse button is released
        private void CanvasRectTracker_MouseUp(object sender, MouseEventArgs e)
        {
            CreateControlArea();

            Visible = true;
        } // end method CanvasRectTracker_MouseUp
        #endregion Control Events
    } // end partial class CanvasRectTracker
} // end namespace Paint