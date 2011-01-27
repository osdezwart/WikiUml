// $ANTLR 3.1.1 D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g 2011-01-27 18:57:03
// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  WikiUml 
{

using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class WikiUmlParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"WS", 
		"LBRACK", 
		"ID", 
		"RBRACK", 
		"SECTIONSEPPERATOR", 
		"VALIDSTR", 
		"ALPHACHAR", 
		"';'", 
		"'('", 
		"')'"
    };

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



        public WikiUmlParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public WikiUmlParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return WikiUmlParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g"; }
    }



    // $ANTLR start "diagram"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:14:1: diagram returns [Diagram result] : ( ( WS )* (u= umlclass ( WS )? )+ | );
    public Diagram diagram() // throws RecognitionException [1]
    {   
        Diagram result = default(Diagram);

        UmlClass u = default(UmlClass);



        	result = new Diagram();

        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:3: ( ( WS )* (u= umlclass ( WS )? )+ | )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( ((LA4_0 >= WS && LA4_0 <= LBRACK)) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == EOF) )
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
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:5: ( WS )* (u= umlclass ( WS )? )+
                    {
                    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:5: ( WS )*
                    	do 
                    	{
                    	    int alt1 = 2;
                    	    int LA1_0 = input.LA(1);

                    	    if ( (LA1_0 == WS) )
                    	    {
                    	        alt1 = 1;
                    	    }


                    	    switch (alt1) 
                    		{
                    			case 1 :
                    			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:5: WS
                    			    {
                    			    	Match(input,WS,FOLLOW_WS_in_diagram55); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop1;
                    	    }
                    	} while (true);

                    	loop1:
                    		;	// Stops C# compiler whining that label 'loop1' has no statements

                    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:9: (u= umlclass ( WS )? )+
                    	int cnt3 = 0;
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( (LA3_0 == LBRACK) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:10: u= umlclass ( WS )?
                    			    {
                    			    	PushFollow(FOLLOW_umlclass_in_diagram63);
                    			    	u = umlclass();
                    			    	state.followingStackPointer--;

                    			    	 result.umlClasses.Add(u);
                    			    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:53: ( WS )?
                    			    	int alt2 = 2;
                    			    	int LA2_0 = input.LA(1);

                    			    	if ( (LA2_0 == WS) )
                    			    	{
                    			    	    alt2 = 1;
                    			    	}
                    			    	switch (alt2) 
                    			    	{
                    			    	    case 1 :
                    			    	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:53: WS
                    			    	        {
                    			    	        	Match(input,WS,FOLLOW_WS_in_diagram67); 

                    			    	        }
                    			    	        break;

                    			    	}


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


                    }
                    break;
                case 2 :
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:62: 
                    {
                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return result;
    }
    // $ANTLR end "diagram"


    // $ANTLR start "umlclass"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:20:1: umlclass returns [UmlClass result] : LBRACK (f= ID )? (mem= members met= methods )? RBRACK ;
    public UmlClass umlclass() // throws RecognitionException [1]
    {   
        UmlClass result = default(UmlClass);

        IToken f = null;
        List<Member> mem = default(List<Member>);

        List<Method> met = default(List<Method>);



        	result = new UmlClass();

        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:3: ( LBRACK (f= ID )? (mem= members met= methods )? RBRACK )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:5: LBRACK (f= ID )? (mem= members met= methods )? RBRACK
            {
            	Match(input,LBRACK,FOLLOW_LBRACK_in_umlclass93); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:14: (f= ID )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == ID) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:14: f= ID
            	        {
            	        	f=(IToken)Match(input,ID,FOLLOW_ID_in_umlclass99); 

            	        }
            	        break;

            	}

            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:20: (mem= members met= methods )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == SECTIONSEPPERATOR) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:21: mem= members met= methods
            	        {
            	        	PushFollow(FOLLOW_members_in_umlclass107);
            	        	mem = members();
            	        	state.followingStackPointer--;

            	        	PushFollow(FOLLOW_methods_in_umlclass113);
            	        	met = methods();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Match(input,RBRACK,FOLLOW_RBRACK_in_umlclass117); 
            	 result.Name = ((f != null) ? f.Text : null); if(mem != null) result.Members.AddRange(mem); if(met != null) result.Methods.AddRange(met);

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return result;
    }
    // $ANTLR end "umlclass"


    // $ANTLR start "members"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:1: members returns [List<Member> members] : SECTIONSEPPERATOR (m= member ( ';' )? )* ;
    public List<Member> members() // throws RecognitionException [1]
    {   
        List<Member> members = default(List<Member>);

        Member m = default(Member);


        members = new List<Member>();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:77: ( SECTIONSEPPERATOR (m= member ( ';' )? )* )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:79: SECTIONSEPPERATOR (m= member ( ';' )? )*
            {
            	Match(input,SECTIONSEPPERATOR,FOLLOW_SECTIONSEPPERATOR_in_members137); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:97: (m= member ( ';' )? )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == ID) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:98: m= member ( ';' )?
            			    {
            			    	PushFollow(FOLLOW_member_in_members144);
            			    	m = member();
            			    	state.followingStackPointer--;

            			    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:109: ( ';' )?
            			    	int alt7 = 2;
            			    	int LA7_0 = input.LA(1);

            			    	if ( (LA7_0 == 11) )
            			    	{
            			    	    alt7 = 1;
            			    	}
            			    	switch (alt7) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:109: ';'
            			    	        {
            			    	        	Match(input,11,FOLLOW_11_in_members146); 

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	if(m != null) members.Add(m);

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return members;
    }
    // $ANTLR end "members"


    // $ANTLR start "member"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:26:1: member returns [Member member] : i= ID ;
    public Member member() // throws RecognitionException [1]
    {   
        Member member = default(Member);

        IToken i = null;

        member = new Member();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:26:62: (i= ID )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:26:64: i= ID
            {
            	i=(IToken)Match(input,ID,FOLLOW_ID_in_member169); 
            	member.Name = ((i != null) ? i.Text : null);

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return member;
    }
    // $ANTLR end "member"


    // $ANTLR start "methods"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:1: methods returns [List<Method> methods] : SECTIONSEPPERATOR (m= method ( ';' )? )* ;
    public List<Method> methods() // throws RecognitionException [1]
    {   
        List<Method> methods = default(List<Method>);

        Method m = default(Method);


        methods = new List<Method>();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:77: ( SECTIONSEPPERATOR (m= method ( ';' )? )* )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:79: SECTIONSEPPERATOR (m= method ( ';' )? )*
            {
            	Match(input,SECTIONSEPPERATOR,FOLLOW_SECTIONSEPPERATOR_in_methods187); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:97: (m= method ( ';' )? )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == ID) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:98: m= method ( ';' )?
            			    {
            			    	PushFollow(FOLLOW_method_in_methods194);
            			    	m = method();
            			    	state.followingStackPointer--;

            			    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:109: ( ';' )?
            			    	int alt9 = 2;
            			    	int LA9_0 = input.LA(1);

            			    	if ( (LA9_0 == 11) )
            			    	{
            			    	    alt9 = 1;
            			    	}
            			    	switch (alt9) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:109: ';'
            			    	        {
            			    	        	Match(input,11,FOLLOW_11_in_methods196); 

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	if(m != null) methods.Add(m);

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return methods;
    }
    // $ANTLR end "methods"


    // $ANTLR start "method"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:29:1: method returns [Method method] : m= ID '(' ')' ;
    public Method method() // throws RecognitionException [1]
    {   
        Method method = default(Method);

        IToken m = null;

        method = new Method();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:29:63: (m= ID '(' ')' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:29:65: m= ID '(' ')'
            {
            	m=(IToken)Match(input,ID,FOLLOW_ID_in_method220); 
            	Match(input,12,FOLLOW_12_in_method221); 
            	Match(input,13,FOLLOW_13_in_method222); 
            	method.Name= ((m != null) ? m.Text : null);

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return method;
    }
    // $ANTLR end "method"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_WS_in_diagram55 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_umlclass_in_diagram63 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_WS_in_diagram67 = new BitSet(new ulong[]{0x0000000000000022UL});
    public static readonly BitSet FOLLOW_LBRACK_in_umlclass93 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_ID_in_umlclass99 = new BitSet(new ulong[]{0x0000000000000180UL});
    public static readonly BitSet FOLLOW_members_in_umlclass107 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_methods_in_umlclass113 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RBRACK_in_umlclass117 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SECTIONSEPPERATOR_in_members137 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_member_in_members144 = new BitSet(new ulong[]{0x0000000000000842UL});
    public static readonly BitSet FOLLOW_11_in_members146 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_ID_in_member169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SECTIONSEPPERATOR_in_methods187 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_method_in_methods194 = new BitSet(new ulong[]{0x0000000000000842UL});
    public static readonly BitSet FOLLOW_11_in_methods196 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_ID_in_method220 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_12_in_method221 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_13_in_method222 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}