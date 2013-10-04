﻿using TightDbCSharp;
using NUnit.Framework;
using TightDbCSharp.Extensions;


namespace TightDbCSharpTest
{
    /// <summary>
    /// test spec class
    /// </summary>
    [TestFixture]
    public static class SpecTests
    {
        /// <summary>
        /// test inspection of a table using spec
        /// </summary>
        [Test] public static void SpecInspection()
        {
            using (var table = new Table("IntColumn".Int(), "sub".SubTable("int".Int())))
            {
                Assert.AreEqual(2,table.Spec.ColumnCount );
                Assert.AreEqual(DataType.Table,table.Spec.GetColumnType(1));
                Assert.AreEqual("int", table.Spec.GetSpec(1).GetColumnName(0));
            }
        }
    }
}
