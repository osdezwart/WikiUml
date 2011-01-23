grammar WikiUml;

options
{
    language=CSharp2;
}

tokens {
    GET='get';
    PUT='put';
    CHANGE='change';
    DATA='data';
    METADATA='metadata';
    DEPENDENCIES='dependencies';
    DEPENDENTS='dependents';
    STATISTICS='statistics';
    FROM='from';
    IN='in';
    ABOUT='about';
    OF='of';
}

command
    :    sentence (NEWLINE sentence)* NEWLINE? EOF
    |
    ;

sentence
    :    WS? verb WS object WS preposition WS target WS?
    ;

verb
    :    GET
    |    PUT
    |    CHANGE
    ;

object
    :    DATA
    |    METADATA
    |    DEPENDENCIES
    |    DEPENDENTS
    |    STATISTICS
    ;

preposition
    :    FROM
    |    IN
    |    ABOUT
    |    OF
    ;

target
    :    FILE
    ;

FILE
    : ('a'..'z'|'A'..'Z'|'0'..'9'|'.')+
    ;

NEWLINE
    : '\r'? '\n'
    ;

WS
    : (' '|'\t'|'\n'|'\r')+ {skip();}
    ;