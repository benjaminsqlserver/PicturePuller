using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PicturePuller.Models.ConData
{
  [Table("ImageTypes", Schema = "dbo")]
  public partial class ImageType
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ImageTypeID
    {
      get;
      set;
    }
    public string ImageTypeName
    {
      get;
      set;
    }
  }
}
