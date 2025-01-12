﻿using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
		// Subtraction test
		[Test]
		public void TestSubtraction_Scott()
		{
			Assert.AreEqual(1, Program.Subtraction("3", "2"));
		}

		// Multiplication test
		[Test]
		public void TestMultiplication_Scott()
		{
			Assert.AreEqual(6, Program.Multiplication("2", "3"));
		}

		// Division test
		[Test]
		public void TestDivision_Scott()
		{
			Assert.AreEqual(2, Program.Division("6", "3"));
		}

		// Modulo test
		[Test]
		public void TestModulo_Scott()
		{
			Assert.AreEqual(1, Program.Modulo("5", "2"));
		}

		// Subtraction invalid
		[Test]
		public void TestSubtraction_Invalid_Scott()
		{
			Assert.Throws<FormatException>(() => Program.Subtraction("3", "a"));
			Assert.Throws<FormatException>(() => Program.Subtraction("a", "3"));
			Assert.Throws<FormatException>(() => Program.Subtraction("a", "a"));
		}

		// Subtraction null
		[Test]
		public void TestSubtraction_Null_Scott()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Subtraction("3", null));
			Assert.Throws<ArgumentNullException>(() => Program.Subtraction(null, "3"));
			Assert.Throws<ArgumentNullException>(() => Program.Subtraction(null, null));
		}

		// Multiplication invalid
		[Test]
		public void TestMultiplication_Invalid_Scott()
		{
			Assert.Throws<FormatException>(() => Program.Multiplication("2", "a"));
			Assert.Throws<FormatException>(() => Program.Multiplication("a", "2"));
			Assert.Throws<FormatException>(() => Program.Multiplication("a", "a"));
		}

		// Multiplication null
		[Test]
		public void TestMultiplication_Null_Scott()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Multiplication("2", null));
			Assert.Throws<ArgumentNullException>(() => Program.Multiplication(null, "2"));
			Assert.Throws<ArgumentNullException>(() => Program.Multiplication(null, null));
		}

		// Division invalid
		[Test]
		public void TestDivision_Invalid_Scott()
		{
			Assert.Throws<FormatException>(() => Program.Division("6", "a"));
			Assert.Throws<FormatException>(() => Program.Division("a", "6"));
			Assert.Throws<FormatException>(() => Program.Division("a", "a"));
		}

		// Division null
		[Test]
		public void TestDivision_Null_Scott()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Division("6", null));
			Assert.Throws<ArgumentNullException>(() => Program.Division(null, "6"));
			Assert.Throws<ArgumentNullException>(() => Program.Division(null, null));
		}

		// Modulo invalid
		[Test]
		public void TestModulo_Invalid_Scott()
		{
			Assert.Throws<FormatException>(() => Program.Modulo("5", "a"));
			Assert.Throws<FormatException>(() => Program.Modulo("a", "5"));
			Assert.Throws<FormatException>(() => Program.Modulo("a", "a"));
		}

		// Modulo null
		[Test]
		public void TestModulo_Null_Scott()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Modulo("5", null));
			Assert.Throws<ArgumentNullException>(() => Program.Modulo(null, "5"));
			Assert.Throws<ArgumentNullException>(() => Program.Modulo(null, null));
		}
	}
}

