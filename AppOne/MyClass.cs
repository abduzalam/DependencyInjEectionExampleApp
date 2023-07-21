using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOne
{
    /// <summary>
    /// In a more application, MyClass might have dependencies on the other services
    /// which could be injected into its constructor. These services would also need to be
    /// registered in ConfigureServices.
    /// </summary>
    public class MyClass
    {
        private readonly MyOtherClass _myOtherClass;
        public MyClass(MyOtherClass myOtherClass)
        {
            _myOtherClass = myOtherClass;
        }
        public void DoSomething()
        {
            _myOtherClass.DoSomethingElse();
        }
    }
}
