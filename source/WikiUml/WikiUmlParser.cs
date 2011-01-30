// $ANTLR 3.1.1 D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g 2011-01-30 15:59:24
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
		"SIMPLE_ASSOCIATION", 
		"DIRECTIONAL_ASSOCIATION", 
		"BIDECTIONAL_ASSOCIATION", 
		"VALIDSTR", 
		"ALPHACHAR", 
		"';'", 
		"'('", 
		"')'"
    };

    public const int RBRACK = 7;
    public const int LBRACK = 5;
    public const int T__16 = 16;
    public const int WS = 4;
    public const int T__15 = 15;
    public const int BIDECTIONAL_ASSOCIATION = 11;
    public const int T__14 = 14;
    public const int SIMPLE_ASSOCIATION = 9;
    public const int ALPHACHAR = 13;
    public const int SECTIONSEPPERATOR = 8;
    public const int ID = 6;
    public const int EOF = -1;
    public const int VALIDSTR = 12;
    public const int DIRECTIONAL_ASSOCIATION = 10;

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


    Dictionary<string, UmlClass> umlClasses = new Dictionary<string, UmlClass>();
    List<UmlClass> unnamedUmlClasses = new List<UmlClass>();



    // $ANTLR start "diagram"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:20:1: diagram returns [Diagram result] : ( ( associated_classes )+ EOF | );
    public Diagram diagram() // throws RecognitionException [1]
    {   
        Diagram result = default(Diagram);


        	result = new Diagram();

        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:4: ( ( associated_classes )+ EOF | )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( ((LA2_0 >= WS && LA2_0 <= LBRACK)) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == EOF) )
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
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:5: ( associated_classes )+ EOF
                    {
                    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:5: ( associated_classes )+
                    	int cnt1 = 0;
                    	do 
                    	{
                    	    int alt1 = 2;
                    	    int LA1_0 = input.LA(1);

                    	    if ( ((LA1_0 >= WS && LA1_0 <= LBRACK)) )
                    	    {
                    	        alt1 = 1;
                    	    }


                    	    switch (alt1) 
                    		{
                    			case 1 :
                    			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:6: associated_classes
                    			    {
                    			    	PushFollow(FOLLOW_associated_classes_in_diagram62);
                    			    	associated_classes();
                    			    	state.followingStackPointer--;


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

                    	Match(input,EOF,FOLLOW_EOF_in_diagram66); 
                    	 result.umlClasses.AddRange(umlClasses.Values); result.umlClasses.AddRange(unnamedUmlClasses);

                    }
                    break;
                case 2 :
                    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:23:132: 
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


    // $ANTLR start "associated_classes"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:25:1: associated_classes : ( WS )* ua= umlclass (a= association ub= umlclass )* ;
    public void associated_classes() // throws RecognitionException [1]
    {   
        UmlClass ua = default(UmlClass);

        Association a = default(Association);

        UmlClass ub = default(UmlClass);


        var result = new List<UmlClass>();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:26:2: ( ( WS )* ua= umlclass (a= association ub= umlclass )* )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:26:4: ( WS )* ua= umlclass (a= association ub= umlclass )*
            {
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:26:4: ( WS )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == WS) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:26:4: WS
            			    {
            			    	Match(input,WS,FOLLOW_WS_in_associated_classes85); 

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	PushFollow(FOLLOW_umlclass_in_associated_classes90);
            	ua = umlclass();
            	state.followingStackPointer--;

            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:26:20: (a= association ub= umlclass )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= SIMPLE_ASSOCIATION && LA4_0 <= BIDECTIONAL_ASSOCIATION)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:26:21: a= association ub= umlclass
            			    {
            			    	PushFollow(FOLLOW_association_in_associated_classes97);
            			    	a = association();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_umlclass_in_associated_classes101);
            			    	ub = umlclass();
            			    	state.followingStackPointer--;


            			    		if(ua != null) 
            			    		{
            			    			result.Add(ua);
            			    			if(a != null)
            			    			{
            			    				a.UmlClassA = ua;
            			    				ua.AddAssociation(a);
            			    			}
            			    		}
            			    		if(ub != null) 
            			    		{
            			    			result.Add(ub); 
            			    			if(a != null) 
            			    			{
            			    				a.UmlClassB = ub; 
            			    			}
            			    			ua = ub;
            			    		}


            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


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
        return ;
    }
    // $ANTLR end "associated_classes"


    // $ANTLR start "umlclass"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:48:1: umlclass returns [UmlClass result] : LBRACK (f= ID )? (mem= members met= methods )? RBRACK ;
    public UmlClass umlclass() // throws RecognitionException [1]
    {   
        UmlClass result = default(UmlClass);

        IToken f = null;
        List<Member> mem = default(List<Member>);

        List<Method> met = default(List<Method>);



        	result = new UmlClass();

        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:51:3: ( LBRACK (f= ID )? (mem= members met= methods )? RBRACK )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:51:5: LBRACK (f= ID )? (mem= members met= methods )? RBRACK
            {
            	Match(input,LBRACK,FOLLOW_LBRACK_in_umlclass123); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:51:14: (f= ID )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == ID) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:51:14: f= ID
            	        {
            	        	f=(IToken)Match(input,ID,FOLLOW_ID_in_umlclass129); 

            	        }
            	        break;

            	}

            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:51:20: (mem= members met= methods )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == SECTIONSEPPERATOR) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:51:21: mem= members met= methods
            	        {
            	        	PushFollow(FOLLOW_members_in_umlclass137);
            	        	mem = members();
            	        	state.followingStackPointer--;

            	        	PushFollow(FOLLOW_methods_in_umlclass143);
            	        	met = methods();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Match(input,RBRACK,FOLLOW_RBRACK_in_umlclass147); 
            	 
            		if (f != null && !string.IsNullOrEmpty(f.Text))
            	        {
            	        	if (umlClasses.ContainsKey(((f != null) ? f.Text : null)))
            	        		result =  umlClasses[((f != null) ? f.Text : null)];
            	                }
            	                result.Name = ((f != null) ? f.Text : null);
            	                if (mem != null) result.Members.AddRange(mem);
            	                if (met != null) result.Methods.AddRange(met);

            	                if (f != null && !string.IsNullOrEmpty(f.Text))
            	                {
            	                	umlClasses[((f != null) ? f.Text : null)] = result;
            	                }
            	                else
            	                {
            	                        unnamedUmlClasses.Add(result);
            	                }	
            		


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
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:73:1: members returns [List<Member> members] : SECTIONSEPPERATOR (m= member ( ';' )? )* ;
    public List<Member> members() // throws RecognitionException [1]
    {   
        List<Member> members = default(List<Member>);

        Member m = default(Member);


        members = new List<Member>();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:73:77: ( SECTIONSEPPERATOR (m= member ( ';' )? )* )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:73:79: SECTIONSEPPERATOR (m= member ( ';' )? )*
            {
            	Match(input,SECTIONSEPPERATOR,FOLLOW_SECTIONSEPPERATOR_in_members166); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:73:97: (m= member ( ';' )? )*
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
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:73:98: m= member ( ';' )?
            			    {
            			    	PushFollow(FOLLOW_member_in_members173);
            			    	m = member();
            			    	state.followingStackPointer--;

            			    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:73:109: ( ';' )?
            			    	int alt7 = 2;
            			    	int LA7_0 = input.LA(1);

            			    	if ( (LA7_0 == 14) )
            			    	{
            			    	    alt7 = 1;
            			    	}
            			    	switch (alt7) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:73:109: ';'
            			    	        {
            			    	        	Match(input,14,FOLLOW_14_in_members175); 

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
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:74:1: member returns [Member member] : i= ID ;
    public Member member() // throws RecognitionException [1]
    {   
        Member member = default(Member);

        IToken i = null;

        member = new Member();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:74:62: (i= ID )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:74:64: i= ID
            {
            	i=(IToken)Match(input,ID,FOLLOW_ID_in_member198); 
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
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:76:1: methods returns [List<Method> methods] : SECTIONSEPPERATOR (m= method ( ';' )? )* ;
    public List<Method> methods() // throws RecognitionException [1]
    {   
        List<Method> methods = default(List<Method>);

        Method m = default(Method);


        methods = new List<Method>();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:76:77: ( SECTIONSEPPERATOR (m= method ( ';' )? )* )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:76:79: SECTIONSEPPERATOR (m= method ( ';' )? )*
            {
            	Match(input,SECTIONSEPPERATOR,FOLLOW_SECTIONSEPPERATOR_in_methods216); 
            	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:76:97: (m= method ( ';' )? )*
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
            			    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:76:98: m= method ( ';' )?
            			    {
            			    	PushFollow(FOLLOW_method_in_methods223);
            			    	m = method();
            			    	state.followingStackPointer--;

            			    	// D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:76:109: ( ';' )?
            			    	int alt9 = 2;
            			    	int LA9_0 = input.LA(1);

            			    	if ( (LA9_0 == 14) )
            			    	{
            			    	    alt9 = 1;
            			    	}
            			    	switch (alt9) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:76:109: ';'
            			    	        {
            			    	        	Match(input,14,FOLLOW_14_in_methods225); 

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
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:77:1: method returns [Method method] : m= ID '(' ')' ;
    public Method method() // throws RecognitionException [1]
    {   
        Method method = default(Method);

        IToken m = null;

        method = new Method();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:77:63: (m= ID '(' ')' )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:77:65: m= ID '(' ')'
            {
            	m=(IToken)Match(input,ID,FOLLOW_ID_in_method249); 
            	Match(input,15,FOLLOW_15_in_method250); 
            	Match(input,16,FOLLOW_16_in_method251); 
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


    // $ANTLR start "association"
    // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:79:1: association returns [Association association] : a= ( SIMPLE_ASSOCIATION | DIRECTIONAL_ASSOCIATION | BIDECTIONAL_ASSOCIATION ) ;
    public Association association() // throws RecognitionException [1]
    {   
        Association association = default(Association);

        IToken a = null;

        association = new Association();
        try 
    	{
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:79:87: (a= ( SIMPLE_ASSOCIATION | DIRECTIONAL_ASSOCIATION | BIDECTIONAL_ASSOCIATION ) )
            // D:\\Olle\\Projects\\WikiUml\\source\\Grammar\\WikiUml.g:79:89: a= ( SIMPLE_ASSOCIATION | DIRECTIONAL_ASSOCIATION | BIDECTIONAL_ASSOCIATION )
            {
            	a = (IToken)input.LT(1);
            	if ( (input.LA(1) >= SIMPLE_ASSOCIATION && input.LA(1) <= BIDECTIONAL_ASSOCIATION) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            		if(a.Type == SIMPLE_ASSOCIATION) association.Type = AssociationType.Simple; 
            		else if(a.Type == DIRECTIONAL_ASSOCIATION) association.Type = AssociationType.Directional;
            		else if(a.Type == BIDECTIONAL_ASSOCIATION) association.Type = AssociationType.Bidirectional;	


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
        return association;
    }
    // $ANTLR end "association"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_associated_classes_in_diagram62 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_EOF_in_diagram66 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WS_in_associated_classes85 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_umlclass_in_associated_classes90 = new BitSet(new ulong[]{0x0000000000000E02UL});
    public static readonly BitSet FOLLOW_association_in_associated_classes97 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_umlclass_in_associated_classes101 = new BitSet(new ulong[]{0x0000000000000E02UL});
    public static readonly BitSet FOLLOW_LBRACK_in_umlclass123 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_ID_in_umlclass129 = new BitSet(new ulong[]{0x0000000000000180UL});
    public static readonly BitSet FOLLOW_members_in_umlclass137 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_methods_in_umlclass143 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RBRACK_in_umlclass147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SECTIONSEPPERATOR_in_members166 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_member_in_members173 = new BitSet(new ulong[]{0x0000000000004042UL});
    public static readonly BitSet FOLLOW_14_in_members175 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_ID_in_member198 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SECTIONSEPPERATOR_in_methods216 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_method_in_methods223 = new BitSet(new ulong[]{0x0000000000004042UL});
    public static readonly BitSet FOLLOW_14_in_methods225 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_ID_in_method249 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_15_in_method250 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_16_in_method251 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_association272 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}