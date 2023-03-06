using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Student
    {
        List<Student> lststu = new List<Student>();

         public int roll_no { get; set; }
        public string name { get; set; }
        public string f_name { get; set; }
        public String age { get; set; }
        public String gender { get; set; }
        public String fess { get; set; }

        // Create Save Method
        public bool Save(Student stu)
        {
            bool retvalue = false;
            int index = lststu.FindIndex(r => r.roll_no == stu.roll_no);
            if (index != -1)
            {
                lststu.RemoveAt(index);
                lststu.Insert(index,stu);
            }
            else
            {
                lststu.Add(stu);

            }
            retvalue = true;
            return retvalue;
        }
        // Create Search Method

        public Student Search(int Rollno)
        {
            Student stu;
            stu = lststu.Find(r => r.roll_no == Rollno);
            return stu;
        }

        //Create Delete Method

        public bool Delete(int Rollno)
        {
            Student stu;
            stu = lststu.Find(r => r.roll_no == Rollno);
            if (stu != null)
            {
                lststu.Remove(stu);
                return true;
            }
            else
            {
                return false;
            }

            //Create clear Method

           
        }
        public static void clearcontrol(Control Maincontrol )
        {
            foreach(Control ctrl in Maincontrol.Controls)
            {
                if (ctrl.HasChildren)
                {
                    clearcontrol(ctrl);
                }
                if (ctrl.Tag != "NO" && ctrl.GetType() == typeof(TextBox))
                {
                    ctrl.Text = "";
                }
            }
        }
    }
}
