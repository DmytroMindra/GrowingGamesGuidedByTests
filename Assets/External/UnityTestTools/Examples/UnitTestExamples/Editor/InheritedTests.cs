using UnityEngine;
using System.Collections;
using NUnit.Framework;

namespace UnityTest
{
	internal abstract class AbstractTestBase{
		[Test]
		public void AbstractClassTest()
		{

		}
	}

	internal class ConcreteTestClass: AbstractTestBase
	{
		[Test]
		public void ConcreteClassTest()
		{
			
		}
	}
}