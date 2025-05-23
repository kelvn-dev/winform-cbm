﻿using CBM.Utilities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows;
using System.Windows.Forms;

namespace CBM.Customs {

  [DefaultEvent("_TextChanged")]
  public partial class CBMTextbox : UserControl {

    private Color borderColor = ColorTranslator.FromHtml(Constant.GRAY_COLOR);
    private Color borderFocusColor = Color.Black;
    private int borderSize = 2;
    private bool underlinedStyle = false;
    private bool isFocused = false;
    private int borderRadius = 0;
    private Color placeholderColor = ColorTranslator.FromHtml(Constant.PLACEHOLDER_COLOR);
    private string placeholderText = "";
    public bool isPlaceholder = false;
    private bool isPasswordChar = false;

    public CBMTextbox() {
      InitializeComponent();
      AssociateEvent();
    }

    #region -> Properties
    
    public Color BorderColor {
      get { return borderColor; }
      set {
        borderColor = value;
        this.Invalidate();
      }
    }
    
    public Color BorderFocusColor {
      get { return borderFocusColor; }
      set { borderFocusColor = value; }
    }
    
    public int BorderSize {
      get { return borderSize; }
      set {
        if (value >= 1) {
          borderSize = value;
          this.Invalidate();
        }
      }
    }
    
    public bool UnderlinedStyle {
      get { return underlinedStyle; }
      set {
        underlinedStyle = value;
        this.Invalidate();
      }
    }
    
    public bool PasswordChar {
      get { return isPasswordChar; }
      set {
        isPasswordChar = value;
        if (!isPlaceholder)
          textBox1.UseSystemPasswordChar = value;
      }
    }
    
    public bool Multiline {
      get { return textBox1.Multiline; }
      set { textBox1.Multiline = value; }
    }
    
    public override Color BackColor {
      get { return base.BackColor; }
      set {
        base.BackColor = value;
        textBox1.BackColor = value;
      }
    }
    
    public override Color ForeColor {
      get { return base.ForeColor; }
      set {
        base.ForeColor = value;
        textBox1.ForeColor = value;
      }
    }
    
    public override Font Font {
      get { return base.Font; }
      set {
        base.Font = value;
        textBox1.Font = value;
        if (this.DesignMode)
          UpdateControlHeight();
      }
    }
    
    public string Texts {
      get {
        if (isPlaceholder) return "";
        else return textBox1.Text;
      }
      set {
        textBox1.Text = value;
        isPlaceholder = false;
        SetPlaceholder();
      }
    }
    
    public int BorderRadius {
      get { return borderRadius; }
      set {
        if (value >= 0) {
          borderRadius = value;
          this.Invalidate();//Redraw control
        }
      }
    }
    
    public Color PlaceholderColor {
      get { return placeholderColor; }
      set {
        placeholderColor = value;
        if (isPlaceholder)
          textBox1.ForeColor = value;
      }
    }
    
    public string PlaceholderText {
      get { return placeholderText; }
      set {
        placeholderText = value;
        textBox1.Text = "";
        SetPlaceholder();
      }
    }
    #endregion

    public bool IsFocused { get => isFocused; set => isFocused = value; }

    #region -> Private methods
    private void SetPlaceholder() {
      if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "") {
        isPlaceholder = true;
        textBox1.Text = placeholderText;
        textBox1.ForeColor = placeholderColor;
        if (isPasswordChar)
          textBox1.UseSystemPasswordChar = false;
      }
    }
    private void RemovePlaceholder() {
      if (isPlaceholder && placeholderText != "") {
        isPlaceholder = false;
        textBox1.Text = "";
      }
      textBox1.ForeColor = this.ForeColor;
      if (isPasswordChar)
        textBox1.UseSystemPasswordChar = true;
    }
    
    private void SetTextBoxRoundedRegion() {
      GraphicsPath pathTxt;
      if (Multiline) {
        pathTxt = UserControlUtils.GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
        textBox1.Region = new Region(pathTxt);
      }
      else {
        pathTxt = UserControlUtils.GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
        textBox1.Region = new Region(pathTxt);
      }
      pathTxt.Dispose();
    }
    private void UpdateControlHeight() {
      if (textBox1.Multiline == false) {
        int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
        textBox1.Multiline = true;
        textBox1.MinimumSize = new System.Drawing.Size(0, txtHeight);
        textBox1.Multiline = false;
        this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
      }
    }
    #endregion

    #region -> Overridden methods
    protected override void OnResize(EventArgs e) {
      base.OnResize(e);
      if (this.DesignMode)
        UpdateControlHeight();
    }
    protected override void OnLoad(EventArgs e) {
      base.OnLoad(e);
      UpdateControlHeight();
    }
    protected override void OnPaint(PaintEventArgs e) {
      base.OnPaint(e);
      Graphics graph = e.Graphics;
      if (borderRadius > 1)//Rounded TextBox
      {
        //-Fields
        var rectBorderSmooth = this.ClientRectangle;
        var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
        int smoothSize = borderSize > 0 ? borderSize : 1;
        using (GraphicsPath pathBorderSmooth = UserControlUtils.GetFigurePath(rectBorderSmooth, borderRadius))
        using (GraphicsPath pathBorder = UserControlUtils.GetFigurePath(rectBorder, borderRadius - borderSize))
        using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
        using (Pen penBorder = new Pen(borderColor, borderSize)) {
          //-Drawing
          this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
          if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
          graph.SmoothingMode = SmoothingMode.AntiAlias;
          penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
          if (isFocused) penBorder.Color = borderFocusColor;
          if (underlinedStyle) //Line Style
          {
            //Draw border smoothing
            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
            //Draw border
            graph.SmoothingMode = SmoothingMode.None;
            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
          }
          else //Normal Style
          {
            //Draw border smoothing
            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
            //Draw border
            graph.DrawPath(penBorder, pathBorder);
          }
        }
      }
      else //Square/Normal TextBox
      {
        //Draw border
        using (Pen penBorder = new Pen(borderColor, borderSize)) {
          this.Region = new Region(this.ClientRectangle);
          penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
          if (isFocused) penBorder.Color = borderFocusColor;
          if (underlinedStyle) //Line Style
            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
          else //Normal Style
            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
        }
      }
    }
    #endregion

    private void AssociateEvent() {
      textBox1.Click += textBox1_Click;
      textBox1.MouseEnter += textBox1_MouseEnter;
      textBox1.MouseLeave += textBox1_MouseLeave;
      textBox1.KeyPress += textBox1_KeyPress;
      textBox1.KeyDown += textBox1_KeyDown;
      textBox1.Enter += textBox1_Enter;
      textBox1.Leave += textBox1_Leave;
      textBox1.TextChanged += textBox1_TextChanged;
    }

    private void textBox1_Click(object sender, EventArgs e) {
      this.OnClick(e);
    }
    private void textBox1_MouseEnter(object sender, EventArgs e) {
      this.OnMouseEnter(e);
    }
    private void textBox1_MouseLeave(object sender, EventArgs e) {
      this.OnMouseLeave(e);
    }
    private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
      this.OnKeyPress(e);
    }
    private void textBox1_KeyDown(object sender, EventArgs e) {
      this.OnClick(e);
    }
    private void textBox1_Enter(object sender, EventArgs e) {
      isFocused = true;
      this.Invalidate();
      RemovePlaceholder();
    }
    private void textBox1_Leave(object sender, EventArgs e) {
      isFocused = false;
      this.Invalidate();
      SetPlaceholder();
    }
    //Default Event
    public event EventHandler _TextChanged;
    //TextBox-> TextChanged event
    private void textBox1_TextChanged(object sender, EventArgs e) {
      if (_TextChanged != null)
        _TextChanged.Invoke(sender, e);
    }
  }
}
