using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{
    class Teacher
    {                                                           //23024 Thomas BAUDU 
                                                                //23189 Audrey CHANTY
                                                                //23182 Jean-Baptiste CORRE
                                                                //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                                //23164 Alexandre MAROTTE
        public string name;
        public List<Classroom> listclassroom;
        public Matter matter;

        public Teacher(string name, List<Classroom> liste, Matter matter)
        {
            this.name = name;
            this.listclassroom = liste;
            this.matter = matter;
        }

        public void AddaGradeforaStudent(Student student, double note, string gradename) // id student a la place de student 
        {
            Grade grade = new Grade(matter, note, gradename);
            student.listgrade.Add(grade);
        }

        public void AddaClassforaClassroom(int classname, Date date, string location, Classroom classroom)
        {
            //int i = l'index de la classe dans la liste de class du teacher
            int i = 1;
            Teacher teacher = new Teacher(name, listclassroom, matter);
            Class newclass = new Class(date, matter, location, teacher, classroom);
            foreach(Student student in listclassroom[i].classroom)
            {
                student.timetable.listclass.Add(newclass);
            }

        }

        public void Attendance (Classroom classroom)
        {
            foreach(Student student in classroom.classroom)
                {
                    Console.WriteLine ("Is this student" + student.name  + " here ?");

                    string answer = Console.ReadLine();

                    if (answer == "Yes") break;

                    if (answer == "No") student.nonattendance ++;

                    else Console.WriteLine ("Error");
                }
        }

    }
}
