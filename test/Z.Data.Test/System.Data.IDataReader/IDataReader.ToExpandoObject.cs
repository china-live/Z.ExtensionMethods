// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_IDataReader_ToExpandoObject
    {
        [TestMethod]
        public void ToExpandoObject()
        {
            string sql = "SELECT 1 AS IntColumn, 'FizzBuzz' AS StringColumn";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                conn.Open();
                using (DbCommand command = conn.CreateCommand())
                {
                    command.CommandText = sql;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        dynamic entity = reader.ToExpandoObject();

                        // Unit Test
                        Assert.AreEqual(1, entity.IntColumn);
                        Assert.AreEqual("FizzBuzz", entity.StringColumn);
                    }
                }
            }
        }
    }
}