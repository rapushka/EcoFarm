//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.SpriteHighComponent spriteHigh { get { return (Code.ECS.Components.SpriteHighComponent)GetComponent(GameComponentsLookup.SpriteHigh); } }
    public bool hasSpriteHigh { get { return HasComponent(GameComponentsLookup.SpriteHigh); } }

    public void AddSpriteHigh(float newValue) {
        var index = GameComponentsLookup.SpriteHigh;
        var component = (Code.ECS.Components.SpriteHighComponent)CreateComponent(index, typeof(Code.ECS.Components.SpriteHighComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSpriteHigh(float newValue) {
        var index = GameComponentsLookup.SpriteHigh;
        var component = (Code.ECS.Components.SpriteHighComponent)CreateComponent(index, typeof(Code.ECS.Components.SpriteHighComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSpriteHigh() {
        RemoveComponent(GameComponentsLookup.SpriteHigh);
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

    static Entitas.IMatcher<GameEntity> _matcherSpriteHigh;

    public static Entitas.IMatcher<GameEntity> SpriteHigh {
        get {
            if (_matcherSpriteHigh == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpriteHigh);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpriteHigh = matcher;
            }

            return _matcherSpriteHigh;
        }
    }
}
