using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ImageCRUD.Models;

public partial class Tblemp
{
    public int Id { get; set; }

    public string? Enm { get; set; }


    public byte[] Img { get; set; }  // Store image as a byte array (BLOB)

    [Display(Name = "Upload Image")]
    public IFormFile ImageFile { get; set; }  // Property to receive image from form
}
