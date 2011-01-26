grammar WikiUml;

options {
  language=CSharp2;
}

@parser::namespace { WikiUml }
@lexer::namespace { WikiUml }

@header {
using System.Collections.Generic;
}

diagram returns [Diagram result] 
@init {
	result = new Diagram();
} : (u = umlclass NEWLINE) { $result.umlClasses.Add(u);} | ;

umlclass returns [UmlClass result] 
@init {
	result = new UmlClass();
} : LBRACK f = ID mem = members met = methods RBRACK { $result.Name = $f.text; $result.Members.AddRange(mem); $result.Methods.AddRange(met);}  ;

members returns [List<Member> members] @init{members = new List<Member>();} :	SECTIONSEPPERATOR (m = member ';'?)*{members.Add(m);};
member 	returns [Member member] @init{member = new Member();}:	i = ID {member.Name = $i.text;};

methods returns [List<Method> methods] @init{methods = new List<Method>();} :	SECTIONSEPPERATOR (m = method ';'?)*{methods.Add(m);};
method 	returns [Method method] @init{method = new Method();} :	m = ID'('')'{method.Name= $m.text;};

RBRACK 	:	 ']';
LBRACK 	:	 '[';
SECTIONSEPPERATOR : '|';


NEWLINE	:	'\r'? '\n';

ID	:  (  VALIDSTR
        | NUMBER
       );
       
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

fragment NUMBER
    :  ('-')? ('0'..'9')+ ('.' ('0'..'9')+)?
    ;
