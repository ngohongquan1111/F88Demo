
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Services.LoanServices.AddLoan
{
    public interface ITestDI
    {
        void DoSomething();
    }
    public class TestDI : ITestDI
    {
        public void DoSomething()
        {
            Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        }
    }
}