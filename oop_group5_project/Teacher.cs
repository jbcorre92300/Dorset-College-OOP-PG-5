using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace oop_group5_project
{
   class Teacher : User, ManageAttendance
    {                                                           //23024 Thomas BAUDU 
                                                                //23189 Audrey CHANTY
                                                                //23182 Jean-Baptiste CORRE
                                                                //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                                //23164 Alexandre MAROTTE
        public string Name { get; set; }
        public List<Classroom> Listclassroom { get; set; }
        public Matter Matter { get; set; }

        public Teacher(string name, List<Classroom> liste, Matter matter,string id, string password, string usertype)
        : base(id, password, usertype)
        {
            Name = name;
            Listclassroom = liste;
            Matter = matter;
            Usertype = "2";
        }

        public void AddaGradeforaStudent(Student student, double note, string gradename) // id student a la place de student 
        {
            Grade grade = new Grade(Matter, note, gradename);
            student.Listgrade.Add(grade);
        }

        public void AddaClassforaClassroom(int classname, Date date, string location, Classroom classroom)
        {
            //int i = l'index de la classe dans la liste de class du teacher
            int i = 1;
            Teacher teacher = new Teacher(Name, Listclassroom, Matter,Id,Password,Usertype);
            Class newclass = new Class(date, Matter, location, teacher, classroom);
            foreach(Student student in Listclassroom[i].classroom)
            {
                student.Timetable.listclass.Add(newclass);
            }

        }

        public void Attendance(Classroom classroom)
        {
            foreach(Student student in classroom.classroom)
                {
                    Console.WriteLine ("Is this student" + student.Name  + " here ?");

                    string answer = Console.ReadLine();

                    if (answer == "Yes") break;

                    if (answer == "No") student.Nonattendance ++;

                    else Console.WriteLine ("Error");
                }
        }


        public void TeacherMenu()
        {

        }


    }
}
