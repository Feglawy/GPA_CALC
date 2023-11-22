using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GPA_CALC
{
    internal class Calculate
    {
        public static string Get_GPA(double Total_time, double Grade)
        {
            double gpa = Grade / Total_time;
            return gpa.ToString();
        }
    }
}
