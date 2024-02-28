// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace TestApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var DB = new TestContext())
            {
                DB.Database.EnsureDeleted();
                DB.Database.EnsureCreated();

                TestEntity t = new TestEntity();
                t.ID = Guid.NewGuid();
                DB.Set<TestEntity>().Add(t);
                DB.SaveChanges();
            }
        }
    }
}
