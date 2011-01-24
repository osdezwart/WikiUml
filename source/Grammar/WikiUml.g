grammar WikiUml;

options {
  language=CSharp2;
  output=AST;
}

tokens {
    ROOT;
    UMLCLASS='umlclass';
}

@parser::namespace { WikiUml }
@lexer::namespace { WikiUml }

parse
  :  umlclass EOF -> ^(ROOT umlclass)
  ;

umlclass
    :    WS? '['ID']' WS?
    ;

ID
    : ('a'..'z'|'A'..'Z'|'0'..'9'|'.')+
    ;

NEWLINE
    : '\r'? '\n'
    ;

WS
    : (' '|'\t'|'\n'|'\r')+ {skip();}
    ;
