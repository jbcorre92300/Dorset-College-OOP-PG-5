using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
                                                                    //23024 Thomas BAUDU 
                                                                   //23189 Audrey CHANTY
                                                                  //23182 Jean-Baptiste CORRE
                                                                 //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                               //23164 Alexandre MAROTTE
    class TimeTable
    {
        public List<Class> Listclass;


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
