﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Sov\Source\Repos\antlr-calculator\KNU.TOKT.Calculator\LabCalculator.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace KNU.TOKT.Calculator {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class LabCalculatorParser : Parser {
	public const int
		PLUS=1, MINUS=2, MULTIPLY=3, DIVIDE=4, POWER=5, LPAREN=6, RPAREN=7, COMMA=8, 
		SIN=9, COS=10, TAN=11, INTEGER=12, FLOAT=13, LOG=14;
	public const int
		RULE_root = 0, RULE_expression = 1;
	public static readonly string[] ruleNames = {
		"root", "expression"
	};

	private static readonly string[] _LiteralNames = {
		null, "'+'", "'-'", "'*'", "'/'", "'^'", "'('", "')'", "','", "'sin'", 
		"'cos'", "'tg'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PLUS", "MINUS", "MULTIPLY", "DIVIDE", "POWER", "LPAREN", "RPAREN", 
		"COMMA", "SIN", "COS", "TAN", "INTEGER", "FLOAT", "LOG"
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

	public override string GrammarFileName { get { return "LabCalculator.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public LabCalculatorParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class RootContext : ParserRuleContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(LabCalculatorParser.Eof, 0); }
		public RootContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_root; } }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterRoot(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitRoot(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRoot(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RootContext root() {
		RootContext _localctx = new RootContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_root);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 4; expression(0);
			State = 5; Match(Eof);
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

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class NumberExpressionContext : ExpressionContext {
		public ITerminalNode INTEGER() { return GetToken(LabCalculatorParser.INTEGER, 0); }
		public ITerminalNode FLOAT() { return GetToken(LabCalculatorParser.FLOAT, 0); }
		public NumberExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterNumberExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitNumberExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumberExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NegativeNumberExpressionContext : ExpressionContext {
		public ExpressionContext num;
		public ITerminalNode MINUS() { return GetToken(LabCalculatorParser.MINUS, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public NegativeNumberExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterNegativeNumberExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitNegativeNumberExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNegativeNumberExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class PowerExpressionContext : ExpressionContext {
		public ExpressionContext num;
		public ExpressionContext pow;
		public ITerminalNode POWER() { return GetToken(LabCalculatorParser.POWER, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public PowerExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterPowerExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitPowerExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPowerExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParenthesisExpressionContext : ExpressionContext {
		public ITerminalNode LPAREN() { return GetToken(LabCalculatorParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(LabCalculatorParser.RPAREN, 0); }
		public ParenthesisExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterParenthesisExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitParenthesisExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenthesisExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class SinusExpressionContext : ExpressionContext {
		public ExpressionContext num;
		public ITerminalNode SIN() { return GetToken(LabCalculatorParser.SIN, 0); }
		public ITerminalNode LPAREN() { return GetToken(LabCalculatorParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(LabCalculatorParser.RPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public SinusExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterSinusExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitSinusExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSinusExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CosinusExpressionContext : ExpressionContext {
		public ExpressionContext num;
		public ITerminalNode COS() { return GetToken(LabCalculatorParser.COS, 0); }
		public ITerminalNode LPAREN() { return GetToken(LabCalculatorParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(LabCalculatorParser.RPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public CosinusExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterCosinusExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitCosinusExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCosinusExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TangentExpressionContext : ExpressionContext {
		public ExpressionContext num;
		public ITerminalNode TAN() { return GetToken(LabCalculatorParser.TAN, 0); }
		public ITerminalNode LPAREN() { return GetToken(LabCalculatorParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(LabCalculatorParser.RPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public TangentExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterTangentExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitTangentExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTangentExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LogarithmExpressionContext : ExpressionContext {
		public ExpressionContext num;
		public ExpressionContext @base;
		public ITerminalNode LOG() { return GetToken(LabCalculatorParser.LOG, 0); }
		public ITerminalNode LPAREN() { return GetToken(LabCalculatorParser.LPAREN, 0); }
		public ITerminalNode COMMA() { return GetToken(LabCalculatorParser.COMMA, 0); }
		public ITerminalNode RPAREN() { return GetToken(LabCalculatorParser.RPAREN, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public LogarithmExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterLogarithmExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitLogarithmExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLogarithmExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MultOrDivideExpressionContext : ExpressionContext {
		public ExpressionContext left;
		public IToken op;
		public ExpressionContext right;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode MULTIPLY() { return GetToken(LabCalculatorParser.MULTIPLY, 0); }
		public ITerminalNode DIVIDE() { return GetToken(LabCalculatorParser.DIVIDE, 0); }
		public MultOrDivideExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterMultOrDivideExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitMultOrDivideExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultOrDivideExpression(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class PlusOrMinusExpressionContext : ExpressionContext {
		public ExpressionContext left;
		public IToken op;
		public ExpressionContext right;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode PLUS() { return GetToken(LabCalculatorParser.PLUS, 0); }
		public ITerminalNode MINUS() { return GetToken(LabCalculatorParser.MINUS, 0); }
		public PlusOrMinusExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterPlusOrMinusExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitPlusOrMinusExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPlusOrMinusExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 37;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case INTEGER:
			case FLOAT:
				{
				_localctx = new NumberExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 8;
				_la = _input.La(1);
				if ( !(_la==INTEGER || _la==FLOAT) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				}
				break;
			case MINUS:
				{
				_localctx = new NegativeNumberExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 9; Match(MINUS);
				State = 10; ((NegativeNumberExpressionContext)_localctx).num = expression(9);
				}
				break;
			case LPAREN:
				{
				_localctx = new ParenthesisExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 11; Match(LPAREN);
				State = 12; expression(0);
				State = 13; Match(RPAREN);
				}
				break;
			case SIN:
				{
				_localctx = new SinusExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 15; Match(SIN);
				State = 16; Match(LPAREN);
				State = 17; ((SinusExpressionContext)_localctx).num = expression(0);
				State = 18; Match(RPAREN);
				}
				break;
			case COS:
				{
				_localctx = new CosinusExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 20; Match(COS);
				State = 21; Match(LPAREN);
				State = 22; ((CosinusExpressionContext)_localctx).num = expression(0);
				State = 23; Match(RPAREN);
				}
				break;
			case TAN:
				{
				_localctx = new TangentExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 25; Match(TAN);
				State = 26; Match(LPAREN);
				State = 27; ((TangentExpressionContext)_localctx).num = expression(0);
				State = 28; Match(RPAREN);
				}
				break;
			case LOG:
				{
				_localctx = new LogarithmExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 30; Match(LOG);
				State = 31; Match(LPAREN);
				State = 32; ((LogarithmExpressionContext)_localctx).num = expression(0);
				State = 33; Match(COMMA);
				State = 34; ((LogarithmExpressionContext)_localctx).@base = expression(0);
				State = 35; Match(RPAREN);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			_ctx.stop = _input.Lt(-1);
			State = 50;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 48;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,1,_ctx) ) {
					case 1:
						{
						_localctx = new PowerExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((PowerExpressionContext)_localctx).num = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 39;
						if (!(Precpred(_ctx, 8))) throw new FailedPredicateException(this, "Precpred(_ctx, 8)");
						State = 40; Match(POWER);
						State = 41; ((PowerExpressionContext)_localctx).pow = expression(9);
						}
						break;

					case 2:
						{
						_localctx = new MultOrDivideExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((MultOrDivideExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 42;
						if (!(Precpred(_ctx, 2))) throw new FailedPredicateException(this, "Precpred(_ctx, 2)");
						State = 43;
						((MultOrDivideExpressionContext)_localctx).op = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==MULTIPLY || _la==DIVIDE) ) {
							((MultOrDivideExpressionContext)_localctx).op = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 44; ((MultOrDivideExpressionContext)_localctx).right = expression(3);
						}
						break;

					case 3:
						{
						_localctx = new PlusOrMinusExpressionContext(new ExpressionContext(_parentctx, _parentState));
						((PlusOrMinusExpressionContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 45;
						if (!(Precpred(_ctx, 1))) throw new FailedPredicateException(this, "Precpred(_ctx, 1)");
						State = 46;
						((PlusOrMinusExpressionContext)_localctx).op = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==PLUS || _la==MINUS) ) {
							((PlusOrMinusExpressionContext)_localctx).op = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 47; ((PlusOrMinusExpressionContext)_localctx).right = expression(2);
						}
						break;
					}
					} 
				}
				State = 52;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 8);

		case 1: return Precpred(_ctx, 2);

		case 2: return Precpred(_ctx, 1);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x10\x38\x4\x2\t"+
		"\x2\x4\x3\t\x3\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x5\x3(\n\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\a\x3\x33\n\x3\f\x3\xE\x3\x36\v\x3\x3\x3\x2\x2\x3\x4\x4\x2\x2\x4\x2\x2"+
		"\x5\x3\x2\xE\xF\x3\x2\x5\x6\x3\x2\x3\x4>\x2\x6\x3\x2\x2\x2\x4\'\x3\x2"+
		"\x2\x2\x6\a\x5\x4\x3\x2\a\b\a\x2\x2\x3\b\x3\x3\x2\x2\x2\t\n\b\x3\x1\x2"+
		"\n(\t\x2\x2\x2\v\f\a\x4\x2\x2\f(\x5\x4\x3\v\r\xE\a\b\x2\x2\xE\xF\x5\x4"+
		"\x3\x2\xF\x10\a\t\x2\x2\x10(\x3\x2\x2\x2\x11\x12\a\v\x2\x2\x12\x13\a\b"+
		"\x2\x2\x13\x14\x5\x4\x3\x2\x14\x15\a\t\x2\x2\x15(\x3\x2\x2\x2\x16\x17"+
		"\a\f\x2\x2\x17\x18\a\b\x2\x2\x18\x19\x5\x4\x3\x2\x19\x1A\a\t\x2\x2\x1A"+
		"(\x3\x2\x2\x2\x1B\x1C\a\r\x2\x2\x1C\x1D\a\b\x2\x2\x1D\x1E\x5\x4\x3\x2"+
		"\x1E\x1F\a\t\x2\x2\x1F(\x3\x2\x2\x2 !\a\x10\x2\x2!\"\a\b\x2\x2\"#\x5\x4"+
		"\x3\x2#$\a\n\x2\x2$%\x5\x4\x3\x2%&\a\t\x2\x2&(\x3\x2\x2\x2\'\t\x3\x2\x2"+
		"\x2\'\v\x3\x2\x2\x2\'\r\x3\x2\x2\x2\'\x11\x3\x2\x2\x2\'\x16\x3\x2\x2\x2"+
		"\'\x1B\x3\x2\x2\x2\' \x3\x2\x2\x2(\x34\x3\x2\x2\x2)*\f\n\x2\x2*+\a\a\x2"+
		"\x2+\x33\x5\x4\x3\v,-\f\x4\x2\x2-.\t\x3\x2\x2.\x33\x5\x4\x3\x5/\x30\f"+
		"\x3\x2\x2\x30\x31\t\x4\x2\x2\x31\x33\x5\x4\x3\x4\x32)\x3\x2\x2\x2\x32"+
		",\x3\x2\x2\x2\x32/\x3\x2\x2\x2\x33\x36\x3\x2\x2\x2\x34\x32\x3\x2\x2\x2"+
		"\x34\x35\x3\x2\x2\x2\x35\x5\x3\x2\x2\x2\x36\x34\x3\x2\x2\x2\x5\'\x32\x34";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace KNU.TOKT.Calculator
