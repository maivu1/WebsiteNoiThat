using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Text.RegularExpressions;

namespace Models.EF
{
    public partial class UserGroup
    {
        [Key]
        [StringLength(20, ErrorMessage = "Mã nhóm người dùng không được vượt quá 20 ký tự.")]
        [Required(ErrorMessage = "Yêu cầu nhập Mã nhóm người dùng.")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Mã nhóm người dùng không được chứa ký tự đặc biệt.")]
        [Display(Name = "Mã nhóm người dùng")]
        public string GroupId { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập Tên mô tả.")]
        [StringLength(150, ErrorMessage = "Tên mô tả không được vượt quá 150 ký tự.")]
        [Display(Name = "Tên mô tả")]
        public string Name { get; set; }
    }
}
