using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class TimeTable
    {
        public List<Class> Listclass;
        public Date Date;


        public TimeTable(List<Class> listclass)
        {
            Listclass = listclass;
        }

        public void AddClass (Class newclass)
        {
            Listclass.Add(newclass);
        }
            


    }
}
