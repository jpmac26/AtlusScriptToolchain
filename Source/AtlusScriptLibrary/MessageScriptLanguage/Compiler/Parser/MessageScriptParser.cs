//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ..\..\..\AtlusScriptLib\MessageScriptLanguage\Compiler\Parser\MessageScriptParser.g4 by ANTLR 4.6.4

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AtlusScriptLibrary.FlowScriptLanguage.Compiler.Parser {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public partial class MessageScriptParser : Parser {
	public const int
		OpenCode=1, CloseText=2, Text=3, MessageDialogTagId=4, SelectionDialogTagId=5, 
		CloseCode=6, OpenText=7, IntLiteral=8, Identifier=9, Whitespace=10;
	public const int
		RULE_compilationUnit = 0, RULE_dialog = 1, RULE_messageDialog = 2, RULE_speakerName = 3, 
		RULE_selectionDialog = 4, RULE_tokenText = 5, RULE_token = 6;
	public static readonly string[] ruleNames = {
		"compilationUnit", "dialog", "messageDialog", "speakerName", "selectionDialog", 
		"tokenText", "token"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, "'sel'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "OpenCode", "CloseText", "Text", "MessageDialogTagId", "SelectionDialogTagId", 
		"CloseCode", "OpenText", "IntLiteral", "Identifier", "Whitespace"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "MessageScriptParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public MessageScriptParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class CompilationUnitContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(MessageScriptParser.Eof, 0); }
		public DialogContext[] dialog() {
			return GetRuleContexts<DialogContext>();
		}
		public DialogContext dialog(int i) {
			return GetRuleContext<DialogContext>(i);
		}
		public CompilationUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compilationUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.EnterCompilationUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.ExitCompilationUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMessageScriptParserVisitor<TResult> typedVisitor = visitor as IMessageScriptParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompilationUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompilationUnitContext compilationUnit() {
		CompilationUnitContext _localctx = new CompilationUnitContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_compilationUnit);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 17;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==OpenCode) {
				{
				{
				State = 14; dialog();
				}
				}
				State = 19;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 20; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DialogContext : ParserRuleContext {
		public MessageDialogContext messageDialog() {
			return GetRuleContext<MessageDialogContext>(0);
		}
		public SelectionDialogContext selectionDialog() {
			return GetRuleContext<SelectionDialogContext>(0);
		}
		public DialogContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dialog; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.EnterDialog(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.ExitDialog(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMessageScriptParserVisitor<TResult> typedVisitor = visitor as IMessageScriptParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDialog(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DialogContext dialog() {
		DialogContext _localctx = new DialogContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_dialog);
		try {
			State = 24;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,1,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 22; messageDialog();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 23; selectionDialog();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MessageDialogContext : ParserRuleContext {
		public ITerminalNode OpenCode() { return GetToken(MessageScriptParser.OpenCode, 0); }
		public ITerminalNode MessageDialogTagId() { return GetToken(MessageScriptParser.MessageDialogTagId, 0); }
		public ITerminalNode Identifier() { return GetToken(MessageScriptParser.Identifier, 0); }
		public ITerminalNode CloseCode() { return GetToken(MessageScriptParser.CloseCode, 0); }
		public TokenTextContext tokenText() {
			return GetRuleContext<TokenTextContext>(0);
		}
		public SpeakerNameContext speakerName() {
			return GetRuleContext<SpeakerNameContext>(0);
		}
		public MessageDialogContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_messageDialog; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.EnterMessageDialog(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.ExitMessageDialog(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMessageScriptParserVisitor<TResult> typedVisitor = visitor as IMessageScriptParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMessageDialog(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MessageDialogContext messageDialog() {
		MessageDialogContext _localctx = new MessageDialogContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_messageDialog);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 26; Match(OpenCode);
			State = 27; Match(MessageDialogTagId);
			State = 28; Match(Identifier);
			State = 30;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==OpenText) {
				{
				State = 29; speakerName();
				}
			}

			State = 32; Match(CloseCode);
			State = 33; tokenText();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SpeakerNameContext : ParserRuleContext {
		public ITerminalNode OpenText() { return GetToken(MessageScriptParser.OpenText, 0); }
		public TokenTextContext tokenText() {
			return GetRuleContext<TokenTextContext>(0);
		}
		public ITerminalNode CloseText() { return GetToken(MessageScriptParser.CloseText, 0); }
		public SpeakerNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_speakerName; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.EnterSpeakerName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.ExitSpeakerName(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMessageScriptParserVisitor<TResult> typedVisitor = visitor as IMessageScriptParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSpeakerName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SpeakerNameContext speakerName() {
		SpeakerNameContext _localctx = new SpeakerNameContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_speakerName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35; Match(OpenText);
			State = 36; tokenText();
			State = 37; Match(CloseText);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SelectionDialogContext : ParserRuleContext {
		public ITerminalNode OpenCode() { return GetToken(MessageScriptParser.OpenCode, 0); }
		public ITerminalNode SelectionDialogTagId() { return GetToken(MessageScriptParser.SelectionDialogTagId, 0); }
		public ITerminalNode Identifier() { return GetToken(MessageScriptParser.Identifier, 0); }
		public ITerminalNode CloseCode() { return GetToken(MessageScriptParser.CloseCode, 0); }
		public TokenTextContext tokenText() {
			return GetRuleContext<TokenTextContext>(0);
		}
		public SelectionDialogContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_selectionDialog; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.EnterSelectionDialog(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.ExitSelectionDialog(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMessageScriptParserVisitor<TResult> typedVisitor = visitor as IMessageScriptParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSelectionDialog(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SelectionDialogContext selectionDialog() {
		SelectionDialogContext _localctx = new SelectionDialogContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_selectionDialog);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 39; Match(OpenCode);
			State = 40; Match(SelectionDialogTagId);
			State = 41; Match(Identifier);
			State = 42; Match(CloseCode);
			State = 43; tokenText();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TokenTextContext : ParserRuleContext {
		public TokenContext[] token() {
			return GetRuleContexts<TokenContext>();
		}
		public TokenContext token(int i) {
			return GetRuleContext<TokenContext>(i);
		}
		public ITerminalNode[] Text() { return GetTokens(MessageScriptParser.Text); }
		public ITerminalNode Text(int i) {
			return GetToken(MessageScriptParser.Text, i);
		}
		public TokenTextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tokenText; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.EnterTokenText(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.ExitTokenText(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMessageScriptParserVisitor<TResult> typedVisitor = visitor as IMessageScriptParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTokenText(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TokenTextContext tokenText() {
		TokenTextContext _localctx = new TokenTextContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_tokenText);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 49;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,4,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					{
					State = 47;
					_errHandler.Sync(this);
					switch (_input.La(1)) {
					case OpenCode:
						{
						State = 45; token();
						}
						break;
					case Text:
						{
						State = 46; Match(Text);
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					} 
				}
				State = 51;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,4,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TokenContext : ParserRuleContext {
		public ITerminalNode OpenCode() { return GetToken(MessageScriptParser.OpenCode, 0); }
		public ITerminalNode Identifier() { return GetToken(MessageScriptParser.Identifier, 0); }
		public ITerminalNode CloseCode() { return GetToken(MessageScriptParser.CloseCode, 0); }
		public ITerminalNode[] IntLiteral() { return GetTokens(MessageScriptParser.IntLiteral); }
		public ITerminalNode IntLiteral(int i) {
			return GetToken(MessageScriptParser.IntLiteral, i);
		}
		public TokenContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_token; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.EnterToken(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMessageScriptParserListener typedListener = listener as IMessageScriptParserListener;
			if (typedListener != null) typedListener.ExitToken(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMessageScriptParserVisitor<TResult> typedVisitor = visitor as IMessageScriptParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitToken(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TokenContext token() {
		TokenContext _localctx = new TokenContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_token);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 52; Match(OpenCode);
			State = 53; Match(Identifier);
			State = 57;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==IntLiteral) {
				{
				{
				State = 54; Match(IntLiteral);
				}
				}
				State = 59;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 60; Match(CloseCode);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\f\x41\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x3\x2\a"+
		"\x2\x12\n\x2\f\x2\xE\x2\x15\v\x2\x3\x2\x3\x2\x3\x3\x3\x3\x5\x3\x1B\n\x3"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4!\n\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\a\a\x32\n\a\f"+
		"\a\xE\a\x35\v\a\x3\b\x3\b\x3\b\a\b:\n\b\f\b\xE\b=\v\b\x3\b\x3\b\x3\b\x2"+
		"\x2\x2\t\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x2\x2?\x2\x13\x3\x2\x2"+
		"\x2\x4\x1A\x3\x2\x2\x2\x6\x1C\x3\x2\x2\x2\b%\x3\x2\x2\x2\n)\x3\x2\x2\x2"+
		"\f\x33\x3\x2\x2\x2\xE\x36\x3\x2\x2\x2\x10\x12\x5\x4\x3\x2\x11\x10\x3\x2"+
		"\x2\x2\x12\x15\x3\x2\x2\x2\x13\x11\x3\x2\x2\x2\x13\x14\x3\x2\x2\x2\x14"+
		"\x16\x3\x2\x2\x2\x15\x13\x3\x2\x2\x2\x16\x17\a\x2\x2\x3\x17\x3\x3\x2\x2"+
		"\x2\x18\x1B\x5\x6\x4\x2\x19\x1B\x5\n\x6\x2\x1A\x18\x3\x2\x2\x2\x1A\x19"+
		"\x3\x2\x2\x2\x1B\x5\x3\x2\x2\x2\x1C\x1D\a\x3\x2\x2\x1D\x1E\a\x6\x2\x2"+
		"\x1E \a\v\x2\x2\x1F!\x5\b\x5\x2 \x1F\x3\x2\x2\x2 !\x3\x2\x2\x2!\"\x3\x2"+
		"\x2\x2\"#\a\b\x2\x2#$\x5\f\a\x2$\a\x3\x2\x2\x2%&\a\t\x2\x2&\'\x5\f\a\x2"+
		"\'(\a\x4\x2\x2(\t\x3\x2\x2\x2)*\a\x3\x2\x2*+\a\a\x2\x2+,\a\v\x2\x2,-\a"+
		"\b\x2\x2-.\x5\f\a\x2.\v\x3\x2\x2\x2/\x32\x5\xE\b\x2\x30\x32\a\x5\x2\x2"+
		"\x31/\x3\x2\x2\x2\x31\x30\x3\x2\x2\x2\x32\x35\x3\x2\x2\x2\x33\x31\x3\x2"+
		"\x2\x2\x33\x34\x3\x2\x2\x2\x34\r\x3\x2\x2\x2\x35\x33\x3\x2\x2\x2\x36\x37"+
		"\a\x3\x2\x2\x37;\a\v\x2\x2\x38:\a\n\x2\x2\x39\x38\x3\x2\x2\x2:=\x3\x2"+
		"\x2\x2;\x39\x3\x2\x2\x2;<\x3\x2\x2\x2<>\x3\x2\x2\x2=;\x3\x2\x2\x2>?\a"+
		"\b\x2\x2?\xF\x3\x2\x2\x2\b\x13\x1A \x31\x33;";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace AtlusScriptLib.FlowScriptLanguage.Compiler.Parser
