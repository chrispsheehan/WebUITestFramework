using TechTalk.SpecFlow;
using System;

namespace Framework.Hooks
{
    [Binding]
    public class Hook
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("started");
        }
    }
}