// $ANTLR 3.1.1 D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g 2011-01-24 23:39:30
// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  WikiUml 
{

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class WikiUmlLexer : Lexer {
    public const int WS = 6;
    public const int NEWLINE = 8;
    public const int T__10 = 10;
    public const int UMLCLASS = 5;
    public const int ID = 7;
    public const int EOF = -1;
    public const int ROOT = 4;
    public const int T__9 = 9;

    // delegates
    // delegators

    public WikiUmlLexer() 
    {
		InitializeCyclicDFAs();
    }
    public WikiUmlLexer(ICharStream input)
		: this(input, null) {
    }
    public WikiUmlLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g";} 
    }

    // $ANTLR start "UMLCLASS"
    public void mUMLCLASS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UMLCLASS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:9:10: ( 'umlclass' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:9:12: 'umlclass'
            {
            	Match("umlclass"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UMLCLASS"

    // $ANTLR start "T__9"
    public void mT__9() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__9;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:10:6: ( '[' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:10:8: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__9"

    // $ANTLR start "T__10"
    public void mT__10() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__10;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:11:7: ( ']' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:11:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__10"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '.' )+ )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:7: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '.' )+
            {
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:7: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '.' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == '.' || (LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:
            			    {
            			    	if ( input.LA(1) == '.' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee =
            		                new EarlyExitException(1, input);
            		            throw eee;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:29:5: ( ( '\\r' )? '\\n' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:29:7: ( '\\r' )? '\\n'
            {
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:29:7: ( '\\r' )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == '\r') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:29:7: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWLINE"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:33:5: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:33:7: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:33:7: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '\t' && LA3_0 <= '\n') || LA3_0 == '\r' || LA3_0 == ' ') )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee =
            		                new EarlyExitException(3, input);
            		            throw eee;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whinging that label 'loop3' has no statements

            	//skip();

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    override public void mTokens() // throws RecognitionException 
    {
        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:8: ( UMLCLASS | T__9 | T__10 | ID | NEWLINE | WS )
        int alt4 = 6;
        alt4 = dfa4.Predict(input);
        switch (alt4) 
        {
            case 1 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:10: UMLCLASS
                {
                	mUMLCLASS(); 

                }
                break;
            case 2 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:19: T__9
                {
                	mT__9(); 

                }
                break;
            case 3 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:24: T__10
                {
                	mT__10(); 

                }
                break;
            case 4 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:30: ID
                {
                	mID(); 

                }
                break;
            case 5 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:33: NEWLINE
                {
                	mNEWLINE(); 

                }
                break;
            case 6 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:41: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA4 dfa4;
	private void InitializeCyclicDFAs()
	{
	    this.dfa4 = new DFA4(this);
	}

    const string DFA4_eotS =
        "\x01\uffff\x01\x04\x03\uffff\x01\x07\x01\x09\x01\uffff\x01\x04"+
        "\x01\uffff\x05\x04\x01\x10\x01\uffff";
    const string DFA4_eofS =
        "\x11\uffff";
    const string DFA4_minS =
        "\x01\x09\x01\x6d\x03\uffff\x01\x0a\x01\x09\x01\uffff\x01\x6c\x01"+
        "\uffff\x01\x63\x01\x6c\x01\x61\x02\x73\x01\x2e\x01\uffff";
    const string DFA4_maxS =
        "\x01\x7a\x01\x6d\x03\uffff\x01\x0a\x01\x20\x01\uffff\x01\x6c\x01"+
        "\uffff\x01\x63\x01\x6c\x01\x61\x02\x73\x01\x7a\x01\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x02\uffff\x01\x06\x01\uffff"+
        "\x01\x05\x06\uffff\x01\x01";
    const string DFA4_specialS =
        "\x11\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x07\x01\x06\x02\uffff\x01\x05\x12\uffff\x01\x07\x0d\uffff"+
            "\x01\x04\x01\uffff\x0a\x04\x07\uffff\x1a\x04\x01\x02\x01\uffff"+
            "\x01\x03\x03\uffff\x14\x04\x01\x01\x05\x04",
            "\x01\x08",
            "",
            "",
            "",
            "\x01\x06",
            "\x02\x07\x02\uffff\x01\x07\x12\uffff\x01\x07",
            "",
            "\x01\x0a",
            "",
            "\x01\x0b",
            "\x01\x0c",
            "\x01\x0d",
            "\x01\x0e",
            "\x01\x0f",
            "\x01\x04\x01\uffff\x0a\x04\x07\uffff\x1a\x04\x06\uffff\x1a"+
            "\x04",
            ""
    };

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( UMLCLASS | T__9 | T__10 | ID | NEWLINE | WS );"; }
        }

    }

 
    
}
}