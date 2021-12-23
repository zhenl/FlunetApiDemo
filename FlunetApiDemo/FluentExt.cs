using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlunetApiDemo
{
    public static class FluentExt
    {
        public static Student 是学生(this string  name)
        {
            return new Student { Name = name };
        }

        public static Student 身高(this Student student,decimal height)
        {
            student.Height = height;
            return student;
        }

        public static Student 体重(this Student student, decimal weight)
        {
            student.Weight = weight;
            return student;
        }

        public static decimal BMI(this Student student)
        {
            return student.Weight / student.Height / student.Height;
        }

        public static string BMI状态(this Student student)
        {
            var bmi=student.BMI();
            if (bmi > 24) return "肥胖";
            if (bmi > 21) return "超重";
            if (bmi < 15) return "偏瘦";
            return "正常";
        }
    }
}
