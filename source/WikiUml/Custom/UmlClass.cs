using System.Collections.Generic;

namespace WikiUml
{
    public class UmlClass
    {
        public string Name;
        public List<Member> Members = new List<Member>();
        public List<Method> Methods = new List<Method>();
    }

    public class Member
    {
        public string Name;
    }

    public class Method
    {
        public string Name;
    }
}
