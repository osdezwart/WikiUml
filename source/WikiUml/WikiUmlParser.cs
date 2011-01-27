// $ANTLR 3.1.1 D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g 2011-01-27 18:47:29
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
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:14:1: diagram returns [Diagram result] : ( (u= umlclass ( WS )? ( umlclass )? ) | );
    public Diagram diagram() // throws RecognitionException [1]
    {   
        Diagram result = default(Diagram);

        UmlClass u = default(UmlClass);



        	result = new Diagram();

        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:3: ( (u= umlclass ( WS )? ( umlclass )? ) | )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == LBRACK) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == EOF) )
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
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:5: (u= umlclass ( WS )? ( umlclass )? )
                    {
                    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:5: (u= umlclass ( WS )? ( umlclass )? )
                    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:6: u= umlclass ( WS )? ( umlclass )?
                    	{
                    		PushFollow(FOLLOW_umlclass_in_diagram60);
                    		u = umlclass();
                    		state.followingStackPointer--;

                    		// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:19: ( WS )?
                    		int alt1 = 2;
                    		int LA1_0 = input.LA(1);

                    		if ( (LA1_0 == WS) )
                    		{
                    		    alt1 = 1;
                    		}
                    		switch (alt1) 
                    		{
                    		    case 1 :
                    		        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:19: WS
                    		        {
                    		        	Match(input,WS,FOLLOW_WS_in_diagram62); 

                    		        }
                    		        break;

                    		}

                    		// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:23: ( umlclass )?
                    		int alt2 = 2;
                    		int LA2_0 = input.LA(1);

                    		if ( (LA2_0 == LBRACK) )
                    		{
                    		    alt2 = 1;
                    		}
                    		switch (alt2) 
                    		{
                    		    case 1 :
                    		        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:23: umlclass
                    		        {
                    		        	PushFollow(FOLLOW_umlclass_in_diagram65);
                    		        	umlclass();
                    		        	state.followingStackPointer--;


                    		        }
                    		        break;

                    		}


                    	}

                    	 result.umlClasses.Add(u);

                    }
                    break;
                case 2 :
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:66: 
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
            	Match(input,LBRACK,FOLLOW_LBRACK_in_umlclass91); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:14: (f= ID )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == ID) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:14: f= ID
            	        {
            	        	f=(IToken)Match(input,ID,FOLLOW_ID_in_umlclass97); 

            	        }
            	        break;

            	}

            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:20: (mem= members met= methods )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == SECTIONSEPPERATOR) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:21: mem= members met= methods
            	        {
            	        	PushFollow(FOLLOW_members_in_umlclass105);
            	        	mem = members();
            	        	state.followingStackPointer--;

            	        	PushFollow(FOLLOW_methods_in_umlclass111);
            	        	met = methods();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Match(input,RBRACK,FOLLOW_RBRACK_in_umlclass115); 
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
            	Match(input,SECTIONSEPPERATOR,FOLLOW_SECTIONSEPPERATOR_in_members135); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:97: (m= member ( ';' )? )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == ID) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:98: m= member ( ';' )?
            			    {
            			    	PushFollow(FOLLOW_member_in_members142);
            			    	m = member();
            			    	state.followingStackPointer--;

            			    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:109: ( ';' )?
            			    	int alt6 = 2;
            			    	int LA6_0 = input.LA(1);

            			    	if ( (LA6_0 == 11) )
            			    	{
            			    	    alt6 = 1;
            			    	}
            			    	switch (alt6) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:109: ';'
            			    	        {
            			    	        	Match(input,11,FOLLOW_11_in_members144); 

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

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
            	i=(IToken)Match(input,ID,FOLLOW_ID_in_member167); 
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
            	Match(input,SECTIONSEPPERATOR,FOLLOW_SECTIONSEPPERATOR_in_methods185); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:97: (m= method ( ';' )? )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == ID) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:98: m= method ( ';' )?
            			    {
            			    	PushFollow(FOLLOW_method_in_methods192);
            			    	m = method();
            			    	state.followingStackPointer--;

            			    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:109: ( ';' )?
            			    	int alt8 = 2;
            			    	int LA8_0 = input.LA(1);

            			    	if ( (LA8_0 == 11) )
            			    	{
            			    	    alt8 = 1;
            			    	}
            			    	switch (alt8) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:109: ';'
            			    	        {
            			    	        	Match(input,11,FOLLOW_11_in_methods194); 

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

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
            	m=(IToken)Match(input,ID,FOLLOW_ID_in_method218); 
            	Match(input,12,FOLLOW_12_in_method219); 
            	Match(input,13,FOLLOW_13_in_method220); 
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

 

    public static readonly BitSet FOLLOW_umlclass_in_diagram60 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_WS_in_diagram62 = new BitSet(new ulong[]{0x0000000000000022UL});
    public static readonly BitSet FOLLOW_umlclass_in_diagram65 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_umlclass91 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_ID_in_umlclass97 = new BitSet(new ulong[]{0x0000000000000180UL});
    public static readonly BitSet FOLLOW_members_in_umlclass105 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_methods_in_umlclass111 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RBRACK_in_umlclass115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SECTIONSEPPERATOR_in_members135 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_member_in_members142 = new BitSet(new ulong[]{0x0000000000000842UL});
    public static readonly BitSet FOLLOW_11_in_members144 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_ID_in_member167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SECTIONSEPPERATOR_in_methods185 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_method_in_methods192 = new BitSet(new ulong[]{0x0000000000000842UL});
    public static readonly BitSet FOLLOW_11_in_methods194 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_ID_in_method218 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_12_in_method219 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_13_in_method220 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}