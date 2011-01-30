// $ANTLR 3.1.1 D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g 2011-01-30 22:51:13
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
    public const int INTEGER = 17;
    public const int INHERRITANCE_ASSOCIATION = 12;
    public const int LBRACK = 5;
    public const int BIDECTIONAL_ASSOCIATION = 11;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int ID = 6;
    public const int EOF = -1;
    public const int VALIDSTR = 14;
    public const int T__19 = 19;
    public const int WS = 4;
    public const int T__18 = 18;
    public const int MM = 13;
    public const int SIMPLE_ASSOCIATION = 9;
    public const int ALPHACHAR = 15;
    public const int DIGIT = 16;
    public const int SECTIONSEPPERATOR = 8;
    public const int DIRECTIONAL_ASSOCIATION = 10;

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

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
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
    // $ANTLR end "T__18"

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
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
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
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
    // $ANTLR end "T__20"

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:12:7: ( '\"' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:12:9: '\"'
            {
            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__21"

    // $ANTLR start "RBRACK"
    public void mRBRACK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRACK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:96:9: ( ']' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:96:12: ']'
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:97:9: ( '[' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:97:12: '['
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:98:19: ( '|' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:98:21: '|'
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

    // $ANTLR start "SIMPLE_ASSOCIATION"
    public void mSIMPLE_ASSOCIATION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SIMPLE_ASSOCIATION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:100:21: ( '-' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:100:24: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SIMPLE_ASSOCIATION"

    // $ANTLR start "DIRECTIONAL_ASSOCIATION"
    public void mDIRECTIONAL_ASSOCIATION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIRECTIONAL_ASSOCIATION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:101:26: ( '<-' | '->' )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == '<') )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == '-') )
            {
                alt1 = 2;
            }
            else 
            {
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("", 1, 0, input);

                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:101:29: '<-'
                    {
                    	Match("<-"); 


                    }
                    break;
                case 2 :
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:101:36: '->'
                    {
                    	Match("->"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIRECTIONAL_ASSOCIATION"

    // $ANTLR start "BIDECTIONAL_ASSOCIATION"
    public void mBIDECTIONAL_ASSOCIATION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BIDECTIONAL_ASSOCIATION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:102:26: ( '<->' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:102:29: '<->'
            {
            	Match("<->"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BIDECTIONAL_ASSOCIATION"

    // $ANTLR start "INHERRITANCE_ASSOCIATION"
    public void mINHERRITANCE_ASSOCIATION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INHERRITANCE_ASSOCIATION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:103:27: ( '^-' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:103:30: '^-'
            {
            	Match("^-"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INHERRITANCE_ASSOCIATION"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:105:4: ( VALIDSTR )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:105:9: VALIDSTR
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:110:2: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:110:5: ( 'a' .. 'z' | 'A' .. 'Z' | '_' )
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

    // $ANTLR start "DIGIT"
    public void mDIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:115:16: ( '0' .. '9' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:115:18: '0' .. '9'
            {
            	MatchRange('0','9'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIGIT"

    // $ANTLR start "INTEGER"
    public void mINTEGER() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:118:2: ( DIGIT ( DIGIT )* )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:118:4: DIGIT ( DIGIT )*
            {
            	mDIGIT(); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:118:10: ( DIGIT )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:118:11: DIGIT
            			    {
            			    	mDIGIT(); 

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "INTEGER"

    // $ANTLR start "MM"
    public void mMM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:123:5: ( ( INTEGER | '*' ) ( '..' ( INTEGER | '*' ) )? )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:123:8: ( INTEGER | '*' ) ( '..' ( INTEGER | '*' ) )?
            {
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:123:8: ( INTEGER | '*' )
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
            	{
            	    alt3 = 1;
            	}
            	else if ( (LA3_0 == '*') )
            	{
            	    alt3 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:123:9: INTEGER
            	        {
            	        	mINTEGER(); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:123:19: '*'
            	        {
            	        	Match('*'); 

            	        }
            	        break;

            	}

            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:123:24: ( '..' ( INTEGER | '*' ) )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == '.') )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:123:25: '..' ( INTEGER | '*' )
            	        {
            	        	Match(".."); 

            	        	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:123:30: ( INTEGER | '*' )
            	        	int alt4 = 2;
            	        	int LA4_0 = input.LA(1);

            	        	if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
            	        	{
            	        	    alt4 = 1;
            	        	}
            	        	else if ( (LA4_0 == '*') )
            	        	{
            	        	    alt4 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    NoViableAltException nvae_d4s0 =
            	        	        new NoViableAltException("", 4, 0, input);

            	        	    throw nvae_d4s0;
            	        	}
            	        	switch (alt4) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:123:31: INTEGER
            	        	        {
            	        	        	mINTEGER(); 

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:123:41: '*'
            	        	        {
            	        	        	Match('*'); 

            	        	        }
            	        	        break;

            	        	}


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
    // $ANTLR end "MM"

    // $ANTLR start "VALIDSTR"
    public void mVALIDSTR() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:126:5: ( ALPHACHAR ( ALPHACHAR | INTEGER )* )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:126:8: ALPHACHAR ( ALPHACHAR | INTEGER )*
            {
            	mALPHACHAR(); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:127:9: ( ALPHACHAR | INTEGER )*
            	do 
            	{
            	    int alt6 = 3;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= 'A' && LA6_0 <= 'Z') || LA6_0 == '_' || (LA6_0 >= 'a' && LA6_0 <= 'z')) )
            	    {
            	        alt6 = 1;
            	    }
            	    else if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
            	    {
            	        alt6 = 2;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:127:12: ALPHACHAR
            			    {
            			    	mALPHACHAR(); 

            			    }
            			    break;
            			case 2 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:128:13: INTEGER
            			    {
            			    	mINTEGER(); 

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:133:5: ( ( ' ' | '\\t' | '\\r' '\\n' | '\\n' ) )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:134:8: ( ' ' | '\\t' | '\\r' '\\n' | '\\n' )
            {
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:134:8: ( ' ' | '\\t' | '\\r' '\\n' | '\\n' )
            	int alt7 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case ' ':
            		{
            	    alt7 = 1;
            	    }
            	    break;
            	case '\t':
            		{
            	    alt7 = 2;
            	    }
            	    break;
            	case '\r':
            		{
            	    alt7 = 3;
            	    }
            	    break;
            	case '\n':
            		{
            	    alt7 = 4;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d7s0 =
            		        new NoViableAltException("", 7, 0, input);

            		    throw nvae_d7s0;
            	}

            	switch (alt7) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:134:12: ' '
            	        {
            	        	Match(' '); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:135:12: '\\t'
            	        {
            	        	Match('\t'); 

            	        }
            	        break;
            	    case 3 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:136:12: '\\r' '\\n'
            	        {
            	        	Match('\r'); 
            	        	Match('\n'); 

            	        }
            	        break;
            	    case 4 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:137:12: '\\n'
            	        {
            	        	Match('\n'); 

            	        }
            	        break;

            	}

            	Skip();

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
        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:8: ( T__18 | T__19 | T__20 | T__21 | RBRACK | LBRACK | SECTIONSEPPERATOR | SIMPLE_ASSOCIATION | DIRECTIONAL_ASSOCIATION | BIDECTIONAL_ASSOCIATION | INHERRITANCE_ASSOCIATION | ID | MM | WS )
        int alt8 = 14;
        alt8 = dfa8.Predict(input);
        switch (alt8) 
        {
            case 1 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:10: T__18
                {
                	mT__18(); 

                }
                break;
            case 2 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:16: T__19
                {
                	mT__19(); 

                }
                break;
            case 3 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:22: T__20
                {
                	mT__20(); 

                }
                break;
            case 4 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:28: T__21
                {
                	mT__21(); 

                }
                break;
            case 5 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:34: RBRACK
                {
                	mRBRACK(); 

                }
                break;
            case 6 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:41: LBRACK
                {
                	mLBRACK(); 

                }
                break;
            case 7 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:48: SECTIONSEPPERATOR
                {
                	mSECTIONSEPPERATOR(); 

                }
                break;
            case 8 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:66: SIMPLE_ASSOCIATION
                {
                	mSIMPLE_ASSOCIATION(); 

                }
                break;
            case 9 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:85: DIRECTIONAL_ASSOCIATION
                {
                	mDIRECTIONAL_ASSOCIATION(); 

                }
                break;
            case 10 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:109: BIDECTIONAL_ASSOCIATION
                {
                	mBIDECTIONAL_ASSOCIATION(); 

                }
                break;
            case 11 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:133: INHERRITANCE_ASSOCIATION
                {
                	mINHERRITANCE_ASSOCIATION(); 

                }
                break;
            case 12 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:158: ID
                {
                	mID(); 

                }
                break;
            case 13 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:161: MM
                {
                	mMM(); 

                }
                break;
            case 14 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:164: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA8 dfa8;
	private void InitializeCyclicDFAs()
	{
	    this.dfa8 = new DFA8(this);
	}

    const string DFA8_eotS =
        "\x08\uffff\x01\x0f\x07\uffff\x01\x0e\x01\uffff";
    const string DFA8_eofS =
        "\x12\uffff";
    const string DFA8_minS =
        "\x01\x09\x07\uffff\x01\x3e\x01\x2d\x06\uffff\x01\x3e\x01\uffff";
    const string DFA8_maxS =
        "\x01\x7c\x07\uffff\x01\x3e\x01\x2d\x06\uffff\x01\x3e\x01\uffff";
    const string DFA8_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x02\uffff\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x09\x01\x08\x01"+
        "\uffff\x01\x0a";
    const string DFA8_specialS =
        "\x12\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x02\x0d\x02\uffff\x01\x0d\x12\uffff\x01\x0d\x01\uffff\x01"+
            "\x04\x05\uffff\x01\x02\x01\x03\x01\x0c\x02\uffff\x01\x08\x02"+
            "\uffff\x0a\x0c\x01\uffff\x01\x01\x01\x09\x04\uffff\x1a\x0b\x01"+
            "\x06\x01\uffff\x01\x05\x01\x0a\x01\x0b\x01\uffff\x1a\x0b\x01"+
            "\uffff\x01\x07",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0e",
            "\x01\x10",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x11",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__18 | T__19 | T__20 | T__21 | RBRACK | LBRACK | SECTIONSEPPERATOR | SIMPLE_ASSOCIATION | DIRECTIONAL_ASSOCIATION | BIDECTIONAL_ASSOCIATION | INHERRITANCE_ASSOCIATION | ID | MM | WS );"; }
        }

    }

 
    
}
}