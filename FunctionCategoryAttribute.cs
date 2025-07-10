using System;

[AttributeUsage(AttributeTargets.Method)]
public class FunctionCategoryAttribute : Attribute
{
    public string Category { get; }

    public FunctionCategoryAttribute(string category)
    {
        Category = category;
    }
}