using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Teacher
    {
        string name;
        List<Classroom> listclassroom;
        Matter matter;

        public Teacher()                                        //23024 Thomas BAUDU 
        {                                                       //23189 Audrey CHANTY
                                                                //23182 Jean-Baptiste CORRE
                                                                //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                                //23164 Alexandre MAROTTE
            

        }

        public void AddaGradeforaStudent(Student student, double note) // id student a la place de student 
        {
            Grade grade = new Grade(matter, note);
            student.listgrade.Add(grade);
        }

        public void AddaClassforaClassroom(int classname, Date date, string location)
        {
            //int i = l'index de la classe dans la liste de class du teacher
            int i = 1;
            Class newclass = new Class(date, matter, location,);
            foreach(Student student in listclassroom[i].classroom)
            {
                student.timetable.timetable.Add(newclass);
            }
            


        }

    }
}
