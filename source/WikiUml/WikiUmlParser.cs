// $ANTLR 3.1.1 D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g 2011-01-26 22:12:09
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
		"NEWLINE", 
		"LBRACK", 
		"ID", 
		"RBRACK", 
		"SECTIONSEPPERATOR", 
		"VALIDSTR", 
		"NUMBER", 
		"ALPHACHAR", 
		"';'", 
		"'('", 
		"')'"
    };

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
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:14:1: diagram returns [Diagram result] : ( (u= umlclass NEWLINE ) | );
    public Diagram diagram() // throws RecognitionException [1]
    {   
        Diagram result = default(Diagram);

        UmlClass u = default(UmlClass);



        	result = new Diagram();

        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:3: ( (u= umlclass NEWLINE ) | )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == LBRACK) )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == EOF) )
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
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:5: (u= umlclass NEWLINE )
                    {
                    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:5: (u= umlclass NEWLINE )
                    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:6: u= umlclass NEWLINE
                    	{
                    		PushFollow(FOLLOW_umlclass_in_diagram60);
                    		u = umlclass();
                    		state.followingStackPointer--;

                    		Match(input,NEWLINE,FOLLOW_NEWLINE_in_diagram62); 

                    	}

                    	 result.umlClasses.Add(u);

                    }
                    break;
                case 2 :
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:17:60: 
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
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:19:1: umlclass returns [UmlClass result] : LBRACK f= ID mem= members met= methods RBRACK ;
    public UmlClass umlclass() // throws RecognitionException [1]
    {   
        UmlClass result = default(UmlClass);

        IToken f = null;
        List<Member> mem = default(List<Member>);

        List<Method> met = default(List<Method>);



        	result = new UmlClass();

        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:22:3: ( LBRACK f= ID mem= members met= methods RBRACK )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:22:5: LBRACK f= ID mem= members met= methods RBRACK
            {
            	Match(input,LBRACK,FOLLOW_LBRACK_in_umlclass86); 
            	f=(IToken)Match(input,ID,FOLLOW_ID_in_umlclass92); 
            	PushFollow(FOLLOW_members_in_umlclass98);
            	mem = members();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_methods_in_umlclass104);
            	met = methods();
            	state.followingStackPointer--;

            	Match(input,RBRACK,FOLLOW_RBRACK_in_umlclass106); 
            	 result.Name = ((f != null) ? f.Text : null); result.Members.AddRange(mem); result.Methods.AddRange(met);

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
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:24:1: members returns [List<Member> members] : SECTIONSEPPERATOR (m= member ( ';' )? )* ;
    public List<Member> members() // throws RecognitionException [1]
    {   
        List<Member> members = default(List<Member>);

        Member m = default(Member);


        members = new List<Member>();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:24:77: ( SECTIONSEPPERATOR (m= member ( ';' )? )* )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:24:79: SECTIONSEPPERATOR (m= member ( ';' )? )*
            {
            	Match(input,SECTIONSEPPERATOR,FOLLOW_SECTIONSEPPERATOR_in_members126); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:24:97: (m= member ( ';' )? )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == ID) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:24:98: m= member ( ';' )?
            			    {
            			    	PushFollow(FOLLOW_member_in_members133);
            			    	m = member();
            			    	state.followingStackPointer--;

            			    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:24:109: ( ';' )?
            			    	int alt2 = 2;
            			    	int LA2_0 = input.LA(1);

            			    	if ( (LA2_0 == 12) )
            			    	{
            			    	    alt2 = 1;
            			    	}
            			    	switch (alt2) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:24:109: ';'
            			    	        {
            			    	        	Match(input,12,FOLLOW_12_in_members135); 

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	members.Add(m);

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
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:1: member returns [Member member] : i= ID ;
    public Member member() // throws RecognitionException [1]
    {   
        Member member = default(Member);

        IToken i = null;

        member = new Member();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:62: (i= ID )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:64: i= ID
            {
            	i=(IToken)Match(input,ID,FOLLOW_ID_in_member158); 
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
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:27:1: methods returns [List<Method> methods] : SECTIONSEPPERATOR (m= method ( ';' )? )* ;
    public List<Method> methods() // throws RecognitionException [1]
    {   
        List<Method> methods = default(List<Method>);

        Method m = default(Method);


        methods = new List<Method>();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:27:77: ( SECTIONSEPPERATOR (m= method ( ';' )? )* )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:27:79: SECTIONSEPPERATOR (m= method ( ';' )? )*
            {
            	Match(input,SECTIONSEPPERATOR,FOLLOW_SECTIONSEPPERATOR_in_methods176); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:27:97: (m= method ( ';' )? )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == ID) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:27:98: m= method ( ';' )?
            			    {
            			    	PushFollow(FOLLOW_method_in_methods183);
            			    	m = method();
            			    	state.followingStackPointer--;

            			    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:27:109: ( ';' )?
            			    	int alt4 = 2;
            			    	int LA4_0 = input.LA(1);

            			    	if ( (LA4_0 == 12) )
            			    	{
            			    	    alt4 = 1;
            			    	}
            			    	switch (alt4) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:27:109: ';'
            			    	        {
            			    	        	Match(input,12,FOLLOW_12_in_methods185); 

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	methods.Add(m);

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
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:1: method returns [Method method] : m= ID '(' ')' ;
    public Method method() // throws RecognitionException [1]
    {   
        Method method = default(Method);

        IToken m = null;

        method = new Method();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:63: (m= ID '(' ')' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:28:65: m= ID '(' ')'
            {
            	m=(IToken)Match(input,ID,FOLLOW_ID_in_method209); 
            	Match(input,13,FOLLOW_13_in_method210); 
            	Match(input,14,FOLLOW_14_in_method211); 
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

 

    public static readonly BitSet FOLLOW_umlclass_in_diagram60 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_diagram62 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACK_in_umlclass86 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_ID_in_umlclass92 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_members_in_umlclass98 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_methods_in_umlclass104 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RBRACK_in_umlclass106 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SECTIONSEPPERATOR_in_members126 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_member_in_members133 = new BitSet(new ulong[]{0x0000000000001042UL});
    public static readonly BitSet FOLLOW_12_in_members135 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_ID_in_member158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SECTIONSEPPERATOR_in_methods176 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_method_in_methods183 = new BitSet(new ulong[]{0x0000000000001042UL});
    public static readonly BitSet FOLLOW_12_in_methods185 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_ID_in_method209 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_13_in_method210 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_14_in_method211 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}