using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyInjectionAndServiceLifetimes.Services;
using DependencyInjectionAndServiceLifetimes.Interfaces;
using Moq;

namespace DependencyInjectionAndServiceLifetimes.Test
{
    [TestClass]
    public class DITest
    {
        [TestMethod]
        public void TestTransient()
        {
            Mock<IExampleTransientService> exampleTransient = new Mock<IExampleTransientService>();
            
            ExampleTransientService exTrancient = new ExampleTransientService();
            
            var sampleTr = exTrancient.GetGuid();
            
            Assert.IsNotNull(exTrancient);
        }
        [TestMethod]
        public void TestScoped()
        {
            Mock<IExampleScopedService> exampleScoped = new Mock<IExampleScopedService>();

            ExampleScopedService exScoped = new ExampleScopedService();

            var sampleSc = exScoped.GetGuid();

            Assert.IsNotNull(sampleSc);
        }
        [TestMethod]
        public void TestSingleton()
        {
            Mock<IExampleSingletonService> exampleSingelton = new Mock<IExampleSingletonService>();

            ExampleSingletonService exSingelton = new ExampleSingletonService();

            var sampleSin = exSingelton.GetGuid();

            Assert.IsNotNull(exSingelton);
        }
    }
}