namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Credential
    {
        [Key]
        public int CredenId { get; set; }

        [StringLength(20, ErrorMessage = "Nhóm người dùng không được vượt quá 20 ký tự.")]
        [Required(ErrorMessage = "Yêu cầu nhập Nhóm người dùng.")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Nhóm người dùng chỉ được phép chứa chữ cái, số và ký tự '_'.")]
        [Display(Name = "Nhóm người dùng")]
        public string UserGroupId { get; set; }

        [StringLength(20, ErrorMessage = "Chức năng không được vượt quá 20 ký tự.")]
        [Required(ErrorMessage = "Yêu cầu nhập Chức năng.")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Chức năng chỉ được phép chứa chữ cái, số và ký tự '_'.")]
        [Display(Name = "Chức năng")]
        public string RoleId { get; set; }
    }
}
