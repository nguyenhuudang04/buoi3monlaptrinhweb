using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private static List<Student> students = new List<Student>();

        [HttpPost]
        public IActionResult ShowKQ(string MSSV, string HoTen, double DiemTB, string ChuyenNganh)
        {
            // Lưu thông tin sinh viên vào danh sách
            students.Add(new Student
            {
                MSSV = MSSV,
                HoTen = HoTen,
                DiemTB = DiemTB,
                ChuyenNganh = ChuyenNganh
            });

            // Đếm số lượng sinh viên cùng chuyên ngành
            int soLuongCungNganh = students.Count(s => s.ChuyenNganh == ChuyenNganh);

            // Truyền dữ liệu vào View
            ViewBag.MSSV = MSSV;
            ViewBag.HoTen = HoTen;
            ViewBag.ChuyenNganh = ChuyenNganh;
            ViewBag.SoLuongCungNganh = soLuongCungNganh;

            return View();
        }
    }

}
