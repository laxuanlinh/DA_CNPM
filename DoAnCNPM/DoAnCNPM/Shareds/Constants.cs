using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.Shareds
{
    public class Constants
    {
        public static string empty_data = "Dữ liệu trống";
        public static string confirm_delete = "Bạn có thực sự muốn xóa ?";
        public static string confirm_exit = "Bạn có thực sự muốn thoát ?";
        public static string error = "Có lỗi xảy ra! bạn có muốn xem chi tiết lỗi ?";
        public static string error_insert_nodata_makhoa = "You must input value for Ma khoa !";
        public static string error_insert_nodata_masv = "You must input value for Ma khoa !";
        public static string error_insert_nodata_mamon = "You must input value for Ma khoa !";
        public static string error_duplicate_makhoa = "Duplicate data! you should change the Ma khoa field";
        public static string error_duplicate_masv = "Duplicate data! you should change the Ma khoa field";
        public static string error_duplicate_mamon = "Duplicate data! you should change the Ma khoa field";
        public static string error_duplicate_masv_mamon = "Duplicate data! you should change the Ma khoa field or Ma SV field";
        public static string error_null_makhoa = "Ma khoa must be typed !";
        public static string error_null_masv = "Ma sinh vien must be typed !";
        public static string error_null_mamon = "Ma mon must be typed !";
        public static string error_edit_makhoa = "Ma khoa must have in table !";
        public static string error_edit_masv = "Ma sinh vien must have in table !";
        public static string error_edit_mamon = "Ma mon must have in table !";
        public static string error_edit_masv_mamon = "Ma mon and Ma SV must have in table !";
        public static string error_delete_nothing_makhoa = "Ma khoa must have in table !";
        public static string error_delete_nothing_masv = "Ma khoa must have in table !";
        public static string error_delete_nothing_mamon = "Ma khoa must have in table !";
        public static string error_delete_nothing_masv_mamon = "Ma khoa and Ma SV must have in table !";
        public static string success_insert = "Thêm dữ liệu thành công !";
        public static string success_edit = "Sửa dữ liệu thành công !";
        public static string success_delete = "Xóa dữ liệu thành công !";
        public static string warning_caption = "Cảnh báo !";
        public static string error_not_list_khoa = "Error ! you have to input the right data!";
    }
}
