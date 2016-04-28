using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FakeItEasy;

namespace AutoFakker
{
    public static class F
    {
    }

    public class AutoFaker
    {
        private ClassFaker _class;

        public AutoFaker()
        {
            _class = new ClassFaker();
        }

        public T Create<T>()
        {
            var fake = A.Fake<T>();
            
            return fake;
        }
    }

    public class ClassMemberFinder
    {
        
    }

    public class ClassFaker
    {

    }


}
