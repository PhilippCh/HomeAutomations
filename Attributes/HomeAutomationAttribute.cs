using JetBrains.Annotations;

namespace HomeAutomations.Attributes;

[AttributeUsage(AttributeTargets.Class)]
[MeansImplicitUse]
public class HomeAutomationAttribute : Attribute
{
}
