using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

///功能：自定义datagridview中的col类别，主要用于进度显示
namespace V5_WinControls.DataGrid {
    public class DataGridViewProgressBarColumn : DataGridViewTextBoxColumn {

        public DataGridViewProgressBarColumn() {
            this.CellTemplate = new DataGridViewProgressBarCell();
        }

        public override DataGridViewCell CellTemplate {
            get { return base.CellTemplate; }

            set {
                if (!(value is DataGridViewProgressBarCell)) {
                    throw new InvalidCastException("DataGridViewProgressBarCell 错误");
                }
                base.CellTemplate = value;
            }

        }

        public int Maximum {
            get {
                return ((DataGridViewProgressBarCell)this.CellTemplate).Maximum;
            }
            set {
                if (this.Maximum == value)
                    return;
                ((DataGridViewProgressBarCell)this.CellTemplate).Maximum = value;

                if (this.DataGridView == null)
                    return;

                int rowCount = this.DataGridView.RowCount;

                for (int i = 0; i < rowCount; i++) {
                    DataGridViewRow r = this.DataGridView.Rows.SharedRow(i);

                    ((DataGridViewProgressBarCell)r.Cells[this.Index]).Maximum = value;

                }
            }
        }

        public int Mimimum {
            get {
                return ((DataGridViewProgressBarCell)this.CellTemplate).Mimimum;
            }

            set {
                if (this.Mimimum == value)

                    return;
                ((DataGridViewProgressBarCell)this.CellTemplate).Mimimum = value;

                if (this.DataGridView == null)
                    return;

                int rowCount = this.DataGridView.RowCount;

                for (int i = 0; i < rowCount; i++) {

                    DataGridViewRow r = this.DataGridView.Rows.SharedRow(i);

                    ((DataGridViewProgressBarCell)r.Cells[this.Index]).Mimimum = value;

                }

            }

        }

    }

    public class DataGridViewProgressBarCell : DataGridViewTextBoxCell {

        public DataGridViewProgressBarCell() {
            this.maximumValue = 100;
            this.mimimumValue = 0;
        }

        private int maximumValue;
        public int Maximum {
            get { return this.maximumValue; }
            set { this.maximumValue = value; }
        }

        private int mimimumValue;
        public int Mimimum {
            get { return this.mimimumValue; }
            set { this.mimimumValue = value; }
        }

        public override Type ValueType {
            get { return typeof(int); }
        }

        public override object DefaultNewRowValue {
            get { return 0; }
        }


        public override object Clone() {
            DataGridViewProgressBarCell cell = (DataGridViewProgressBarCell)base.Clone();
            cell.Maximum = this.Maximum;
            cell.Mimimum = this.Mimimum;
            return cell;

        }

        protected override void Paint(Graphics graphics,
            Rectangle clipBounds, Rectangle cellBounds,
            int rowIndex, DataGridViewElementStates cellState,
            object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts) {
            int intValue = 0;
            if (value is int)
                intValue = (int)value;

            if (intValue < this.mimimumValue)
                intValue = this.mimimumValue;

            if (intValue > this.maximumValue)
                intValue = this.maximumValue;

            double rate = (double)(intValue - this.mimimumValue) / (this.maximumValue - this.mimimumValue);

            if ((paintParts & DataGridViewPaintParts.Border) == DataGridViewPaintParts.Border) {
                this.PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
            }

            Rectangle borderRect = this.BorderWidths(advancedBorderStyle);
            Rectangle paintRect = new Rectangle(cellBounds.Left + borderRect.Left, cellBounds.Top + borderRect.Top,
                cellBounds.Width - borderRect.Right, cellBounds.Height - borderRect.Bottom);

            bool isSelected = (cellState & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected;

            Color bkColor;

            if (isSelected && (paintParts & DataGridViewPaintParts.SelectionBackground) == DataGridViewPaintParts.SelectionBackground) {
                bkColor = cellStyle.SelectionBackColor;
            }
            else {
                bkColor = cellStyle.BackColor;
            }


            if ((paintParts & DataGridViewPaintParts.Background) == DataGridViewPaintParts.Background) {
                using (SolidBrush backBrush = new SolidBrush(bkColor)) {
                    graphics.FillRectangle(backBrush, paintRect);
                }
            }

            paintRect.Offset(cellStyle.Padding.Right, cellStyle.Padding.Top);
            paintRect.Width -= cellStyle.Padding.Horizontal;
            paintRect.Height -= cellStyle.Padding.Vertical;

            if ((paintParts & DataGridViewPaintParts.ContentForeground) == DataGridViewPaintParts.ContentForeground) {
                if (ProgressBarRenderer.IsSupported) {
                    ProgressBarRenderer.DrawHorizontalBar(graphics, paintRect);
                    Rectangle barBounds = new Rectangle(paintRect.Left + 3, paintRect.Top + 1, paintRect.Width - 4, paintRect.Height - 2);

                    barBounds.Width = (int)Math.Round(barBounds.Width * rate);
                    ProgressBarRenderer.DrawHorizontalChunks(graphics, barBounds);
                }

                else {
                    graphics.FillRectangle(Brushes.White, paintRect);
                    graphics.DrawRectangle(Pens.DarkGray, paintRect);

                    Rectangle barBounds = new Rectangle(paintRect.Left + 1, paintRect.Top + 2, paintRect.Width - 1, paintRect.Height - 4);

                    barBounds.Width = (int)Math.Round(barBounds.Width * rate);
                    graphics.FillRectangle(Brushes.YellowGreen, barBounds);
                }
            }

            if (this.DataGridView.CurrentCellAddress.X == this.ColumnIndex && this.DataGridView.CurrentCellAddress.Y == this.RowIndex &&
                (paintParts & DataGridViewPaintParts.Focus) == DataGridViewPaintParts.Focus && this.DataGridView.Focused) {
                Rectangle focusRect = paintRect;
                focusRect.Inflate(-3, -3);
                ControlPaint.DrawFocusRectangle(graphics, focusRect);
            }

            if ((paintParts & DataGridViewPaintParts.ContentForeground) == DataGridViewPaintParts.ContentForeground) {
                string txt = string.Format("{0}%", Math.Round(rate * 100));
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;

                Color fColor = cellStyle.ForeColor;
                paintRect.Inflate(-2, -2);
                TextRenderer.DrawText(graphics, txt, cellStyle.Font,
                    paintRect, fColor, flags);

            }

            if ((paintParts & DataGridViewPaintParts.ErrorIcon) == DataGridViewPaintParts.ErrorIcon &&
                this.DataGridView.ShowCellErrors && !string.IsNullOrEmpty(errorText)) {
                Rectangle iconBounds = this.GetErrorIconBounds(graphics, cellStyle, rowIndex);
                iconBounds.Offset(cellBounds.X, cellBounds.Y);
                this.PaintErrorIcon(graphics, iconBounds, cellBounds, errorText);

            }

        }

    }
}
