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
            this.SfBtnAboutPaint.Style.Border = new Pen(Color.DarkGray, 1);
        } // end constructor FrmMainInterface

        #region Members
        private readonly ApplicationInfo applicationInfo = new ApplicationInfo();
        private readonly PaintingTools paintingTools = new PaintingTools();
        #endregion Members

        #region Private Methods
        private void InitialiseHomeControlStatus()
        {
            // Home - Tools
            ToolStripButtonPencil.Checked = false;
            ToolStripButtonFillWithColour.Checked = false;
            ToolStripButtonText.Checked = false;
            ToolStripButtonRubber.Checked = false;
            ToolStripButtonColourPicker.Checked = false;
            ToolStripButtonMagnifier.Checked = false;

            // Home - Brushes
            ToolStripSplitButtonExBrushes.BackColor = SystemColors.Control;
            ToolStripMenuItemBrush.Checked = false;
            ToolStripMenuItemCalligraphyBrush1.Checked = false;
            ToolStripMenuItemCalligraphyBrush2.Checked = false;
            ToolStripMenuItemAirbrush.Checked = false;
            ToolStripMenuItemOilBrush.Checked = false;
            ToolStripMenuItemCrayon_Brushes.Checked = false;
            ToolStripMenuItemMarker.Checked = false;
            ToolStripMenuItemNaturalPencil_Brushes.Checked = false;
            ToolStripMenuItemWatercolourBrush.Checked = false;

            // Home - Shapes
            ToolStripButtonLine.Checked = false;
            ToolStripButtonCurve.Checked = false;
            ToolStripButtonOval.Checked = false;
            ToolStripButtonRectangle.Checked = false;
            ToolStripButtonRoundedRectangle.Checked = false;
            ToolStripButtonPolygon.Checked = false;
            ToolStripButtonTriangle.Checked = false;
            ToolStripButtonRightAngledTriangle.Checked = false;
            ToolStripButtonDiamond.Checked = false;
            ToolStripButtonPentagon.Checked = false;
            ToolStripButtonHexagon.Checked = false;
            ToolStripButtonRightArrow.Checked = false;
            ToolStripButtonLeftArrow.Checked = false;
            ToolStripButtonUpArrow.Checked = false;
            ToolStripButtonDownArrow.Checked = false;
            ToolStripButton4PointStar.Checked = false;
            ToolStripButton5PointStar.Checked = false;
            ToolStripButton6PointStar.Checked = false;
            ToolStripButtonRoundedRectangleCallout.Checked = false;
            ToolStripButtonOvalCallout.Checked = false;
            ToolStripButtonCloudCallout.Checked = false;
            ToolStripButtonHeart.Checked = false;
            ToolStripButtonLightning.Checked = false;
            ToolStripDropDownButtonShapeOutline.Enabled = false;
            ToolStripDropDownButtonShapeFill.Enabled = false;

            ToolStripComboBoxExSize.Enabled = true; // Home - Size
        } // end method InitialiseHomeControlStatus
        #endregion Private Methods

        #region Control Events
        // execute when the form for the main interface is loaded
        private void FrmMainInterface_Load(object sender, EventArgs e)
        {
            ToolStripMenuItemBrush.Checked = true; // Home - Brushes

            // Home - Shapes
            ToolStripDropDownButtonShapeOutline.Enabled = false;
            ToolStripDropDownButtonShapeFill.Enabled = false;

            ToolStripComboBoxExSize.Text = "5"; // Home - Size
        } // end method FrmMainInterface_Load

        #region File
        private void SfBtnAboutPaint_Click(object sender, EventArgs e)
        {
            FrmAboutPaint aboutPaint = new FrmAboutPaint();

            aboutPaint.ShowDialog(this);
        } // end method SfBtnAboutPaint_Click
        #endregion File

        #region Home
        #region Tools
        private void ToolStripButtonPencil_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonPencil.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonPencil.Checked = true;
            } // end if
        } // end method ToolStripButtonPencil_Click

        private void ToolStripButtonFillWithColour_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonFillWithColour.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonFillWithColour.Checked = true;
                ToolStripComboBoxExSize.Enabled = false;
            } // end if
        } // end method ToolStripButtonFillWithColour_Click

        private void ToolStripButtonText_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonText.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonText.Checked = true;
                ToolStripComboBoxExSize.Enabled = false;
            } // end if
        } // end method ToolStripButtonText_Click

        private void ToolStripButtonRubber_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonRubber.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonRubber.Checked = true;
            } // end if
        } // end method ToolStripButtonRubber_Click

        private void ToolStripButtonColourPicker_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonColourPicker.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonColourPicker.Checked = true;
                ToolStripComboBoxExSize.Enabled = false;
            } // end if
        } // end method ToolStripButtonColourPicker_Click

        private void ToolStripButtonMagnifier_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonMagnifier.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonMagnifier.Checked = true;
                ToolStripComboBoxExSize.Enabled = false;
            } // end if
        } // end method ToolStripButtonMagnifier_Click
        #endregion Tools

        #region Brushes
        private void ToolStripSplitButtonExBrushes_Click(object sender, EventArgs e)
        {
            // the property "Tag" of the control "ToolStripSplitButtonExBrushes" records last brush used
            switch (ToolStripSplitButtonExBrushes.Tag)
            {
                // brush
                case 0:
                    if (!ToolStripMenuItemBrush.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemBrush.Checked = true;
                    } // end if
                    break;

                // calligraphy brush 1
                case 1:
                    if (!ToolStripMenuItemCalligraphyBrush1.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemCalligraphyBrush1.Checked = true;
                    } // end if
                    break;

                // calligraphy brush 2
                case 2:
                    if (!ToolStripMenuItemCalligraphyBrush2.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemCalligraphyBrush2.Checked = true;
                    } // end if
                    break;

                // airbrush
                case 3:
                    if (!ToolStripMenuItemAirbrush.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemAirbrush.Checked = true;
                    } // end if
                    break;

                // oil brush
                case 4:
                    if (!ToolStripMenuItemOilBrush.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemOilBrush.Checked = true;
                    } // end if
                    break;

                // crayon
                case 5:
                    if (!ToolStripMenuItemCrayon_Brushes.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemCrayon_Brushes.Checked = true;
                    } // end if
                    break;

                // marker
                case 6:
                    if (!ToolStripMenuItemMarker.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemMarker.Checked = true;
                    } // end if
                    break;

                // natural pencil
                case 7:
                    if (!ToolStripMenuItemNaturalPencil_Brushes.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemNaturalPencil_Brushes.Checked = true;
                    } // end if
                    break;

                // watercolour brush
                case 8:
                    if (!ToolStripMenuItemWatercolourBrush.Checked)
                    {
                        InitialiseHomeControlStatus();

                        ToolStripMenuItemWatercolourBrush.Checked = true;
                    } // end if
                    break;

                default:
                    InitialiseHomeControlStatus();
                    ToolStripMenuItemBrush.Checked = true;
                    break;
            } // end switch-case
        } // end method ToolStripSplitButtonExBrushes_Click

        private void ToolStripMenuItemBrush_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemBrush.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemBrush.Checked = true;
            } // end if
        } // end method ToolStripMenuItemBrush_Click

        private void ToolStripMenuItemBrush_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemBrush.Checked)
            {
                ToolStripSplitButtonExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitButtonExBrushes.Image = Properties.Resources.Brush;
                ToolStripSplitButtonExBrushes.Tag = 0;
                ToolStripMenuItemBrush.BackColor = SystemColors.ButtonShadow;
            }
            else
                ToolStripMenuItemBrush.BackColor = SystemColors.Control;
        } // end method ToolStripMenuItemBrush_CheckedChanged

        private void ToolStripMenuItemCalligraphyBrush1_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemCalligraphyBrush1.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemCalligraphyBrush1.Checked = true;
            } // end if
        } // end method ToolStripMenuItemCalligraphyBrush1_Click

        private void ToolStripMenuItemCalligraphyBrush1_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemCalligraphyBrush1.Checked)
            {
                ToolStripSplitButtonExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitButtonExBrushes.Image = Properties.Resources.Calligraphy_Brush_1;
                ToolStripSplitButtonExBrushes.Tag = 1;
                ToolStripMenuItemCalligraphyBrush1.BackColor = SystemColors.ButtonShadow;
            }
            else
                ToolStripMenuItemCalligraphyBrush1.BackColor = SystemColors.Control;
        } // end method ToolStripMenuItemCalligraphyBrush1_CheckedChanged

        private void ToolStripMenuItemCalligraphyBrush2_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemCalligraphyBrush2.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemCalligraphyBrush2.Checked = true;
            } // end if
        } // end method ToolStripMenuItemCalligraphyBrush2_Click

        private void ToolStripMenuItemCalligraphyBrush2_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemCalligraphyBrush2.Checked)
            {
                ToolStripSplitButtonExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitButtonExBrushes.Image = Properties.Resources.Calligraphy_Brush_2;
                ToolStripSplitButtonExBrushes.Tag = 2;
                ToolStripMenuItemCalligraphyBrush2.BackColor = SystemColors.ButtonShadow;
            }
            else
                ToolStripMenuItemCalligraphyBrush2.BackColor = SystemColors.Control;
        } // end method ToolStripMenuItemCalligraphyBrush2_CheckedChanged

        private void ToolStripMenuItemAirbrush_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemAirbrush.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemAirbrush.Checked = true;
            } // end if
        } // end method ToolStripMenuItemAirbrush_Click

        private void ToolStripMenuItemAirbrush_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemAirbrush.Checked)
            {
                ToolStripSplitButtonExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitButtonExBrushes.Image = Properties.Resources.Airbrush;
                ToolStripSplitButtonExBrushes.Tag = 3;
                ToolStripMenuItemAirbrush.BackColor = SystemColors.ButtonShadow;
            }
            else
                ToolStripMenuItemAirbrush.BackColor = SystemColors.Control;
        } // end method ToolStripMenuItemAirbrush_CheckedChanged

        private void ToolStripMenuItemOilBrush_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemOilBrush.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemOilBrush.Checked = true;
            } // end if
        } // end method ToolStripMenuItemOilBrush_Click

        private void ToolStripMenuItemOilBrush_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemOilBrush.Checked)
            {
                ToolStripSplitButtonExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitButtonExBrushes.Image = Properties.Resources.Oil_Brush;
                ToolStripSplitButtonExBrushes.Tag = 4;
                ToolStripMenuItemOilBrush.BackColor = SystemColors.ButtonShadow;
            }
            else
                ToolStripMenuItemOilBrush.BackColor = SystemColors.Control;
        } // end method ToolStripMenuItemOilBrush_CheckedChanged

        private void ToolStripMenuItemCrayon_Brushes_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemCrayon_Brushes.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemCrayon_Brushes.Checked = true;
            } // end if
        } // end method ToolStripMenuItemCrayon_Brushes_Click

        private void ToolStripMenuItemCrayon_Brushes_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemCrayon_Brushes.Checked)
            {
                ToolStripSplitButtonExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitButtonExBrushes.Image = Properties.Resources.Crayon;
                ToolStripSplitButtonExBrushes.Tag = 5;
                ToolStripMenuItemCrayon_Brushes.BackColor = SystemColors.ButtonShadow;
            }
            else
                ToolStripMenuItemCrayon_Brushes.BackColor = SystemColors.Control;
        } // end method ToolStripMenuItemCrayon_Brushes_CheckedChanged

        private void ToolStripMenuItemMarker_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemMarker.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemMarker.Checked = true;
            } // end if
        } // end method ToolStripMenuItemMarker_Click

        private void ToolStripMenuItemMarker_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemMarker.Checked)
            {
                ToolStripSplitButtonExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitButtonExBrushes.Image = Properties.Resources.Marker;
                ToolStripSplitButtonExBrushes.Tag = 6;
                ToolStripMenuItemMarker.BackColor = SystemColors.ButtonShadow;
            }
            else
                ToolStripMenuItemMarker.BackColor = SystemColors.Control;
        } // end method ToolStripMenuItemMarker_CheckedChanged

        private void ToolStripMenuItemNaturalPencil_Brushes_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemNaturalPencil_Brushes.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemNaturalPencil_Brushes.Checked = true;
            } // end if
        } // end method ToolStripMenuItemNaturalPencil_Brushes_Click

        private void ToolStripMenuItemNaturalPencil_Brushes_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemNaturalPencil_Brushes.Checked)
            {
                ToolStripSplitButtonExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitButtonExBrushes.Image = Properties.Resources.Natural_Pencil;
                ToolStripSplitButtonExBrushes.Tag = 7;
                ToolStripMenuItemNaturalPencil_Brushes.BackColor = SystemColors.ButtonShadow;
            }
            else
                ToolStripMenuItemNaturalPencil_Brushes.BackColor = SystemColors.Control;
        } // end method ToolStripMenuItemNaturalPencil_Brushes_CheckedChanged

        private void ToolStripMenuItemWatercolourBrush_Click(object sender, EventArgs e)
        {
            if (!ToolStripMenuItemWatercolourBrush.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripMenuItemWatercolourBrush.Checked = true;
            } // end if
        } // end method ToolStripMenuItemWatercolourBrush_Click

        private void ToolStripMenuItemWatercolourBrush_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemWatercolourBrush.Checked)
            {
                ToolStripSplitButtonExBrushes.BackColor = SystemColors.ButtonShadow;
                ToolStripSplitButtonExBrushes.Image = Properties.Resources.Watercolour_Brush;
                ToolStripSplitButtonExBrushes.Tag = 8;
                ToolStripMenuItemWatercolourBrush.BackColor = SystemColors.ButtonShadow;
            }
            else
                ToolStripMenuItemWatercolourBrush.BackColor = SystemColors.Control;
        } // end method ToolStripMenuItemWatercolourBrush_CheckedChanged
        #endregion Brushes

        #region Shapes
        private void ToolStripButtonLine_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonLine.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonLine.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
            } // end if
        } // end method ToolStripButtonLine_Click

        private void ToolStripButtonCurve_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonCurve.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonCurve.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
            } // end if
        } // end method ToolStripButtonCurve_Click

        private void ToolStripButtonOval_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonOval.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonOval.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonOval_Click

        private void ToolStripButtonRectangle_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonRectangle.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonRectangle.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonRectangle_Click

        private void ToolStripButtonRoundedRectangle_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonRoundedRectangle.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonRoundedRectangle.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonRoundedRectangle_Click

        private void ToolStripButtonPolygon_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonPolygon.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonPolygon.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonPolygon_Click

        private void ToolStripButtonTriangle_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonTriangle.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonTriangle.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonTriangle_Click

        private void ToolStripButtonRightAngledTriangle_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonRightAngledTriangle.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonRightAngledTriangle.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonRightAngledTriangle_Click

        private void ToolStripButtonDiamond_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonDiamond.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonDiamond.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonDiamond_Click

        private void ToolStripButtonPentagon_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonPentagon.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonPentagon.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonPentagon_Click

        private void ToolStripButtonHexagon_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonHexagon.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonHexagon.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonHexagon_Click

        private void ToolStripButtonRightArrow_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonRightArrow.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonRightArrow.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonRightArrow_Click

        private void ToolStripButtonLeftArrow_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonLeftArrow.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonLeftArrow.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonLeftArrow_Click

        private void ToolStripButtonUpArrow_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonUpArrow.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonUpArrow.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonUpArrow_Click

        private void ToolStripButtonDownArrow_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonDownArrow.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonDownArrow.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonDownArrow_Click

        private void ToolStripButton4PointStar_Click(object sender, EventArgs e)
        {
            if (!ToolStripButton4PointStar.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButton4PointStar.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButton4PointStar_Click

        private void ToolStripButton5PointStar_Click(object sender, EventArgs e)
        {
            if (!ToolStripButton5PointStar.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButton5PointStar.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButton5PointStar_Click

        private void ToolStripButton6PointStar_Click(object sender, EventArgs e)
        {
            if (!ToolStripButton6PointStar.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButton6PointStar.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButton6PointStar_Click

        private void ToolStripButtonRoundedRectangleCallout_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonRoundedRectangleCallout.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonRoundedRectangleCallout.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonRoundedRectangleCallout_Click

        private void ToolStripButtonOvalCallout_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonOvalCallout.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonOvalCallout.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonOvalCallout_Click

        private void ToolStripButtonCloudCallout_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonCloudCallout.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonCloudCallout.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonCloudCallout_Click

        private void ToolStripButtonHeart_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonHeart.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonHeart.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonHeart_Click

        private void ToolStripButtonLightning_Click(object sender, EventArgs e)
        {
            if (!ToolStripButtonLightning.Checked)
            {
                InitialiseHomeControlStatus();

                ToolStripButtonLightning.Checked = true;
                ToolStripDropDownButtonShapeOutline.Enabled = true;
                ToolStripDropDownButtonShapeFill.Enabled = true;
            } // end if
        } // end method ToolStripButtonLightning_Click
        #endregion Shapes

        #region Size
        private void ToolStripComboBoxExSize_TextChanged(object sender, EventArgs e)
        {
            if (!paintingTools.CheckInputForSize(ToolStripComboBoxExSize.Text))
            {
                ToolStripComboBoxExSize.Text = "5";

                MessageBox.Show("Error! Invalid input value. The value will be set to 5px.", applicationInfo.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // end if
        } // end method ToolStripComboBoxExSize_TextChanged
        #endregion Size

        #endregion Home

        #region View

        #endregion View

        #endregion Control Events
    } // end partial class FrmMainInterface
} // end namespace Paint