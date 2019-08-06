#region Using Directives
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tools;
#endregion Using Directives

namespace Paint
{
    public partial class FrmMainInterface : RibbonForm
    {
        public FrmMainInterface()
        {
            InitializeComponent();
        } // end constructor FrmMainInterface

        #region Members
        private readonly ApplicationInfo applicationInfo = new ApplicationInfo();
        private readonly PaintingTools paintingTools = new PaintingTools();
        #endregion Members

        #region Private Methods
        private void InitialiseHomeControlStatus()
        {
            // Ribbon - Home - Tools
            ToolStripBtnNaturalPencil.Checked = false;
            ToolStripBtnFillWithColour.Checked = false;
            ToolStripBtnText.Checked = false;
            ToolStripBtnRubber.Checked = false;
            ToolStripBtnColourPicker.Checked = false;
            ToolStripBtnMagnifier.Checked = false;

            // Ribbon - Home - Brushes
            ToolStripSplitBtnExBrushes.BackColor = SystemColors.Control;
            ToolStripMenuItemBrush.Checked = false;
            ToolStripMenuItemCalligraphyBrush1.Checked = false;
            ToolStripMenuItemCalligraphyBrush2.Checked = false;
            ToolStripMenuItemAirbrush.Checked = false;
            ToolStripMenuItemOilBrush.Checked = false;
            ToolStripMenuItemCrayon_Brushes.Checked = false;
            ToolStripMenuItemMarker.Checked = false;
            ToolStripMenuItemWatercolourBrush.Checked = false;

            // Ribbon - Home - Shapes
            ToolStripBtnLine.Checked = false;
            ToolStripBtnCurve.Checked = false;
            ToolStripBtnOval.Checked = false;
            ToolStripBtnRectangle.Checked = false;
            ToolStripBtnRoundedRectangle.Checked = false;
            ToolStripBtnPolygon.Checked = false;
            ToolStripBtnTriangle.Checked = false;
            ToolStripBtnRightAngledTriangle.Checked = false;
            ToolStripBtnDiamond.Checked = false;
            ToolStripBtnPentagon.Checked = false;
            ToolStripBtnHexagon.Checked = false;
            ToolStripBtnRightArrow.Checked = false;
            ToolStripBtnLeftArrow.Checked = false;
            ToolStripBtnUpArrow.Checked = false;
            ToolStripBtnDownArrow.Checked = false;
            ToolStripBtn4PointStar.Checked = false;
            ToolStripBtn5PointStar.Checked = false;
            ToolStripBtn6PointStar.Checked = false;
            ToolStripBtnRoundedRectangleCallout.Checked = false;
            ToolStripBtnOvalCallout.Checked = false;
            ToolStripBtnCloudCallout.Checked = false;
            ToolStripBtnHeart.Checked = false;
            ToolStripBtnLightning.Checked = false;
            ToolStripDropDownBtnShapeOutline.Enabled = false;
            ToolStripDropDownBtnShapeFill.Enabled = false;

            // Ribbon - Home - Size
            ToolStripComboBoxExSize.Enabled = true;
            ToolStripComboBoxExSize.Text = "5";

            AvoidRibbonComboBoxDeadLock();
        } // end method InitialiseHomeControlStatus

        /**
         * avoid the ContextSwitchDeadLock exception relevant to the combo boxes in the ribbon;
         * this is just a temporary solution
         */
        private void AvoidRibbonComboBoxDeadLock()
        {
            if (ToolStripComboBoxExSize.Focused)
            {
                RibbonControlAdvNavbar.SelectedTab = ToolStripTabItemView;
                RibbonControlAdvNavbar.SelectedTab = ToolStripTabItemHome;
            } // end if
        } // end method AvoidRibbonComboBoxDeadLock
        #endregion Private Methods

        #region Control Events
        // execute when the form for the main interface is loaded
        private void FrmMainInterface_Load(object sender, EventArgs e)
        {
            ShowApplicationIcon = true; // the form for the main interface (temporary solution; waiting for Syncfusion Aug Update to fix it)
            RibbonControlAdvNavbar.Size = new Size(RibbonControlAdvNavbar.Size.Width, 205); // Ribbon
            SfBtnAboutPaint.Style.Border = new Pen(Color.DarkGray, 1); // Ribbon - File
            ToolStripMenuItemBrush.Checked = true; // Ribbon - Home - Brushes

            // Ribbon - Home - Shapes
            ToolStripDropDownBtnShapeOutline.Enabled = false;
            ToolStripDropDownBtnShapeFill.Enabled = false;

            int pixel = 1;
            object[] pixels = new object[100];

            for (int count = 0; count < 100; count++)
                pixels[count] = pixel++;

            ToolStripComboBoxExSize.Items.AddRange(pixels); // Ribbon - Home - Size

            // Ribbon - Home - Colours
            ColourDialogColour1.Color = ToolStripTxtColour1.BackColor;
            ColourDialogColour2.Color = ToolStripTxtColour2.BackColor;

            // Canvas
            CanvasRectTracker canvasRectTracker_PanelCanvas = new CanvasRectTracker(PanelCanvas);
            PanelCanvas.Parent.Controls.Add(canvasRectTracker_PanelCanvas);
        } // end method FrmMainInterface_Load

        // execute when the form for the main interface is being closed
        private void FrmMainInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            AvoidRibbonComboBoxDeadLock();
        } // end method FrmMainInterface_FormClosing

        #region Ribbon
        #region File
        private void SfBtnAboutPaint_Click(object sender, EventArgs e)
        {
            FrmAboutPaint aboutPaint = new FrmAboutPaint();

            aboutPaint.ShowDialog(this);
            aboutPaint.Dispose();
        } // end method SfBtnAboutPaint_Click
        #endregion File

        #region Home
        #region Tools
        private void ToolStripBtnNaturalPencil_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnNaturalPencil.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnNaturalPencil.Checked = true; // Ribbon - Home - Tools
                ToolStripComboBoxExSize.Text = "6"; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripBtnNaturalPencil_Click

        private void ToolStripBtnFillWithColour_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnFillWithColour.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnFillWithColour.Checked = true; // Ribbon - Home - Tools
                ToolStripComboBoxExSize.Enabled = false; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripBtnFillWithColour_Click

        private void ToolStripBtnText_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnText.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnText.Checked = true; // Ribbon - Home - Tools
                ToolStripComboBoxExSize.Enabled = false; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripBtnText_Click

        private void ToolStripBtnRubber_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnRubber.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnRubber.Checked = true; // Ribbon - Home - Tools
                ToolStripComboBoxExSize.Text = "25"; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripBtnRubber_Click

        private void ToolStripBtnColourPicker_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnColourPicker.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnColourPicker.Checked = true; // Ribbon - Home - Tools
                ToolStripComboBoxExSize.Enabled = false; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripBtnColourPicker_Click

        private void ToolStripBtnMagnifier_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnMagnifier.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnMagnifier.Checked = true; // Ribbon - Home - Tools
                ToolStripComboBoxExSize.Enabled = false; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripBtnMagnifier_Click
        #endregion Tools

        #region Brushes
        private void ToolStripSplitBtnExBrushes_Click(object sender, EventArgs e)
        {
            // the property "Tag" of the control "ToolStripSplitBtnExBrushes" records last brush used
            switch (ToolStripSplitBtnExBrushes.Tag)
            {
                // brush
                case 0:
                default:
                    if (!ToolStripMenuItemBrush.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemBrush.Checked = true; // Ribbon - Home - Brushes
                    } // end if
                    break;

                // calligraphy brush 1
                case 1:
                    if (!ToolStripMenuItemCalligraphyBrush1.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemCalligraphyBrush1.Checked = true; // Ribbon - Home - Brushes
                    } // end if
                    break;

                // calligraphy brush 2
                case 2:
                    if (!ToolStripMenuItemCalligraphyBrush2.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemCalligraphyBrush2.Checked = true; // Ribbon - Home - Brushes
                    } // end if
                    break;

                // airbrush
                case 3:
                    if (!ToolStripMenuItemAirbrush.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemAirbrush.Checked = true; // Ribbon - Home - Brushes
                    } // end if
                    break;

                // oil brush
                case 4:
                    if (!ToolStripMenuItemOilBrush.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemOilBrush.Checked = true; // Ribbon - Home - Brushes
                    } // end if
                    break;

                // crayon
                case 5:
                    if (!ToolStripMenuItemCrayon_Brushes.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemCrayon_Brushes.Checked = true; // Ribbon - Home - Brushes
                    } // end if
                    break;

                // marker
                case 6:
                    if (!ToolStripMenuItemMarker.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemMarker.Checked = true; // Ribbon - Home - Brushes
                    } // end if
                    break;

                // watercolour brush
                case 7:
                    if (!ToolStripMenuItemWatercolourBrush.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemWatercolourBrush.Checked = true; // Ribbon - Home - Brushes
                    } // end if
                    break;
            } // end switch-case
        } // end method ToolStripSplitBtnExBrushes_Click

        private void ToolStripMenuItemBrush_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemBrush.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemBrush.Checked = true; // Ribbon - Home - Brushes
            } // end if
        } // end method ToolStripMenuItemBrush_Click

        private void ToolStripMenuItemBrush_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemBrush.Checked)
            {
                // Ribbon - Home - Brushes
                ToolStripExBrushes.Image = Properties.Resources.Brush;
                ToolStripSplitBtnExBrushes.Image = Properties.Resources.Brush;
                ToolStripSplitBtnExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitBtnExBrushes.Tag = 0;

                ToolStripComboBoxExSize.Text = "5"; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripMenuItemBrush_CheckedChanged

        private void ToolStripMenuItemCalligraphyBrush1_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemCalligraphyBrush1.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemCalligraphyBrush1.Checked = true; // Ribbon - Home - Brushes
            } // end if
        } // end method ToolStripMenuItemCalligraphyBrush1_Click

        private void ToolStripMenuItemCalligraphyBrush1_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemCalligraphyBrush1.Checked)
            {
                // Ribbon - Home - Brushes
                ToolStripExBrushes.Image = Properties.Resources.Calligraphy_Brush_1;
                ToolStripSplitBtnExBrushes.Image = Properties.Resources.Calligraphy_Brush_1;
                ToolStripSplitBtnExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitBtnExBrushes.Tag = 1;

                ToolStripComboBoxExSize.Text = "5"; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripMenuItemCalligraphyBrush1_CheckedChanged

        private void ToolStripMenuItemCalligraphyBrush2_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemCalligraphyBrush2.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemCalligraphyBrush2.Checked = true; // Ribbon - Home - Brushes
            } // end if
        } // end method ToolStripMenuItemCalligraphyBrush2_Click

        private void ToolStripMenuItemCalligraphyBrush2_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemCalligraphyBrush2.Checked)
            {
                // Ribbon - Home - Brushes
                ToolStripExBrushes.Image = Properties.Resources.Calligraphy_Brush_2;
                ToolStripSplitBtnExBrushes.Image = Properties.Resources.Calligraphy_Brush_2;
                ToolStripSplitBtnExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitBtnExBrushes.Tag = 2;

                ToolStripComboBoxExSize.Text = "5"; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripMenuItemCalligraphyBrush2_CheckedChanged

        private void ToolStripMenuItemAirbrush_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemAirbrush.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemAirbrush.Checked = true; // Ribbon - Home - Brushes
            } // end if
        } // end method ToolStripMenuItemAirbrush_Click

        private void ToolStripMenuItemAirbrush_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemAirbrush.Checked)
            {
                // Ribbon - Home - Brushes
                ToolStripExBrushes.Image = Properties.Resources.Airbrush;
                ToolStripSplitBtnExBrushes.Image = Properties.Resources.Airbrush;
                ToolStripSplitBtnExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitBtnExBrushes.Tag = 3;

                ToolStripComboBoxExSize.Text = "10"; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripMenuItemAirbrush_CheckedChanged

        private void ToolStripMenuItemOilBrush_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemOilBrush.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemOilBrush.Checked = true; // Ribbon - Home - Brushes
            } // end if
        } // end method ToolStripMenuItemOilBrush_Click

        private void ToolStripMenuItemOilBrush_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemOilBrush.Checked)
            {
                // Ribbon - Home - Brushes
                ToolStripExBrushes.Image = Properties.Resources.Oil_Brush;
                ToolStripSplitBtnExBrushes.Image = Properties.Resources.Oil_Brush;
                ToolStripSplitBtnExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitBtnExBrushes.Tag = 4;

                ToolStripComboBoxExSize.Text = "50"; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripMenuItemOilBrush_CheckedChanged

        private void ToolStripMenuItemCrayon_Brushes_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemCrayon_Brushes.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemCrayon_Brushes.Checked = true; // Ribbon - Home - Brushes
            } // end if
        } // end method ToolStripMenuItemCrayon_Brushes_Click

        private void ToolStripMenuItemCrayon_Brushes_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemCrayon_Brushes.Checked)
            {
                // Ribbon - Home - Brushes
                ToolStripExBrushes.Image = Properties.Resources.Crayon;
                ToolStripSplitBtnExBrushes.Image = Properties.Resources.Crayon;
                ToolStripSplitBtnExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitBtnExBrushes.Tag = 5;

                ToolStripComboBoxExSize.Text = "20"; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripMenuItemCrayon_Brushes_CheckedChanged

        private void ToolStripMenuItemMarker_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemMarker.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemMarker.Checked = true; // Ribbon - Home - Brushes
            } // end if
        } // end method ToolStripMenuItemMarker_Click

        private void ToolStripMenuItemMarker_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemMarker.Checked)
            {
                // Ribbon - Home - Brushes
                ToolStripExBrushes.Image = Properties.Resources.Marker;
                ToolStripSplitBtnExBrushes.Image = Properties.Resources.Marker;
                ToolStripSplitBtnExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitBtnExBrushes.Tag = 6;

                ToolStripComboBoxExSize.Text = "5"; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripMenuItemMarker_CheckedChanged

        private void ToolStripMenuItemWatercolourBrush_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemWatercolourBrush.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemWatercolourBrush.Checked = true; // Ribbon - Home - Brushes
            } // end if
        } // end method ToolStripMenuItemWatercolourBrush_Click

        private void ToolStripMenuItemWatercolourBrush_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemWatercolourBrush.Checked)
            {
                // Ribbon - Home - Brushes
                ToolStripExBrushes.Image = Properties.Resources.Watercolour_Brush;
                ToolStripSplitBtnExBrushes.Image = Properties.Resources.Watercolour_Brush;
                ToolStripSplitBtnExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitBtnExBrushes.Tag = 7;

                ToolStripComboBoxExSize.Text = "50"; // Ribbon - Home - Size
            } // end if
        } // end method ToolStripMenuItemWatercolourBrush_CheckedChanged
        #endregion Brushes

        #region Shapes
        private void ToolStripBtnLine_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnLine.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnLine.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
            } // end if
        } // end method ToolStripBtnLine_Click

        private void ToolStripBtnCurve_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnCurve.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnCurve.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
            } // end if
        } // end method ToolStripBtnCurve_Click

        private void ToolStripBtnOval_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnOval.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnOval.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnOval_Click

        private void ToolStripBtnRectangle_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnRectangle.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnRectangle.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnRectangle_Click

        private void ToolStripBtnRoundedRectangle_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnRoundedRectangle.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnRoundedRectangle.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnRoundedRectangle_Click

        private void ToolStripBtnPolygon_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnPolygon.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnPolygon.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnPolygon_Click

        private void ToolStripBtnTriangle_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnTriangle.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnTriangle.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnTriangle_Click

        private void ToolStripBtnRightAngledTriangle_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnRightAngledTriangle.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnRightAngledTriangle.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnRightAngledTriangle_Click

        private void ToolStripBtnDiamond_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnDiamond.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnDiamond.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnDiamond_Click

        private void ToolStripBtnPentagon_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnPentagon.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnPentagon.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnPentagon_Click

        private void ToolStripBtnHexagon_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnHexagon.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnHexagon.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnHexagon_Click

        private void ToolStripBtnRightArrow_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnRightArrow.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnRightArrow.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnRightArrow_Click

        private void ToolStripBtnLeftArrow_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnLeftArrow.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnLeftArrow.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnLeftArrow_Click

        private void ToolStripBtnUpArrow_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnUpArrow.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnUpArrow.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnUpArrow_Click

        private void ToolStripBtnDownArrow_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnDownArrow.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnDownArrow.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnDownArrow_Click

        private void ToolStripBtn4PointStar_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtn4PointStar.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtn4PointStar.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtn4PointStar_Click

        private void ToolStripBtn5PointStar_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtn5PointStar.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtn5PointStar.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtn5PointStar_Click

        private void ToolStripBtn6PointStar_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtn6PointStar.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtn6PointStar.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtn6PointStar_Click

        private void ToolStripBtnRoundedRectangleCallout_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnRoundedRectangleCallout.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnRoundedRectangleCallout.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnRoundedRectangleCallout_Click

        private void ToolStripBtnOvalCallout_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnOvalCallout.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnOvalCallout.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnOvalCallout_Click

        private void ToolStripBtnCloudCallout_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnCloudCallout.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnCloudCallout.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnCloudCallout_Click

        private void ToolStripBtnHeart_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnHeart.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnHeart.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnHeart_Click

        private void ToolStripBtnLightning_Click(object sender, EventArgs e)
        {
            if (!ToolStripBtnLightning.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripBtnLightning.Checked = true;
                ToolStripDropDownBtnShapeOutline.Enabled = true;
                ToolStripDropDownBtnShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripBtnLightning_Click
        #endregion Shapes

        #region Size
        private void ToolStripComboBoxExSize_TextChanged(object sender, EventArgs e)
        {
            if (!paintingTools.CheckInputForSize(ToolStripComboBoxExSize.Text))
            {
                ToolStripComboBoxExSize.Text = "5";

                MessageBox.Show("Invalid input value. The value will be set to 5px.", applicationInfo.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // end if
        } // end method ToolStripComboBoxExSize_TextChanged
        #endregion Size

        #region Colours
        private void ToolStripBtnColour1_Click(object sender, EventArgs e)
        {
            DialogResult colourDialogResultColour1 = ColourDialogColour1.ShowDialog();

            if (colourDialogResultColour1 == DialogResult.OK)
                ToolStripTxtColour1.BackColor = ColourDialogColour1.Color;

            RibbonControlAdvNavbar.Refresh();
        } // end method ToolStripBtnColour1_Click

        private void ToolStripBtnColour2_Click(object sender, EventArgs e)
        {
            DialogResult colourDialogResultColour2 = ColourDialogColour2.ShowDialog();

            if (colourDialogResultColour2 == DialogResult.OK)
                ToolStripTxtColour2.BackColor = ColourDialogColour2.Color;

            RibbonControlAdvNavbar.Refresh();
        } // end method ToolStripBtnColour2_Click
        #endregion Colours
        #endregion Home

        #region View

        #endregion View
        #endregion Ribbon

        #endregion Control Events
    } // end partial class FrmMainInterface
} // end namespace Paint