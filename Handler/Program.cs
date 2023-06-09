﻿using System;

namespace Handler
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler emailHandler = new SpamHandler(
                new FanHandler(
                    new ComplaintHandler(
                        new NewLocHandler(null))));

            Email eSpam = new Email(EmailType.Spam, "Dear Dir, I am a Nigerian prince in need to transfer large sums of money out of the country. All i need is your bank account number...");

            emailHandler.HandleRequest(eSpam);

            Email eFan = new Email(EmailType.Fan, " I love your gumball machines! Please stock them with more bubble gum flavors :-)");
            emailHandler.HandleRequest(eFan);

            Email eComplaint = new Email(EmailType.Complaint, "I swear, if i get one more black licorice flavored gumball, im going to break your machines!");
            emailHandler.HandleRequest(eComplaint);

            Email eOther = new Email(EmailType.Unclassified, " We would love to have one of your machines installed in our dentist waiting room..");
            emailHandler.HandleRequest(eOther);
                }
    }
}
