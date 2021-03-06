// <copyright file="CharacterFormTest.cs">Copyright ©  2014</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZachsCharacterGenerater;

namespace ZachsCharacterGenerater.Tests
{
    /// <summary>This class contains parameterized unit tests for CharacterForm</summary>
    [PexClass(typeof(CharacterForm))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CharacterFormTest
    {
    }
}
