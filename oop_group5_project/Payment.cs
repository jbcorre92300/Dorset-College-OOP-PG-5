﻿using System;
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
    class Payment                                     
    {
        public int cost;
        public int alreadypaid;
        public int remainingpayment;

        public Payment(int a)
        {
            cost = a;
        }


        public void BeginningPayment()
        {
            cost = remainingpayment;

            Console.WriteLine("How do you want to make your payment ?" +
                "1 for Cash Payment" +
                "2 for Several Times Payment");

            if (Console.ReadLine() == "1") CashPayment();

            if (Console.ReadLine() == "2") SeveralTimesPayment();

            else
            {
                Console.WriteLine("Error");
                BeginningPayment();
            }
        }


        public void CashPayment()
        {
            Console.WriteLine("Please pay " + cost + " euros" + "\n" + "Enter your card number : ");

            int numbercard = Convert.ToInt32(Console.ReadLine()); // faire un solde pour l'étudiant, si l'étudiant à le solde demandé, alors retourner true, sinon false.

            remainingpayment = 0;
            alreadypaid = cost;

            Console.WriteLine("Successfull Payment !");

        }


        public void SeveralTimesPayment()
        {
            Console.WriteLine("How much do you want to pay right now ? : ");

            int payment = Convert.ToInt32(Console.ReadLine());

            remainingpayment -= payment;
            alreadypaid += payment;

            if (remainingpayment == 0 && alreadypaid == cost) Console.WriteLine("Your payment is complete !");

            else Console.WriteLine("There is " + remainingpayment + " euros left to pay");
        }


    }
}