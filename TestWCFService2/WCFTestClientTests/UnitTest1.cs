using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFTestClient;
using WCFTestClientTests.ServiceReference1;
using System.Collections.Generic;
using System.Diagnostics;

namespace WCFTestClientTests
{
    [TestClass]
    public class WCFClientUnitTests
    {
        [TestMethod]
        public void HelloWorld()
        {
            WCFTestClient.Methods methods = new Methods();

            try
            {
                string result = methods.HelloWorld();
                Assert.AreEqual("Hello World", result);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
        [TestMethod]
        public void GetValue()
        {
            WCFTestClient.Methods methods = new Methods();

            try
            {
                int value = 5;
                string result = methods.GetValue(value);
                Assert.IsTrue(result.Contains(value.ToString()));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
        [TestMethod]
        public void Get100Values()
        {
            WCFTestClient.Methods methods = new Methods();
            Random rnd = new Random();
            try
            {
                List<int> values = new List<int>();
                List<string> results = new List<string>();

                for (int i=0; i<100; i++)
                {
                    values.Add(rnd.Next(0, sizeof(int) - 1));
                }

                Stopwatch watch = new Stopwatch();
                watch.Start();
                foreach (int i in values)
                    results.Add(methods.GetValue(i));
                watch.Stop();

                //Assert.Fail(watch.ElapsedMilliseconds.ToString());
                Assert.AreEqual(values.Count, results.Count);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
    }
}
