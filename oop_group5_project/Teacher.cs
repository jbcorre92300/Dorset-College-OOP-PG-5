using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace oop_group5_project
{
   class Teacher : User//, ManageAttendance
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
            Grade grade = new Grade(gradename, Matter, note);
            student.Listgrade.Add(grade);
        }

        public void AddaClassforaClassroom(int classname, Date date, string location, Classroom classroom)
        {
            //int i = l'index de la classe dans la liste de class du teacher
            int i = 1;
            Teacher teacher = new Teacher(Name, Listclassroom, Matter,Id,Password,Usertype);
            Class newclass = new Class(date, Matter, location, teacher);
            foreach(Student student in Listclassroom[i].Classroomlist)
            {
                student.Timetable.Listclass.Add(newclass);
            }

        }

        public void Attendance(Classroom classroom,Class cours)
        {
            foreach(Student student in classroom.Classroomlist)
                {
                    Console.WriteLine ("Is this student" + student.Name  + " here ?");

                    string answer = Console.ReadLine();

                    if (answer == "Yes") break;

                    if (answer == "No") student.Nonattendance.Add(cours);

                    else Console.WriteLine ("Error");
                }
        }


       public void TeacherMenu()
        {
                Console.Clear();
                Console.WriteLine($"Welcome {Name}, choose an option :\n1)Attendance \n2)Add class\n3)Add a Graduation for exams");
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                  
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Choose the classroom you want to attempted");
                        string desiredclassroom = Console.ReadLine();

                        foreach(Classroom element in Listclassroom)
                        {
                            if (desiredclassroom == element.Name)
                            {
                                Attendance(element,);
                            }
                            else
                            {
                                Console.WriteLine("The student is not here"); 
                            }

                        }
                        
                        break;
                        
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Choose the class you want to be added in a classroom");
                        string addedclassroom = Console.Readline();
                        foreach(classroom element in Listclassroom)
                        {
                          if(addedclassroom
                        }
                        AddaClassforaClassroom();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Chosse the class you want to be graded ");
                        AddaGradeforaStudent();
                        break;
                
                }
            
      }

    }
}
