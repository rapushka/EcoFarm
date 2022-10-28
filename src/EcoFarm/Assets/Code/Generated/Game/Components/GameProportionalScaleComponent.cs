//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.ProportionalScaleComponent proportionalScale { get { return (Code.ECS.Components.ProportionalScaleComponent)GetComponent(GameComponentsLookup.ProportionalScale); } }
    public bool hasProportionalScale { get { return HasComponent(GameComponentsLookup.ProportionalScale); } }

    public void AddProportionalScale(float newValue) {
        var index = GameComponentsLookup.ProportionalScale;
        var component = (Code.ECS.Components.ProportionalScaleComponent)CreateComponent(index, typeof(Code.ECS.Components.ProportionalScaleComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceProportionalScale(float newValue) {
        var index = GameComponentsLookup.ProportionalScale;
        var component = (Code.ECS.Components.ProportionalScaleComponent)CreateComponent(index, typeof(Code.ECS.Components.ProportionalScaleComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveProportionalScale() {
        RemoveComponent(GameComponentsLookup.ProportionalScale);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherProportionalScale;

    public static Entitas.IMatcher<GameEntity> ProportionalScale {
        get {
            if (_matcherProportionalScale == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ProportionalScale);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherProportionalScale = matcher;
            }

            return _matcherProportionalScale;
        }
    }
}