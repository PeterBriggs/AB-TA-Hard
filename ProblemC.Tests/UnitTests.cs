using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemC.Tests
{
    [TestClass]
    [DoNotParallelize]
    public class UnitTests
    {
        [TestMethod]
        [DataRow(1, 0)]
        [DataRow(2, 1)]
        [DataRow(10, 4)]
        [DataRow(23, 7)]
        public void CalculateMinTests_ReturnsCorrectResult(int kaboomThreshold, int expectedResult)
        {
            // Act
            int result = Program.CalculateMinTests(kaboomThreshold);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CalculateMinTests_WithMaxNumber_PerformsEfficiently()
        {
            // Arrange
            int kaboomThreshold = 4711;

            // Act
            int result = Program.CalculateMinTests(kaboomThreshold);

            // Assert
            Assert.AreEqual(97, result);
        }

        [TestMethod]
        public void CalculateMinTests_WithOne_ReturnsZero()
        {
            // Act
            int result = Program.CalculateMinTests(1);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Main_WithMultipleInputLines_OutputsCorrectResults()
        {
            // Arrange
            string input = "1\n2\n10\n23\n0\n";

            StringReader inputReader = new StringReader(input);
            StringWriter outputWriter = new StringWriter();

            Console.SetIn(inputReader);
            Console.SetOut(outputWriter);

            // Act
            Program.Main();

            // Assert
            // Normalize both strings by replacing Windows line endings with Unix line endings
            string expected = "0\n1\n4\n7\n";
            string actual = outputWriter.ToString().Replace("\r\n", "\n");

            Assert.AreEqual(expected, actual);
        }
    }
}
