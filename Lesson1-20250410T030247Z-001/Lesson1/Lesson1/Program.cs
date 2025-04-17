//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//// comment 1 dòng
///*
// * comment nhiều dòng
// */
//// 1. Khai báo biến.
//// Cú pháp kiểu-dữ-liệu tên-biến = giá-trị
//int a = 3; // Khai báo biến kiểu số nguyên
//float b = 3.33f;// Khai báo biến kiểu số thực
//double c = 1.444;//double( số thực)
//char d = 'd';
//string helo = "helo";
//bool Student = true;
////2. Nhập, xuất dữ liệu
//string name = "má m";
//Console.WriteLine(name);// hiển thị dữ liệu_ xuống dòng
//Console.Write(name);// hiển thị dữ liệu
//Console.WriteLine("Name: " + name);// Hiện thị dữ liệu và xuất
//Console.WriteLine("Name: {0} " ,name);
//Console.WriteLine($"Name: {name} " );

//Console.Write("Nhap vao ten : ");
//name = Console.ReadLine();// return type is string

//Console.Write("Nhap tuoi cua ban: ");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine($"Name : {name}, age: {age}");
////3. Cau truc re nhanh
////3.1. If..else
//if(age < 18)
//{
//    Console.WriteLine("Tu choi");
//}
//else
//{
//    Console.WriteLine("Dong y");
//}

////3.2. Switch case
////4. Vong lap
////4.1. for
////4.2. while
////4.3. do...while
////4.4. foreach
//List<double> scores = [1.2, 2.2, 2.3, 2.4] ;
//foreach (double score in scores)
//{
//    Console.WriteLine(score);
//}

/*
5.OOP
4 tinh chat trong OOp
+ ke thua: lớp con kế thừa thuộc tính và phương thức của lớp cha
+ da hinh: Upcasting & Downcasting
+ truu tuong: Trừu tượng hóa đối tượng trong thực tế chỉ giữ lại những gì cần thiết
+ dong goi: Chuyển mức độ truy cập các thuộc tính của properties thành private và thêm các phương thức get/set
-5 loại mức độ truy cập
+ public: công khai ai dùng cũng được
+ private: riêng tư, không ai dùng đc ngoài mình
+ protected: chỉ cho ph ép lớp con kế thừa có thể sử dụng
+ internal: sử dụng nội bộ trong namespace
+ protected internal: kết hợp protected & internal
-1 class sẽ có 3 thành phần:
+ Property ( thuộc tính của đối tượng)
+ Method( phương thức của đối tượng)
+ Constructor ( Phương thức khởi tạo): 2 loại có tham số - không có tham số

*/
// Khai bao va khoi tao doi tuong
using Lesson1;
// Cu phap ten-lop ten-doi-tuong = new Constructor();
Student student = new Student(id: 1771020336, name: "Huong", age: 20);
// De truy cap den thuoc tinh hoac phuong thuc cua doi tuong su dung dau;
//Console.WriteLine(student.Id);
//student.getStudentInfo();
//student.Name = "Huong02";
//student.getStudentInfo();
student.inputStudent();
student.getStudentInfo();
//6. Xu ly ngoai le
/* Co 2 loai ngoai le:
+Compilation Errors
+Runtime Errors
Xu ly try..catch..finally
Tung ngoai le cuong buc
Tu dinh nghia ngoai le
