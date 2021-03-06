// <copyright file="AbilityModifierTest.cs">Copyright ©  2014</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZachsCharacterGenerater.Classes;

namespace ZachsCharacterGenerater.Classes.Tests
{
    /// <summary>This class contains parameterized unit tests for AbilityModifier</summary>
    [PexClass(typeof(AbilityModifier))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AbilityModifierTest
    {
        /// <summary>Test stub for Calculate(Int32)</summary>
        [PexMethod]
        public int CalculateTest([PexAssumeUnderTest]AbilityModifier target, int totalScore)
        {
            int result = target.Calculate(totalScore);
            return result;
            // TODO: add assertions to method AbilityModifierTest.CalculateTest(AbilityModifier, Int32)
        }
    }
}
