grammar WikiUml;

options {
  language=CSharp2;
}

@parser::namespace { WikiUml }
@lexer::namespace { WikiUml }

@header {
using System.Collections.Generic;

}

@members {
Dictionary<string, UmlClass> umlClasses = new Dictionary<string, UmlClass>();
List<UmlClass> unnamedUmlClasses = new List<UmlClass>();
}

diagram returns [Diagram result] 
@init {
	result = new Diagram();
}  :(associated_classes)+ EOF { $result.umlClasses.AddRange(umlClasses.Values); result.umlClasses.AddRange(unnamedUmlClasses);}  | ;

associated_classes @init{var result = new List<UmlClass>();}
	: WS* ua=umlclass (a = association ub=umlclass
{
	if(ua != null) 
	{
		result.Add(ua);
		if(a != null)
		{
			a.UmlClassA = ua;
			ua.AddAssociation(a);
		}
	}
	if(ub != null) 
	{
		result.Add(ub); 
		if(a != null) 
		{
			a.UmlClassB = ub; 
		}
		ua = ub;
	}
})*;

umlclass returns [UmlClass result] 
@init {
	result = new UmlClass();
} : LBRACK f = ID? (mem = members met = methods)? RBRACK 
{ 
	if ($f != null && !string.IsNullOrEmpty($f.Text))
        {
        	if (umlClasses.ContainsKey((($f != null) ? $f.Text : null)))
        		$result = umlClasses[(($f != null) ? $f.Text : null)];
                }
                $result.Name = (($f != null) ? $f.Text : null);
                if (mem != null) $result.Members.AddRange(mem);
                if (met != null) $result.Methods.AddRange(met);

                if ($f != null && !string.IsNullOrEmpty($f.Text))
                {
                	umlClasses[(($f != null) ? $f.Text : null)] = $result;
                }
                else
                {
                        unnamedUmlClasses.Add($result);
                }	
	
};

members returns [List<Member> members] @init{members = new List<Member>();} :	SECTIONSEPPERATOR (m = member ';'?)*{if(m != null) members.Add(m);};
member 	returns [Member member] @init{member = new Member();}:	i = ID {member.Name = $i.text;};

methods returns [List<Method> methods] @init{methods = new List<Method>();} :	SECTIONSEPPERATOR (m = method ';'?)*{if(m != null) methods.Add(m);};
method 	returns [Method method] @init{method = new Method();} :	m = ID'('')'{method.Name= $m.text;};

association returns [Association association] @init{association = new Association();} : a = (SIMPLE_ASSOCIATION | DIRECTIONAL_ASSOCIATION |  BIDECTIONAL_ASSOCIATION) 
{
	if(a.Type == SIMPLE_ASSOCIATION) association.Type = AssociationType.Simple; 
	else if(a.Type == DIRECTIONAL_ASSOCIATION) association.Type = AssociationType.Directional;
	else if(a.Type == BIDECTIONAL_ASSOCIATION) association.Type = AssociationType.Bidirectional;	
};

RBRACK 	:	 ']';
LBRACK 	:	 '[';
SECTIONSEPPERATOR : '|';

SIMPLE_ASSOCIATION 	:	 '-';
DIRECTIONAL_ASSOCIATION 	:	 '<-' | '->';	
BIDECTIONAL_ASSOCIATION 	:	 '<->';

ID	:    VALIDSTR;
       
fragment ALPHACHAR 
	:  (   'a'..'z'
        |  'A'..'Z'
        |  '_'
       );

	   
fragment VALIDSTR
    :  ALPHACHAR
        (  ALPHACHAR
         |  '0'..'9'
        )*
    ;
    
    WS
    :
       (   ' '
        |  '\t'
        |  '\r' '\n' 
        |  '\n'      
       ) {Skip();}
    ;
