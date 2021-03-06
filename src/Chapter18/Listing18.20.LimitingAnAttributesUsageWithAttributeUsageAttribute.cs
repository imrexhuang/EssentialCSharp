namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_20
{
    using System;

    // Restrict the attribute to properties and methods
    [AttributeUsage(
      AttributeTargets.Field | AttributeTargets.Property)]
    public class CommandLineSwitchAliasAttribute : Attribute
    {
        // ...
    }
}