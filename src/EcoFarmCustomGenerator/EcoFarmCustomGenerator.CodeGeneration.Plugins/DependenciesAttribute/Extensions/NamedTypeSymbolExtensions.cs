using System.Linq;
using DesperateDevs.Roslyn;
using EcoFarmCustomGenerator.CodeGeneration.Attributes;
using Entitas.CodeGeneration.Attributes;
using Entitas.CodeGeneration.Plugins;
using Microsoft.CodeAnalysis;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public static class NamedTypeSymbolExtensions
	{
		public static bool HasAttribute<T>(this INamedTypeSymbol @this)
			=> @this.GetAttribute<T>() != null;
		
		public static string GetContext(this INamedTypeSymbol type)
			=> type.GetAttributes()
			       .Select((ad) => ad.AttributeClass)
			       .Single((a) => a.BaseType.Name == nameof(ContextAttribute))
			       .Name.RemoveAttributeSuffix();

		private static string RemoveAttributeSuffix(this string @this)
			=> @this.EndsWith("Attribute") ? @this.Substring(0, @this.Length - "Attribute".Length) : @this;

		public static MemberData[] GetData(this INamedTypeSymbol type)
			=> type.GetMembers()
			       .OfType<IFieldSymbol>()
			       .Select((f) => new MemberData(f.Type.ToCompilableString(), f.Name))
			       .ToArray();

		public static string[] GetDependencies(this INamedTypeSymbol type)
			=> type.GetAttribute<DependenciesAttribute>()
			       .ConstructorArguments[0]
			       .Values.Select(TypedConstantExtensions.Resolve)
			       .ToArray();
	}
}