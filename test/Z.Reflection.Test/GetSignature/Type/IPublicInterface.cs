// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Type_GetSignature_IPublicInterface
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            Type @this = typeof (IPublicInterface);

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("IPublicInterface", result);
        }
    }
}