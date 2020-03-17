using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    public class Resume
    {
        public WorkExperience work;
        public string name { get; set; }
        public int age { get; set; }
        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }
        public void SetWorkExperience(int age,string workDate,string company)
        {
            this.age = age;
            work.workDate = workDate;
            work.company = company;
        }
        public void SetCompany(string company)
        {
            work.company = company;
        }

        public void Display()
        {
            Console.WriteLine("name=" + name+",age="+age.ToString());
            Console.WriteLine("work=" + work.workDate + ",company=" + work.company);
        }
        public Resume DeepCopy()
        {
            Resume _resume = (Resume)this.MemberwiseClone();
            _resume.work = this.work.ShallowCopy();
            return _resume;
        }
    }
}