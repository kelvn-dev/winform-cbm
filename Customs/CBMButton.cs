﻿using CBM.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBM.Customs {
  public class CBMButton: Button {

    private int borderSize;
    private int borderRadius;
    private Color borderColor;

    public int BorderSize { get => borderSize; set => borderSize = value; }
    public int BorderRadius { get => borderRadius; set => borderRadius = value; }
    public Color BorderColor { get => borderColor; set => borderColor = value; }

    public CBMButton() {
      this.FlatStyle = FlatStyle.Flat;
      this.FlatAppearance.BorderSize = 0;
      this.Resize += new EventHandler(Button_Resize);
    }

    private void Button_Resize(object sender, EventArgs e) {
      if (borderRadius > this.Height)
        borderRadius = this.Height;
    }

    protected override void OnPaint(PaintEventArgs pevent) {
      base.OnPaint(pevent);
      Rectangle rectSurface = this.ClientRectangle;
      Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
      int smoothSize = 2;
      if (borderSize > 0)
        smoothSize = borderSize;
      if (borderRadius > 2) { //Rounded button
        using (GraphicsPath pathSurface = UserControlUtils.GetFigurePath(rectSurface, borderRadius))
        using (GraphicsPath pathBorder = UserControlUtils.GetFigurePath(rectBorder, borderRadius - borderSize))
        using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
        using (Pen penBorder = new Pen(borderColor, borderSize)) {
          pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
          //Button surface
          this.Region = new Region(pathSurface);
          //Draw surface border for HD result
          pevent.Graphics.DrawPath(penSurface, pathSurface);
          //Button border                    
          if (borderSize >= 1)
            //Draw control border
            pevent.Graphics.DrawPath(penBorder, pathBorder);
        }
      }
      else //Normal button
      {
        pevent.Graphics.SmoothingMode = SmoothingMode.None;
        //Button surface
        this.Region = new Region(rectSurface);
        //Button border
        if (borderSize >= 1) {
          using (Pen penBorder = new Pen(borderColor, borderSize)) {
            penBorder.Alignment = PenAlignment.Inset;
            pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
          }
        }
      }
    }

    protected override void OnHandleCreated(EventArgs e) {
      base.OnHandleCreated(e);
      this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
    }
    private void Container_BackColorChanged(object sender, EventArgs e) {
      this.Invalidate();
    }

  }
}
