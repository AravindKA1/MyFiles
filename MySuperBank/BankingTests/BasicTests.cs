using MyBankyStuffLibrary;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test2()
        {
            var account = new BankAccount("Aravind", 10000);

            Assert.Throws<InvalidOperationException>(() => account.MakeWithdrawal(11120, DateTime.Now, "Gold"));
        }
    }
}
