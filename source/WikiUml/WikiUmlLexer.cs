// $ANTLR 3.1.1 D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g 2011-01-26 22:12:09
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
    public const int NEWLINE = 4;
    public const int T__12 = 12;
    public const int T__14 = 14;
    public const int T__13 = 13;
    public const int NUMBER = 10;
    public const int ALPHACHAR = 11;
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

    // $ANTLR start "T__12"
    public void mT__12() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__12;
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
    // $ANTLR end "T__12"

    // $ANTLR start "T__13"
    public void mT__13() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__13;
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
    // $ANTLR end "T__13"

    // $ANTLR start "T__14"
    public void mT__14() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__14;
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
    // $ANTLR end "T__14"

    // $ANTLR start "RBRACK"
    public void mRBRACK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRACK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:30:9: ( ']' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:30:12: ']'
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:31:9: ( '[' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:31:12: '['
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:32:19: ( '|' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:32:21: '|'
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

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:35:9: ( ( '\\r' )? '\\n' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:35:11: ( '\\r' )? '\\n'
            {
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:35:11: ( '\\r' )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == '\r') )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:35:11: '\\r'
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

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:37:4: ( ( VALIDSTR | NUMBER ) )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:37:7: ( VALIDSTR | NUMBER )
            {
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:37:7: ( VALIDSTR | NUMBER )
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( ((LA2_0 >= 'A' && LA2_0 <= 'Z') || LA2_0 == '_' || (LA2_0 >= 'a' && LA2_0 <= 'z')) )
            	{
            	    alt2 = 1;
            	}
            	else if ( (LA2_0 == '-' || (LA2_0 >= '0' && LA2_0 <= '9')) )
            	{
            	    alt2 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:37:10: VALIDSTR
            	        {
            	        	mVALIDSTR(); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:38:11: NUMBER
            	        {
            	        	mNUMBER(); 

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
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '0' && LA3_0 <= '9') || (LA3_0 >= 'A' && LA3_0 <= 'Z') || LA3_0 == '_' || (LA3_0 >= 'a' && LA3_0 <= 'z')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
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
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "VALIDSTR"

    // $ANTLR start "NUMBER"
    public void mNUMBER() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:56:5: ( ( '-' )? ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:56:8: ( '-' )? ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
            {
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:56:8: ( '-' )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == '-') )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:56:9: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:56:15: ( '0' .. '9' )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:56:16: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt5 >= 1 ) goto loop5;
            		            EarlyExitException eee =
            		                new EarlyExitException(5, input);
            		            throw eee;
            	    }
            	    cnt5++;
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whinging that label 'loop5' has no statements

            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:56:27: ( '.' ( '0' .. '9' )+ )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == '.') )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:56:28: '.' ( '0' .. '9' )+
            	        {
            	        	Match('.'); 
            	        	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:56:32: ( '0' .. '9' )+
            	        	int cnt6 = 0;
            	        	do 
            	        	{
            	        	    int alt6 = 2;
            	        	    int LA6_0 = input.LA(1);

            	        	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
            	        	    {
            	        	        alt6 = 1;
            	        	    }


            	        	    switch (alt6) 
            	        		{
            	        			case 1 :
            	        			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:56:33: '0' .. '9'
            	        			    {
            	        			    	MatchRange('0','9'); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    if ( cnt6 >= 1 ) goto loop6;
            	        		            EarlyExitException eee =
            	        		                new EarlyExitException(6, input);
            	        		            throw eee;
            	        	    }
            	        	    cnt6++;
            	        	} while (true);

            	        	loop6:
            	        		;	// Stops C# compiler whinging that label 'loop6' has no statements


            	        }
            	        break;

            	}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUMBER"

    override public void mTokens() // throws RecognitionException 
    {
        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:8: ( T__12 | T__13 | T__14 | RBRACK | LBRACK | SECTIONSEPPERATOR | NEWLINE | ID )
        int alt8 = 8;
        switch ( input.LA(1) ) 
        {
        case ';':
        	{
            alt8 = 1;
            }
            break;
        case '(':
        	{
            alt8 = 2;
            }
            break;
        case ')':
        	{
            alt8 = 3;
            }
            break;
        case ']':
        	{
            alt8 = 4;
            }
            break;
        case '[':
        	{
            alt8 = 5;
            }
            break;
        case '|':
        	{
            alt8 = 6;
            }
            break;
        case '\n':
        case '\r':
        	{
            alt8 = 7;
            }
            break;
        case '-':
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
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
            alt8 = 8;
            }
            break;
        	default:
        	    NoViableAltException nvae_d8s0 =
        	        new NoViableAltException("", 8, 0, input);

        	    throw nvae_d8s0;
        }

        switch (alt8) 
        {
            case 1 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:10: T__12
                {
                	mT__12(); 

                }
                break;
            case 2 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:16: T__13
                {
                	mT__13(); 

                }
                break;
            case 3 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:22: T__14
                {
                	mT__14(); 

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
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:60: NEWLINE
                {
                	mNEWLINE(); 

                }
                break;
            case 8 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:68: ID
                {
                	mID(); 

                }
                break;

        }

    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}
}