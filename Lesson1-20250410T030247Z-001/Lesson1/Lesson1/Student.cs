using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Student
    {
        //1, Properties
        //Cach 1:
        //private int id;
        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        //Cach2:
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //2. Constructor
        //2.1. No Parameters ( không có tham số)
        public Student()//Duy nhat mot phuong thuc
        {
        }
        //2.2. C tham so: co the co nhieu phuong thuc
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        //3. Method
        public void getStudentInfo()
        {
            Console.WriteLine("Student Info: ");
            Console.WriteLine($"\t- Id: {Id}");
            Console.WriteLine($"\t- Name: {Name}");
            Console.WriteLine($"\t- Age: {Age}");
        }
        public void inputStudent()
        {
            try // try an tab
            {
                Console.WriteLine("Input Student: ");
                Console.Write("\t-Id: ");
                Id = int.Parse(Console.ReadLine());
                Console.Write("\t -Name: ");
                Name = Console.ReadLine();
                Console.Write("\t- Age: ");
                int value = int.Parse(Console.ReadLine());
                //Tung ngoai le cuong buc
                if(value<0)
                {
                    throw new AgeException("Nhap sai tuoi ");
                }
                Age = value;

            }
            catch (AgeException ex)
            { 
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)//Xu ly khi co loi xay ra
            {
                Console.WriteLine("Loi: " + ex.Message);

            }
            
            finally
            {
                Console.WriteLine("Luon luon duoc thuc thi");
            }

        }
    }
}
