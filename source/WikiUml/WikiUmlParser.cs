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



using Antlr.Runtime.Tree;

public partial class WikiUmlParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ROOT", 
		"UMLCLASS", 
		"WS", 
		"ID", 
		"NEWLINE", 
		"'['", 
		"']'"
    };

    public const int WS = 6;
    public const int NEWLINE = 8;
    public const int T__10 = 10;
    public const int UMLCLASS = 5;
    public const int ID = 7;
    public const int EOF = -1;
    public const int T__9 = 9;
    public const int ROOT = 4;

    // delegates
    // delegators



        public WikiUmlParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public WikiUmlParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return WikiUmlParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g"; }
    }


    public class parse_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parse"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:16:1: parse : umlclass EOF -> ^( ROOT umlclass ) ;
    public WikiUmlParser.parse_return parse() // throws RecognitionException [1]
    {   
        WikiUmlParser.parse_return retval = new WikiUmlParser.parse_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF2 = null;
        WikiUmlParser.umlclass_return umlclass1 = default(WikiUmlParser.umlclass_return);


        object EOF2_tree=null;
        RewriteRuleTokenStream stream_EOF = new RewriteRuleTokenStream(adaptor,"token EOF");
        RewriteRuleSubtreeStream stream_umlclass = new RewriteRuleSubtreeStream(adaptor,"rule umlclass");
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:3: ( umlclass EOF -> ^( ROOT umlclass ) )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:6: umlclass EOF
            {
            	PushFollow(FOLLOW_umlclass_in_parse70);
            	umlclass1 = umlclass();
            	state.followingStackPointer--;

            	stream_umlclass.Add(umlclass1.Tree);
            	EOF2=(IToken)Match(input,EOF,FOLLOW_EOF_in_parse72);  
            	stream_EOF.Add(EOF2);



            	// AST REWRITE
            	// elements:          umlclass
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "token retval", (retval!=null ? retval.Tree : null));

            	root_0 = (object)adaptor.GetNilNode();
            	// 17:19: -> ^( ROOT umlclass )
            	{
            	    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:22: ^( ROOT umlclass )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ROOT, "ROOT"), root_1);

            	    adaptor.AddChild(root_1, stream_umlclass.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parse"

    public class umlclass_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "umlclass"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:20:1: umlclass : ( WS )? '[' ID ']' ( WS )? ;
    public WikiUmlParser.umlclass_return umlclass() // throws RecognitionException [1]
    {   
        WikiUmlParser.umlclass_return retval = new WikiUmlParser.umlclass_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WS3 = null;
        IToken char_literal4 = null;
        IToken ID5 = null;
        IToken char_literal6 = null;
        IToken WS7 = null;

        object WS3_tree=null;
        object char_literal4_tree=null;
        object ID5_tree=null;
        object char_literal6_tree=null;
        object WS7_tree=null;

        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:21:5: ( ( WS )? '[' ID ']' ( WS )? )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:21:10: ( WS )? '[' ID ']' ( WS )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:21:10: ( WS )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == WS) )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:21:10: WS
            	        {
            	        	WS3=(IToken)Match(input,WS,FOLLOW_WS_in_umlclass98); 
            	        		WS3_tree = (object)adaptor.Create(WS3);
            	        		adaptor.AddChild(root_0, WS3_tree);


            	        }
            	        break;

            	}

            	char_literal4=(IToken)Match(input,9,FOLLOW_9_in_umlclass101); 
            		char_literal4_tree = (object)adaptor.Create(char_literal4);
            		adaptor.AddChild(root_0, char_literal4_tree);

            	ID5=(IToken)Match(input,ID,FOLLOW_ID_in_umlclass102); 
            		ID5_tree = (object)adaptor.Create(ID5);
            		adaptor.AddChild(root_0, ID5_tree);

            	char_literal6=(IToken)Match(input,10,FOLLOW_10_in_umlclass103); 
            		char_literal6_tree = (object)adaptor.Create(char_literal6);
            		adaptor.AddChild(root_0, char_literal6_tree);

            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:21:23: ( WS )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == WS) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:21:23: WS
            	        {
            	        	WS7=(IToken)Match(input,WS,FOLLOW_WS_in_umlclass105); 
            	        		WS7_tree = (object)adaptor.Create(WS7);
            	        		adaptor.AddChild(root_0, WS7_tree);


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "umlclass"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_umlclass_in_parse70 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_parse72 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_umlclass98 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_9_in_umlclass101 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ID_in_umlclass102 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_umlclass103 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_WS_in_umlclass105 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}