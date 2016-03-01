using UnityEngine;
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace MyTest
{
	[TestFixture]
	//[Category("Greeting")]
	internal class TestGreeting
	{
		[Test]
		//[Category("Failing Tests")]
		public void TestSay()
		{
			GameObject obj = new GameObject("test");
			Greeting greet = obj.AddComponent<Greeting>();
			Assert.AreEqual("Hello!", greet.Say());
		}
		
		
		//	
		public void TestFunc()
		{
			Console.WriteLine("テストじゃない関数の呼び出し");
		}
		
		[Test]
		public void TestAlwaysFail()
		{
			TestFunc();
			Assert.Fail();
		}

	}
}

