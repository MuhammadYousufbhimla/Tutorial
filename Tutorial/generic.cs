using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class generic<H>
    {
        List<H> lst = new List<H>();

        // Create Save Method 
        public bool Save(H cls, Predicate<H> cond)
        {
            bool retvalue = false;

            int index = lst.FindIndex(cond);
            if (index != -1)
            {
                lst.RemoveAt(index);
                lst.Insert(index, cls);
            }
            else
            {
                lst.Add(cls);
            }
            retvalue = true;
            return retvalue;
        }
        // Create Search Method

        public H Serach(Predicate<H> cond)
        {
            H stu;
            stu = lst.Find(cond);
            return stu;
        }
        // Create Delete Method 

        public bool delete(Predicate<H> cond)
        {
            H stu;
            stu = lst.Find(cond);
            if (stu != null)
            {
                lst.Remove(stu);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void clearcontrol(Control Maincontrol)
        {
            foreach (Control ctrl in Maincontrol.Controls)
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
