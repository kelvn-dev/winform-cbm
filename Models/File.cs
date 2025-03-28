using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CBM.Models {
  [Table("file")]
  public class File : BaseModel {

    public File() : base() { }

    public File(byte[] image) : base() {
      _image = image;
    }

    private byte[] _image;

    [DisplayName("Image")]
    [Column("image")]
    public byte[] image {
      get => _image;
      set => _image = value;
    }
  }
}
