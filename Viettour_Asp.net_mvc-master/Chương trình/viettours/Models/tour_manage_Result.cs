//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace viettours.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public partial class tour_manage_Result
    {

        public int id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Tên tour không được để trống")]
        [RegularExpression("([a-z0-9A-Z_ãáàảạẽéèẻẹũúùủụõóòỏọĩíìỉịẫấầẩậễếềểệữứừửựỗốồổộỹýỳỷỵẵắằẳặỡớờởợâăêôươÃÁÀẢẠẼÉÈẺẸŨÚÙỦỤÕÓÒỎỌĨÍÌỈỊẪẤẦẨẬỄẾỀỂỆỮỨỪỬỰỖỐỒỔỘỸÝỲỶỴẴẮẰẲẶỠỚỜỞỢÂĂÊÔƯƠ, ().&\"'-–]+)", ErrorMessage = "Tên tour không đúng định dạng")]
        [DisplayName("Tên tour")]
        public string name { get; set; }
        [DisplayName("Ảnh")]
        public string anh { get; set; }

        [DisplayName("Thời gian")]
        public Nullable<int> thoigian { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Khởi hành không được để trống")]
        [RegularExpression("([a-z0-9A-Z_ãáàảạẽéèẻẹũúùủụõóòỏọĩíìỉịẫấầẩậễếềểệữứừửựỗốồổộỹýỳỷỵẵắằẳặỡớờởợâăêôươÃÁÀẢẠẼÉÈẺẸŨÚÙỦỤÕÓÒỎỌĨÍÌỈỊẪẤẦẨẬỄẾỀỂỆỮỨỪỬỰỖỐỒỔỘỸÝỲỶỴẴẮẰẲẶỠỚỜỞỢÂĂÊÔƯƠ, ().&\"'-–]+)", ErrorMessage = "Khởi hành không đúng định dạng")]
        [DisplayName("Khởi hành")]
        public string khoihanh { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Phương tiện không được để trống")]
        [RegularExpression("([a-z0-9A-Z_ãáàảạẽéèẻẹũúùủụõóòỏọĩíìỉịẫấầẩậễếềểệữứừửựỗốồổộỹýỳỷỵẵắằẳặỡớờởợâăêôươÃÁÀẢẠẼÉÈẺẸŨÚÙỦỤÕÓÒỎỌĨÍÌỈỊẪẤẦẨẬỄẾỀỂỆỮỨỪỬỰỖỐỒỔỘỸÝỲỶỴẴẮẰẲẶỠỚỜỞỢÂĂÊÔƯƠ, ().&\"'-–]+)", ErrorMessage = "Phương tiện không đúng định dạng")]
        [DisplayName("Phương tiện")]
        public string phuongtien { get; set; }

        [DisplayName("Giá")]
        public Nullable<int> gia { get; set; }

        [DisplayName("Đặc điểm")]
        public Nullable<int> dacdiem { get; set; }

        [DisplayName("Chi tiết")]
        public Nullable<int> chitiet { get; set; }
        [DisplayName("Loại")]
        [Required(ErrorMessage = "Loại không dc để trống")]
        public Nullable<int> loai { get; set; }
        [DisplayName("Danh mục")]
        [Required(ErrorMessage = "Danh mục không dc để trống")]
        public string danhmuc { get; set; }
        public string tendm { get; set; }
    }
}
