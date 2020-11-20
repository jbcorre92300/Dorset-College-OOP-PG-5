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
    class Student : InterfacePayment                                                     
    {
        public string name;
        int id;
        public int classroom;
        public List<string> profil;
        public TimeTable timetable;
        public List<Grade> listgrade;
        private int cost;
        public int nonattendance;
        
        public int Cost
        {
            get { return cost; }
        }


        public Student(string name, int classroom, List<string> profil,TimeTable timetable, List<Grade> listgrade, int cost)
        {
            this.name = name;
            this.classroom = classroom;
            this.profil = profil;
            this.timetable = timetable;
            this.listgrade = listgrade;
            this.cost = cost;
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
            Console.WriteLine("Please pay " + cost + " euros" + "\n" + "Enter your number card : ");

            int numbercard = Convert.ToInt32(Console.ReadLine()); // faire un solde pour l'étudiant, si l'étudiant à le solde demandé, alors retourner true, sinon false.

            Console.WriteLine("Successfull Payment !");

        }


        public void SeveralTimesPayment()
        {
            int remainingpayment = cost;
            int alreadypaid = 0;

            Console.WriteLine("How much do you want to pay right now ? : ");

            int payment = Convert.ToInt32(Console.ReadLine());

            remainingpayment -= payment;

            alreadypaid += payment;

            if (remainingpayment == 0 && alreadypaid == cost) Console.WriteLine("Your payment is complete !");

            else Console.WriteLine("There is " + remainingpayment + " euros left to pay");
        }

        
    }   
    
}
