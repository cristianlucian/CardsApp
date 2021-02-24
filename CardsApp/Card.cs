using System;
using System.Collections.Generic;

namespace CardsApp
{
    public class Card
    {
        public string Type { get; set; }

        public string Customer { get; set; }

        public string Receiver { get; set; }

        public string Message;

        //List<Customer> customers = new List<Customer>();


        public Card()
        {
            
        }

        public override string ToString()
        {
            return String.Format("Type: {0} \nCustomer: {1} \nReceiver: {2} \nMessage: {3}", Type, Customer, Receiver, Message);
        }
    }
}

