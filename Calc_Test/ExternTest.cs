using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Calc_Test
{
    [TestFixture]
    public class ExternTest
    {

    [DllImport(@"C:\Users\User\source\repos\Calc_Extern\Debug\Calc_Extern.dll", CallingConvention =
        CallingConvention.Cdecl)]

    public static extern double Calc(double fnum, double snum, char op);

        [TestCase(1, 0, '+', 1)]
        [TestCase(1, 9, '+', 10)]
        [TestCase(5, 15, '+', 20)]
        [TestCase(2, 8, '+', 10)]
        [Test]

        public void Calc_Test(double fnum, double snum, char op, double exp)
        {
            Assert.AreEqual(exp, Calc(fnum, snum, op));
        }
    }
}
