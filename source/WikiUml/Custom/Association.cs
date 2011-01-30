namespace WikiUml
{
    public class Association
    {
        public AssociationType Type;
        private UmlClass _umlClassA;
        public UmlClass UmlClassA
        {
            get { return _umlClassA; }
            set { _umlClassA = value; }
        }
        private UmlClass _umlClassB;
        public UmlClass UmlClassB
        {
            get { return _umlClassB; }
            set { 
                _umlClassB = value;
                value.Associations.Add(this);
            }
        }

        public string LabelA { get; set; }
        public string LabelB { get; set; }
        public string MultiplicityA { get; set; }
        public string MultiplicityB { get; set; }
        
    }
}
