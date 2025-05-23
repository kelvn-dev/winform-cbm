﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBM.Customs {
  [DefaultEvent("OnSelectedIndexChanged")]
  public class CBMComboBox: UserControl {

    #region Variables

    private Color backColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
    private Color iconColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
    private Color listBackColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
    private Color listTextColor = ColorTranslator.FromHtml(Constant.BOLD_GRAY_COLOR);
    private Color borderColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
    private int borderSize = Constant.MIN_BORDER_SIZE;
    //Items
    private ComboBox cmbList;
    private Label lblText;
    private Button btnIcon;
    //Events
    public event EventHandler OnSelectedIndexChanged;//Default event

    #endregion

    public CBMComboBox() {
      cmbList = new ComboBox();
      lblText = new Label();
      btnIcon = new Button();
      this.SuspendLayout();
      //ComboBox: Dropdown list
      cmbList.BackColor = listBackColor;
      cmbList.Font = new Font(this.Font.Name, 10F);
      cmbList.ForeColor = listTextColor;
      cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Default event
      cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);//Refresh text
                                                                    //Button: Icon
      btnIcon.Dock = DockStyle.Right;
      btnIcon.FlatStyle = FlatStyle.Flat;
      btnIcon.FlatAppearance.BorderSize = 0;
      btnIcon.BackColor = backColor;
      btnIcon.Size = new Size(30, 30);
      btnIcon.Cursor = Cursors.Hand;
      btnIcon.Click += new EventHandler(Icon_Click);//Open dropdown list
      btnIcon.Paint += new PaintEventHandler(Icon_Paint);//Draw icon
                                                         //Label: Text
      lblText.Dock = DockStyle.Fill;
      lblText.AutoSize = false;
      lblText.BackColor = backColor;
      lblText.TextAlign = ContentAlignment.MiddleLeft;
      lblText.Padding = new Padding(8, 0, 0, 0);
      lblText.Font = new Font(this.Font.Name, 10F);
      //->Attach label events to user control event
      lblText.Click += new EventHandler(Surface_Click);//Select combo box
      lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
      lblText.MouseLeave += new EventHandler(Surface_MouseLeave);
      //User Control
      this.Controls.Add(lblText);//2
      this.Controls.Add(btnIcon);//1
      this.Controls.Add(cmbList);//0
      this.MinimumSize = new Size(200, 30);
      this.Size = new Size(200, 30);
      this.ForeColor = Color.DimGray;
      this.Padding = new Padding(borderSize);//Border Size
      this.Font = new Font(this.Font.Name, 10F);
      base.BackColor = borderColor; //Border Color
      this.ResumeLayout();
      AdjustComboBoxDimensions();
    }

    #region Common

    private void AdjustComboBoxDimensions() {
      cmbList.Width = lblText.Width;
      cmbList.Location = new Point() {
        X = this.Width - this.Padding.Right - cmbList.Width,
        Y = lblText.Bottom - cmbList.Height
      };
    }

    protected override void OnResize(EventArgs e) {
      base.OnResize(e);
      AdjustComboBoxDimensions();
    }

    #endregion

    #region Events

    private void ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
      if (OnSelectedIndexChanged != null)
        OnSelectedIndexChanged.Invoke(sender, e);
      //Refresh text
      lblText.Text = cmbList.Text;
    }
    //-> Items actions
    private void Icon_Click(object sender, EventArgs e) {
      //Open dropdown list
      cmbList.Select();
      cmbList.DroppedDown = true;
    }
    private void Surface_Click(object sender, EventArgs e) {
      //Attach label click to user control click
      this.OnClick(e);
      //Select combo box
      cmbList.Select();
      if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
        cmbList.DroppedDown = true;//Open dropdown list
    }
    private void ComboBox_TextChanged(object sender, EventArgs e) {
      //Refresh text
      lblText.Text = cmbList.Text;
    }
    private void Surface_MouseLeave(object sender, EventArgs e) {
      this.OnMouseLeave(e);
    }
    private void Surface_MouseEnter(object sender, EventArgs e) {
      this.OnMouseEnter(e);
    }

    #endregion

    #region Draw the icon (Arrow down)

    private void Icon_Paint(object sender, PaintEventArgs e) {
      //Fields
      int iconWidht = 14;
      int iconHeight = 6;
      var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
      Graphics graph = e.Graphics;
      //Draw arrow down icon
      using (GraphicsPath path = new GraphicsPath())
      using (Pen pen = new Pen(iconColor, 2)) {
        graph.SmoothingMode = SmoothingMode.AntiAlias;
        path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
        path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
        graph.DrawPath(pen, path);
      }
    }

    #endregion

    #region Appearance Properties

    public new Color BackColor {
      get { return backColor; }
      set {
        backColor = value;
        lblText.BackColor = backColor;
        btnIcon.BackColor = backColor;
      }
    }
    public Color IconColor {
      get { return iconColor; }
      set {
        iconColor = value;
        btnIcon.Invalidate();//Redraw icon
      }
    }
    public Color ListBackColor {
      get { return listBackColor; }
      set {
        listBackColor = value;
        cmbList.BackColor = listBackColor;
      }
    }
    public Color ListTextColor {
      get { return listTextColor; }
      set {
        listTextColor = value;
        cmbList.ForeColor = listTextColor;
      }
    }
    public Color BorderColor {
      get { return borderColor; }
      set {
        borderColor = value;
        base.BackColor = borderColor; //Border Color
      }
    }
    public int BorderSize {
      get { return borderSize; }
      set {
        borderSize = value;
        this.Padding = new Padding(borderSize);//Border Size
        AdjustComboBoxDimensions();
      }
    }
    public override Color ForeColor {
      get { return base.ForeColor; }
      set {
        base.ForeColor = value;
        lblText.ForeColor = value;
      }
    }
    public override Font Font {
      get { return base.Font; }
      set {
        base.Font = value;
        lblText.Font = value;
        cmbList.Font = value;//Optional
      }
    }
    public string Texts {
      get { return lblText.Text; }
      set { lblText.Text = value; }
    }
    public ComboBoxStyle DropDownStyle {
      get { return cmbList.DropDownStyle; }
      set {
        if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
          cmbList.DropDownStyle = value;
      }
    }

    #endregion

    #region Functionalities Properties

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
    [Localizable(true)]
    [MergableProperty(false)]
    public ComboBox.ObjectCollection Items {
      get { return cmbList.Items; }
    }
    [AttributeProvider(typeof(IListSource))]
    [DefaultValue(null)]
    public object DataSource {
      get { return cmbList.DataSource; }
      set { cmbList.DataSource = value; }
    }
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [Localizable(true)]
    public AutoCompleteStringCollection AutoCompleteCustomSource {
      get { return cmbList.AutoCompleteCustomSource; }
      set { cmbList.AutoCompleteCustomSource = value; }
    }
    [Browsable(true)]
    [DefaultValue(AutoCompleteSource.None)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public AutoCompleteSource AutoCompleteSource {
      get { return cmbList.AutoCompleteSource; }
      set { cmbList.AutoCompleteSource = value; }
    }
    [Browsable(true)]
    [DefaultValue(AutoCompleteMode.None)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public AutoCompleteMode AutoCompleteMode {
      get { return cmbList.AutoCompleteMode; }
      set { cmbList.AutoCompleteMode = value; }
    }
    [Bindable(true)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object SelectedItem {
      get { return cmbList.SelectedItem; }
      set { cmbList.SelectedItem = value; }
    }
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int SelectedIndex {
      get { return cmbList.SelectedIndex; }
      set { cmbList.SelectedIndex = value; }
    }
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object SelectedValue {
      get { return cmbList.SelectedValue; }
      set { cmbList.SelectedValue = value; }
    }
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string SelectedText {
      get { return cmbList.SelectedText; }
      set { cmbList.SelectedText = value; }
    }
    [DefaultValue("")]
    [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
    [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public string DisplayMember {
      get { return cmbList.DisplayMember; }
      set { cmbList.DisplayMember = value; }
    }
    [DefaultValue("")]
    [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
    public string ValueMember {
      get { return cmbList.ValueMember; }
      set { cmbList.ValueMember = value; }
    }

    #endregion
  }
}
