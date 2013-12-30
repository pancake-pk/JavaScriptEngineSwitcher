﻿namespace JavaScriptEngineSwitcher.Tests.Msie
{
	using NUnit.Framework;

	using Core;

	[TestFixture]
	public class Es5Tests : Es5TestsBase
	{
		[TestFixtureSetUp]
		public override void SetUp()
		{
			_jsEngine = JsEngineSwitcher.Current.CreateJsEngineInstance("MsieJsEngine");
		}
	}
}