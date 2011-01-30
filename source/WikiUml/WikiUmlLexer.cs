// $ANTLR 3.1.1 D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g 2011-01-30 16:09:29
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
    public const int INHERRITANCE_ASSOCIATION = 12;
    public const int WS = 4;
    public const int LBRACK = 5;
    public const int T__16 = 16;
    public const int T__15 = 15;
    public const int T__17 = 17;
    public const int BIDECTIONAL_ASSOCIATION = 11;
    public const int SIMPLE_ASSOCIATION = 9;
    public const int ALPHACHAR = 14;
    public const int SECTIONSEPPERATOR = 8;
    public const int ID = 6;
    public const int EOF = -1;
    public const int VALIDSTR = 13;
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

    // $ANTLR start "T__15"
    public void mT__15() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__15;
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
    // $ANTLR end "T__15"

    // $ANTLR start "T__16"
    public void mT__16() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__16;
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
    // $ANTLR end "T__16"

    // $ANTLR start "T__17"
    public void mT__17() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__17;
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
    // $ANTLR end "T__17"

    // $ANTLR start "RBRACK"
    public void mRBRACK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRACK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:87:9: ( ']' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:87:12: ']'
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:88:9: ( '[' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:88:12: '['
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:89:19: ( '|' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:89:21: '|'
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:91:21: ( '-' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:91:24: '-'
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:92:26: ( '<-' | '->' )
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
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:92:29: '<-'
                    {
                    	Match("<-"); 


                    }
                    break;
                case 2 :
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:92:36: '->'
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:93:26: ( '<->' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:93:29: '<->'
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:94:27: ( '^-' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:94:30: '^-'
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:96:4: ( VALIDSTR )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:96:9: VALIDSTR
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:99:2: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:99:5: ( 'a' .. 'z' | 'A' .. 'Z' | '_' )
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
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:106:5: ( ALPHACHAR ( ALPHACHAR | '0' .. '9' )* )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:106:8: ALPHACHAR ( ALPHACHAR | '0' .. '9' )*
            {
            	mALPHACHAR(); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:107:9: ( ALPHACHAR | '0' .. '9' )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9') || (LA2_0 >= 'A' && LA2_0 <= 'Z') || LA2_0 == '_' || (LA2_0 >= 'a' && LA2_0 <= 'z')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
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
    // $ANTLR end "VALIDSTR"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:113:5: ( ( ' ' | '\\t' | '\\r' '\\n' | '\\n' ) )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:114:8: ( ' ' | '\\t' | '\\r' '\\n' | '\\n' )
            {
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:114:8: ( ' ' | '\\t' | '\\r' '\\n' | '\\n' )
            	int alt3 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case ' ':
            		{
            	    alt3 = 1;
            	    }
            	    break;
            	case '\t':
            		{
            	    alt3 = 2;
            	    }
            	    break;
            	case '\r':
            		{
            	    alt3 = 3;
            	    }
            	    break;
            	case '\n':
            		{
            	    alt3 = 4;
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
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:114:12: ' '
            	        {
            	        	Match(' '); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:115:12: '\\t'
            	        {
            	        	Match('\t'); 

            	        }
            	        break;
            	    case 3 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:116:12: '\\r' '\\n'
            	        {
            	        	Match('\r'); 
            	        	Match('\n'); 

            	        }
            	        break;
            	    case 4 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:117:12: '\\n'
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
        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:8: ( T__15 | T__16 | T__17 | RBRACK | LBRACK | SECTIONSEPPERATOR | SIMPLE_ASSOCIATION | DIRECTIONAL_ASSOCIATION | BIDECTIONAL_ASSOCIATION | INHERRITANCE_ASSOCIATION | ID | WS )
        int alt4 = 12;
        alt4 = dfa4.Predict(input);
        switch (alt4) 
        {
            case 1 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:10: T__15
                {
                	mT__15(); 

                }
                break;
            case 2 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:16: T__16
                {
                	mT__16(); 

                }
                break;
            case 3 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:22: T__17
                {
                	mT__17(); 

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
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:60: SIMPLE_ASSOCIATION
                {
                	mSIMPLE_ASSOCIATION(); 

                }
                break;
            case 8 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:79: DIRECTIONAL_ASSOCIATION
                {
                	mDIRECTIONAL_ASSOCIATION(); 

                }
                break;
            case 9 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:103: BIDECTIONAL_ASSOCIATION
                {
                	mBIDECTIONAL_ASSOCIATION(); 

                }
                break;
            case 10 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:127: INHERRITANCE_ASSOCIATION
                {
                	mINHERRITANCE_ASSOCIATION(); 

                }
                break;
            case 11 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:152: ID
                {
                	mID(); 

                }
                break;
            case 12 :
                // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:1:155: WS
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
        "\x07\uffff\x01\x0d\x06\uffff\x01\x0c\x01\uffff";
    const string DFA4_eofS =
        "\x10\uffff";
    const string DFA4_minS =
        "\x01\x09\x06\uffff\x01\x3e\x01\x2d\x05\uffff\x01\x3e\x01\uffff";
    const string DFA4_maxS =
        "\x01\x7c\x06\uffff\x01\x3e\x01\x2d\x05\uffff\x01\x3e\x01\uffff";
    const string DFA4_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x02"+
        "\uffff\x01\x0a\x01\x0b\x01\x0c\x01\x08\x01\x07\x01\uffff\x01\x09";
    const string DFA4_specialS =
        "\x10\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x02\x0b\x02\uffff\x01\x0b\x12\uffff\x01\x0b\x07\uffff\x01"+
            "\x02\x01\x03\x03\uffff\x01\x07\x0d\uffff\x01\x01\x01\x08\x04"+
            "\uffff\x1a\x0a\x01\x05\x01\uffff\x01\x04\x01\x09\x01\x0a\x01"+
            "\uffff\x1a\x0a\x01\uffff\x01\x06",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0c",
            "\x01\x0e",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0f",
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
            get { return "1:1: Tokens : ( T__15 | T__16 | T__17 | RBRACK | LBRACK | SECTIONSEPPERATOR | SIMPLE_ASSOCIATION | DIRECTIONAL_ASSOCIATION | BIDECTIONAL_ASSOCIATION | INHERRITANCE_ASSOCIATION | ID | WS );"; }
        }

    }

 
    
}
}