using System;
using System.Collections.Generic;
using System.Text;

namespace oop_group5_project
{                                                               //23024 Thomas BAUDU 
                                                                //23189 Audrey CHANTY
                                                                //23182 Jean-Baptiste CORRE
                                                                //23165 Victor FAUCHARD
                                                                //23213 Tristan GERON
                                                                //23164 Alexandre MAROTTE
    class Student : Platform, InterfacePayment
        
    {
        public string Name { get; set; }
        public Classroom Classroom { get; set; }
        public List<string> Profil { get; set; }
        public TimeTable Timetable { get; set; }
        public List<Grade> Listgrade { get; set; }
        public int Cost { get; set; }
        public int Nonattendance { get; set; }
        
       


        public Student(string name, Classroom classroom, List<string> profil,TimeTable timetable, List<Grade> listgrade, int cost,string id,string password,string usertype)
        : base(id, password, usertype)
        {
            Name = name;
            Classroom = classroom;
            Profil = profil;
            Timetable = timetable;
            Listgrade = listgrade;
            Cost = cost;
            Nonattendance = 0;
        }



        /*
        public void makeapaiment(double paiment)
        {
            if (paiment > payment.cost - payment.alreadypaid)
            {
                paiment = payment.cost - payment.alreadypaid;
            }
            payment.alreadypaid += paiment;
        }
        */

         public void BeginningPayment()
         {
            Console.WriteLine("How do you want to make your payment ?" +
                "1 for Cash Payment" +
                "2 for Several Times Payment");

            if (Console.ReadLine() == "1") CashPayment();

            if (Console.ReadLine() == "2") SeveralTimesPayment();

            else
            {
                Console.WriteLine("Error, please try again");
                BeginningPayment();
            }
         }


        public void CashPayment()
        {
            Console.WriteLine("Please pay " + Cost + " euros" + "\n" + "Enter your number card : ");

            int numbercard = Convert.ToInt32(Console.ReadLine()); // faire un solde pour l'étudiant, si l'étudiant à le solde demandé, alors retourner true, sinon false.

            Console.WriteLine("Successfull Payment !");

        }


        public void SeveralTimesPayment()
        {
            int remainingpayment = Cost;
            int alreadypaid = 0;

            Console.WriteLine("How much do you want to pay right now ? : ");

            int payment = Convert.ToInt32(Console.ReadLine());

            remainingpayment -= payment;

            alreadypaid += payment;

            if (remainingpayment == 0 && alreadypaid == Cost) Console.WriteLine("Your payment is complete !");

            else Console.WriteLine("There is " + remainingpayment + " euros left to pay");
        }

        
    }   
    
}
