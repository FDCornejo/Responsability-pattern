﻿using ResponsabilityChain.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilityChain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility

            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tania = new Secretaria();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tania);
            tania.SetSuccessor(tammy);
         
            // Generate and process purchase requests

            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(8080, 15000.10, "EL cido");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(1587, 45200.10, "Project Rico");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);

            // Wait for user

            Console.ReadKey();
        }
    }
}
