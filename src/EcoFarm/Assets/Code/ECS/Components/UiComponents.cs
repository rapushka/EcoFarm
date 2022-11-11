using Code.Unity.Containers;
using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code.ECS.Components
{
	[Game] [Event(Self)] public sealed class ActivateComponent : ValueComponent<bool> { }

	[Game] [Cleanup(RemoveComponent)] public sealed class ButtonClickComponent : FlagComponent { }

	[Game] public sealed class SellWindowComponent : ValueComponent<WindowSell> { }

	[Game] public sealed class TargetActivityComponent : ValueComponent<bool> { }

	[Game] [Event(Self)] public sealed class SliderMaxValueComponent : ValueComponent<float> { }

	[Game] [Event(Self)] public sealed class SliderValueComponent : ValueComponent<float> { }

	[Game] public sealed class RequirePreparationComponent : FlagComponent { }

	[Game] public sealed class PreparationInProcessComponent : FlagComponent { }

	[Game] public sealed class PreparedComponent : FlagComponent { }

	[Game] [Event(Self)] public sealed class TextComponent : ValueComponent<string> { }
}