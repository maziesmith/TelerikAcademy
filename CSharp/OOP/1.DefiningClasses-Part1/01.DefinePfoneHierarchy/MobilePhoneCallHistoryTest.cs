﻿using System;
using System.Collections.Generic;

/* Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.

namespace DefinePfoneHierarchy
{
    public class MobilePhoneCallHistoryTest
    {
        public static void Main()
        {
            MobilePhone phone = new MobilePhone("S4", "Samsung", 200, "Me"
                , new Display(2, 1000000), new Battery("t56", 20, 22));

            MobilePhoneTest.DisplayInformation();

            phone.AddCall(new Call(DateTime.Now, "0880000000", 1.45));
            phone.AddCall(new Call(DateTime.Now, "0880000000", 3.45));
            phone.AddCall(new Call(DateTime.Now, "0880000000", 0.20));

            // show all calls
            phone.ShowAllCalls();

            // calculate price
            double price = phone.CalculatePriceOfAllCalls(0.37);
            Console.WriteLine("All price is: {0}", price);

            // find longest call
            double longCall = 0;
            for (int i = 0; i < phone.CallList.Count; i++)
            {
                if (phone.CallList[i].Duration > longCall)
                {
                    longCall = i;
                }
            }

            // remove longest call
            phone.RemoveCall((int)longCall);

            // calculate price again
            double price2 = phone.CalculatePriceOfAllCalls(0.37);
            Console.WriteLine("All price is: {0}", price2);

            // clear all calls
            phone.ClearAllCalls();

            // it must return 0
            double price3 = phone.CalculatePriceOfAllCalls(0.37);
            Console.WriteLine("All price is: {0}", price3);
        }
    }
}