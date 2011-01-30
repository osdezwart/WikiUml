using System.Collections.Generic;

namespace WikiUml
{
    public class UmlClass
    {
        public string Name;
        public List<Member> Members = new List<Member>();
        public List<Method> Methods = new List<Method>();
        public List<Association> Associations = new List<Association>();

        public void AddAssociation(Association association)
        {
            Associations.Add(association);
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Member
    {
        public string Name;

        public override string ToString()
        {
            return Name;
        }
    }

    public class Method
    {
        public string Name;

        public override string ToString()
        {
            return Name;
        }
    }
}
