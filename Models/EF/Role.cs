using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.EF
{
    [Table("Role")]
    public partial class Role
    {
        [Key]
        [StringLength(20, ErrorMessage = "Mã chức năng không được vượt quá 20 ký tự.")]
        [Required(ErrorMessage = "Yêu cầu nhập Mã chức năng.")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Mã chức năng chỉ được phép chứa chữ cái, số và ký tự '_'.")]
        [Display(Name = "Mã chức năng")]
        public string RoleId { get; set; }

        [StringLength(50, ErrorMessage = "Mô tả không được vượt quá 50 ký tự.")]
        [Required(ErrorMessage = "Yêu cầu nhập Mô tả.")]
        [Display(Name = "Mô tả")]
        public string Name { get; set; }
    }
}
