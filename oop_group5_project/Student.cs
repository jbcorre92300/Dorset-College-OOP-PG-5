using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{                                                               
    class Student                                                      
    {
        //23024 Thomas BAUDU 
        //23189 Audrey CHANTY
        //23182 Jean-Baptiste CORRE
        //23165 Victor FAUCHARD
        //23213 Tristan GERON
        //23164 Alexandre MAROTTE
        public int classroom;
        public List<string> profil;
        public TimeTable timetable;
        public Payment payment;
        public List<Grade> listgrade;


        public Student(int classroom, List<string> profil,TimeTable timetable, Payment payment, List<Grade> listgrade)
        {
            this.classroom = classroom;
            this.profil = profil;
            this.timetable = timetable;
            this.payment = payment;
            this.listgrade = listgrade;
        }



        public void makeapaiment(double paiment)
        {
            if (paiment > payment.cost - payment.alreadypaid)
            {
                paiment = payment.cost - payment.alreadypaid;
            }
            payment.alreadypaid += paiment;
        }
    }   
    
}
