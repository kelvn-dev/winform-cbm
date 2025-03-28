using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CBM.Customs {
  public class CBMCheckBox : CheckBox {

    #region Variables

    private Color onBackColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
    private Color onToggleColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
    private Color offBackColor = ColorTranslator.FromHtml(Constant.BOLD_GRAY_COLOR);
    private Color offToggleColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
    private bool solidStyle = true;

    #endregion

    #region Properties

    public Color OnBackColor {
      get { return onBackColor; }
      set {
        onBackColor = value;
        this.Invalidate();
      }
    }
    public Color OnToggleColor {
      get { return onToggleColor; }
      set {
        onToggleColor = value;
        this.Invalidate();
      }
    }
    public Color OffBackColor {
      get { return offBackColor; }
      set {
        offBackColor = value;
        this.Invalidate();
      }
    }
    public Color OffToggleColor {
      get { return offToggleColor; }
      set {
        offToggleColor = value;
        this.Invalidate();
      }
    }
    [Browsable(false)]
    public override string Text {
      get { return base.Text; }
      set { }
    }
    [DefaultValue(true)]
    public bool SolidStyle {
      get { return solidStyle; }
      set {
        solidStyle = value;
        this.Invalidate();
      }
    }

    #endregion

    public CBMCheckBox() {
      this.MinimumSize = new Size(90, 44);
    }

    #region Common

    private GraphicsPath GetFigurePath() {
      int arcSize = this.Height - 1;
      Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
      Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);
      GraphicsPath path = new GraphicsPath();
      path.StartFigure();
      path.AddArc(leftArc, 90, 180);
      path.AddArc(rightArc, 270, 180);
      path.CloseFigure();
      return path;
    }

    protected override void OnPaint(PaintEventArgs pevent) {
      int toggleSize = this.Height - 5;
      pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
      pevent.Graphics.Clear(this.Parent.BackColor);
      if (this.Checked) //ON
      {
        //Draw the control surface
        if (solidStyle)
          pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
        else pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
        //Draw the toggle
        pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
          new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
      }
      else //OFF 
      {
        //Draw the control surface
        if (solidStyle)
          pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
        else pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
        //Draw the toggle
        pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
          new Rectangle(2, 2, toggleSize, toggleSize));
      }
    }

    #endregion
  }
}
