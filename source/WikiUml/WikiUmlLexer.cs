// $ANTLR 3.1.1 D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g 2011-01-27 18:47:29
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
    public const int RBRACK = 7;
    public const int LBRACK = 5;
    public const int WS = 4;
    public const int T__12 = 12;
    public const int T__11 = 11;
    public const int T__13 = 13;
    public const int ALPHACHAR = 10;
    public const int SECTIONSEPPERATOR = 8;
    public const int ID = 6;
    public const int EOF = -1;
    public const int VALIDSTR = 9;

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

    // $ANTLR start "T__11"
    public void mT__11() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__11;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:9:7: ( ';' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:9:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__11"

    // $ANTLR start "T__12"
    public void mT__12() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__12;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:10:7: ( '(' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:10:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__12"

    // $ANTLR start "T__13"
    public void mT__13() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__13;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:11:7: ( ')' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:11:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__13"

    // $ANTLR start "RBRACK"
    public void mRBRACK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRACK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:32:9: ( ']' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:32:12: ']'
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
    // $ANTLR end "RBRACK"

    // $ANTLR start "LBRACK"
    public void mLBRACK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBRACK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:33:9: ( '[' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:33:12: '['
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
    // $ANTLR end "LBRACK"

    // $ANTLR start "SECTIONSEPPERATOR"
    public void mSECTIONSEPPERATOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SECTIONSEPPERATOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:34:19: ( '|' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:34:21: '|'
            {
            	Match('|'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SECTIONSEPPERATOR"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:39:4: ( VALIDSTR )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:39:9: VALIDSTR
            {
            	mVALIDSTR(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "ALPHACHAR"
    public void mALPHACHAR() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:42:2: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:42:5: ( 'a' .. 'z' | 'A' .. 'Z' | '_' )
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "ALPHACHAR"

    // $ANTLR start "VALIDSTR"
    public void mVALIDSTR() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:49:5: ( ALPHACHAR ( ALPHACHAR | '0' .. '9' )* )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:49:8: ALPHACHAR ( ALPHACHAR | '0' .. '9' )*
            {
            	mALPHACHAR(); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:50:9: ( ALPHACHAR | '0' .. '9' )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
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
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "VALIDSTR"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:56:5: ( ( ' ' | '\\t' | '\\r' '\\n' | '\\n' ) )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:57:8: ( ' ' | '\\t' | '\\r' '\\n' | '\\n' )
            {
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:57:8: ( ' ' | '\\t' | '\\r' '\\n' | '\\n' )
            	int alt2 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case ' ':
            		{
            	    alt2 = 1;
            	    }
            	    break;
            	case '\t':
            		{
            	    alt2 = 2;
            	    }
            	    break;
            	case '\r':
            		{
            	    alt2 = 3;
            	    }
            	    break;
            	case '\n':
            		{
            	    alt2 = 4;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d2s0 =
            		        new NoViableAltException("", 2, 0, input);

            		    throw nvae_d2s0;
            	}

            	switch (alt2) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:57:12: ' '
            	        {
            	        	Match(' '); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:58:12: '\\t'
            	        {
            	        	Match('\t'); 

            	        }
            	        break;
            	    case 3 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:59:12: '\\r' '\\n'
            	        {
            	        	Match('\r'); 
            	        	Match('\n'); 

            	        }
            	        break;
            	    case 4 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:60:12: '\\n'
            	        {
            	        	Match('\n'); 

            	        }
            	        break;

            	}


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
        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:8: ( T__11 | T__12 | T__13 | RBRACK | LBRACK | SECTIONSEPPERATOR | ID | WS )
        int alt3 = 8;
        switch ( input.LA(1) ) 
        {
        case ';':
        	{
            alt3 = 1;
            }
            break;
        case '(':
        	{
            alt3 = 2;
            }
            break;
        case ')':
        	{
            alt3 = 3;
            }
            break;
        case ']':
        	{
            alt3 = 4;
            }
            break;
        case '[':
        	{
            alt3 = 5;
            }
            break;
        case '|':
        	{
            alt3 = 6;
            }
            break;
        case 'A':
        case 'B':
        case 'C':
        case 'D':
        case 'E':
        case 'F':
        case 'G':
        case 'H':
        case 'I':
        case 'J':
        case 'K':
        case 'L':
        case 'M':
        case 'N':
        case 'O':
        case 'P':
        case 'Q':
        case 'R':
        case 'S':
        case 'T':
        case 'U':
        case 'V':
        case 'W':
        case 'X':
        case 'Y':
        case 'Z':
        case '_':
        case 'a':
        case 'b':
        case 'c':
        case 'd':
        case 'e':
        case 'f':
        case 'g':
        case 'h':
        case 'i':
        case 'j':
        case 'k':
        case 'l':
        case 'm':
        case 'n':
        case 'o':
        case 'p':
        case 'q':
        case 'r':
        case 's':
        case 't':
        case 'u':
        case 'v':
        case 'w':
        case 'x':
        case 'y':
        case 'z':
        	{
            alt3 = 7;
            }
            break;
        case '\t':
        case '\n':
        case '\r':
        case ' ':
        	{
            alt3 = 8;
            }
            break;
        	default:
        	    NoViableAltException nvae_d3s0 =
        	        new NoViableAltException("", 3, 0, input);

        	    throw nvae_d3s0;
        }

        switch (alt3) 
        {
            case 1 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:10: T__11
                {
                	mT__11(); 

                }
                break;
            case 2 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:16: T__12
                {
                	mT__12(); 

                }
                break;
            case 3 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:22: T__13
                {
                	mT__13(); 

                }
                break;
            case 4 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:28: RBRACK
                {
                	mRBRACK(); 

                }
                break;
            case 5 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:35: LBRACK
                {
                	mLBRACK(); 

                }
                break;
            case 6 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:42: SECTIONSEPPERATOR
                {
                	mSECTIONSEPPERATOR(); 

                }
                break;
            case 7 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:60: ID
                {
                	mID(); 

                }
                break;
            case 8 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:63: WS
                {
                	mWS(); 

                }
                break;

        }

    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}
}