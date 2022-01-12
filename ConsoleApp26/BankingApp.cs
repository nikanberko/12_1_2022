using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    class BankingApp
    {
        string username;
        decimal paymentAmount;
        string recipient;

        public BankingApp(string username, decimal paymentAmount, string recipient)
        {
            this.username = username;
            this.paymentAmount = paymentAmount;
            this.recipient = recipient;
        }

        public string Pay(Func<string,decimal,string> PaymentService)
        {
            return username + " - " + PaymentService(recipient, paymentAmount);
        }

    }
}

    //Napravite klasu kalkulator koja omogućuje rad s matematičkim operacijama +, -, * i /.
    //Klasa sadrži stanja za dva double broja x i y. Koristiti Automatska svojstva. Omogućiti postavljanje brojeva x i y.
    //Definirati metodu Calculate() koja kao argument prima funkciju za računanje(+,-,*,/) te vraća rezultat ovisno o primljenoj funkciji.
    //Kalkulator isključivo radi s dva broja koja su predstavljena stanjima klase.
