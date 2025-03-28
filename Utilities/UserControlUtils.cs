using CBM.Customs;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CBM.Utilities {
  public class UserControlUtils {

    public static GraphicsPath GetFigurePath(Rectangle rect, int radius) {
      GraphicsPath path = new GraphicsPath();
      float curveSize = radius * 2F;
      path.StartFigure();
      path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
      path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
      path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
      path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
      path.CloseFigure();
      return path;
    }

    public static List<CBMTextbox> GetAllCBMTextbox(Control.ControlCollection controls) {
      List<CBMTextbox> textBoxes = new List<CBMTextbox>();
      foreach (Control control in controls) {
        if (control is CBMTextbox) {
          textBoxes.Add((CBMTextbox) control);
        }
      }
      return textBoxes;
    }

    public static List<CBMComboBox> GetAllCBMComboBox(Control.ControlCollection controls) {
      List<CBMComboBox> comboBoxes = new List<CBMComboBox>();
      foreach (Control control in controls) {
        if (control is CBMComboBox) {
          comboBoxes.Add((CBMComboBox)control);
        }
      }
      return comboBoxes;
    }
    public static List<CBMCheckBox> GetAllCBMCheckBox(Control.ControlCollection controls) {
      List<CBMCheckBox> checkBoxes = new List<CBMCheckBox>();
      foreach (Control control in controls) {
        if (control is CBMCheckBox) {
          checkBoxes.Add((CBMCheckBox)control);
        }
      }
      return checkBoxes;
    }

    public static void CleanFields(Control.ControlCollection controls) {
      List<CBMTextbox> textBoxes = GetAllCBMTextbox(controls);
      List<CBMComboBox> comboBoxes = GetAllCBMComboBox(controls);
      List<CBMCheckBox> checkBoxes = GetAllCBMCheckBox(controls);
      foreach (CBMTextbox textbox in textBoxes) {
        textbox.Texts = string.Empty;
      }
      foreach (CBMComboBox comboBox in comboBoxes) {
        comboBox.SelectedIndex = -1; // To remove default value
        comboBox.Texts = string.Empty;
      }
      foreach (CBMCheckBox checkBox in checkBoxes) {
        checkBox.Checked = false;
      }
    }

    #region Css

    public static void CssCreateBtn(CBMButton button) {
      button.BackColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.ForeColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
      button.BorderColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.BorderRadius = Constant.MIN_BORDER_RADIUS;
      button.BorderSize = Constant.MIN_BORDER_SIZE;
      button.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);
    }

    public static void CssSaveBtn(CBMButton button) {
      button.BackColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.ForeColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
      button.BorderColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.BorderSize = Constant.MIN_BORDER_SIZE;
      button.BorderRadius = Constant.MIN_BORDER_RADIUS;
      button.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);
      //button.Text = "Save Changes";
    }

    public static void CssCancelBtn(CBMButton button) {
      button.BackColor = ColorTranslator.FromHtml(Constant.WHITE_COLOR);
      button.ForeColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.BorderColor = ColorTranslator.FromHtml(Constant.RED_COLOR);
      button.BorderSize = Constant.MIN_BORDER_SIZE;
      button.BorderRadius = Constant.MIN_BORDER_RADIUS;
      button.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);
    }

    public static void CssDatagridView(DataGridView dataGridView) {
      dataGridView.BackgroundColor = Color.White;
      dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      // Css header
      DataGridViewCellStyle headerDataGridViewCellStyle = new DataGridViewCellStyle();
      headerDataGridViewCellStyle.BackColor = ColorTranslator.FromHtml(Constant.DARK_BLUE_COLOR);
      headerDataGridViewCellStyle.ForeColor = Color.White;
      headerDataGridViewCellStyle.Font = new Font("Poppins", 12);
      headerDataGridViewCellStyle.Padding = new Padding(20, 0, 0, 0);

      // Css body
      DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
      dataGridViewCellStyle.BackColor = Color.White; ;
      dataGridViewCellStyle.ForeColor = ColorTranslator.FromHtml("#959595");
      dataGridViewCellStyle.SelectionBackColor = dataGridViewCellStyle.BackColor;
      dataGridViewCellStyle.SelectionForeColor = dataGridViewCellStyle.ForeColor;
      dataGridViewCellStyle.Font = new Font("Poppins", 12);
      dataGridViewCellStyle.Padding = new Padding(20, 0, 0, 0);

      // Css odd row
      DataGridViewCellStyle alternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
      alternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f6f6f6");
      alternatingRowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#959595");
      alternatingRowsDefaultCellStyle.SelectionBackColor = alternatingRowsDefaultCellStyle.BackColor;
      alternatingRowsDefaultCellStyle.SelectionForeColor = alternatingRowsDefaultCellStyle.ForeColor;
      alternatingRowsDefaultCellStyle.Font = new Font("Poppins", 12);

      dataGridView.ColumnHeadersDefaultCellStyle = headerDataGridViewCellStyle;
      dataGridView.DefaultCellStyle = dataGridViewCellStyle;
      dataGridView.EnableHeadersVisualStyles = false;
      dataGridView.AlternatingRowsDefaultCellStyle = alternatingRowsDefaultCellStyle;

      // Remove all borders
      dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
      dataGridView.BorderStyle = BorderStyle.None;

      dataGridView.RowHeadersVisible = false;
      dataGridView.AllowUserToAddRows = false;
      dataGridView.AllowUserToDeleteRows = false;
      dataGridView.AllowUserToResizeColumns = false;
      dataGridView.AllowUserToResizeRows = false;

      // Increase height of header and rows
      dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
      dataGridView.ColumnHeadersHeight = 100;
      dataGridView.RowTemplate.Height = 100;
    }

    public static void AjustHeightAutomatically(DataGridView dataGridView) {
      int height = dataGridView.ColumnHeadersHeight;
      foreach (DataGridViewRow row in dataGridView.Rows) {
        height += row.Height;
      }
      dataGridView.Height = height;
    }

    public static void AddActionColumns(DataGridView dataGridView) {
      DataGridViewImageColumn column = new DataGridViewImageColumn();
      column.Name = "update";
      column.HeaderText = "Update";
      column.ImageLayout = DataGridViewImageCellLayout.Normal;
      column.Image = Properties.Resources.edit;
      dataGridView.Columns.Add(column);

      column = new DataGridViewImageColumn();
      column.Name = "delete";
      column.HeaderText = "Delete";
      column.ImageLayout = DataGridViewImageCellLayout.Normal;
      column.Image = Properties.Resources.trash_icon_14_48;
      dataGridView.Columns.Add(column);
     
      dataGridView.Columns["update"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;  // [dataGridView.ColumnCount - 1]
      dataGridView.Columns["delete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
    }
    public static void AddBuyColumn(DataGridView dataGridView) {
      DataGridViewImageColumn column = new DataGridViewImageColumn();
      column.Name = "buy";
      column.HeaderText = "Buy Now";
      column.ImageLayout = DataGridViewImageCellLayout.Normal;
      column.Image = Properties.Resources.buy_icon;
      dataGridView.Columns.Add(column);
      dataGridView.Columns["buy"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
    }

      public static void CssIconButton(IconButton iconButton, Color backColor, Color color, int size = Constant.NORMAL_ICON_SIZE) {
      iconButton.FlatStyle = FlatStyle.Flat;
      iconButton.FlatAppearance.BorderSize = 0;
      iconButton.BackColor = backColor;
      iconButton.ForeColor = color;
      iconButton.IconColor = iconButton.ForeColor;
      iconButton.IconSize = size;
      iconButton.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE, FontStyle.Regular);
    }

    public static void CssInformationLabel(Label label) {
      label.ForeColor = ColorTranslator.FromHtml("#141414");
      label.Font = new Font(Constant.FONT_FAMILY, Constant.LARGE_FONT_SIZE, FontStyle.Bold);
    }

    public static void CssFieldLabel(Label label) {
      label.ForeColor = Color.Black;
      label.BorderStyle = BorderStyle.None;
      label.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);
    }
    public static void CssPageLabel(Label label) {
      label.ForeColor = ColorTranslator.FromHtml(Constant.BLUE_COLOR);
      label.BorderStyle = BorderStyle.None;
      label.Font = new Font(Constant.FONT_FAMILY, 10);
    }

    public static void CssComboBox(CBMComboBox comboBox) {
      comboBox.ForeColor = Color.Black;
      comboBox.BorderSize = 2;
      comboBox.Padding = new Padding(20, 10, 10, 20);
      comboBox.Font = new Font(Constant.FONT_FAMILY, 10);
      comboBox.BorderSize = Constant.MIN_BORDER_SIZE;
      comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    public static void CssTextbox(CBMTextbox textBox, string placeholderText) {
      //textBox.Multiline = true;
      textBox.Padding = new Padding(20, 14, 14, 14);
      textBox.Font = new Font(Constant.FONT_FAMILY, Constant.NORMAL_FONT_SIZE);

      textBox.PlaceholderText = placeholderText;
      textBox.BorderColor = ColorTranslator.FromHtml(Constant.PLACEHOLDER_COLOR);
      textBox.BorderSize = Constant.MIN_BORDER_SIZE;
      textBox.BorderRadius = Constant.MIN_BORDER_RADIUS;
      textBox.BorderFocusColor = Color.Black;
    }

    public static void CssSearchTextbox(CBMTextbox textbox) {
      CssTextbox(textbox, Constant.PLACEHOLDER_SEARCH_TXT);
      textbox.Padding = new Padding(80, 14, 14, 14);
      textbox.BorderSize = 2;
      textbox.BorderRadius = Constant.MAX_BORDER_RADIUS;
    }
    public static void CssLoginTextbox(CBMTextbox textbox, string placeholder) {
      textbox.PlaceholderText = placeholder;
      textbox.Padding = new Padding(80, 14, 14, 14);
      textbox.BorderSize = 2;
      textbox.BorderRadius = Constant.MIN_BORDER_RADIUS;
    }

    #endregion
  }
}
