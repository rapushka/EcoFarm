//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Code.ECS.Components.FruitfulComponent fruitfulComponent = new Code.ECS.Components.FruitfulComponent();

    public bool isFruitful {
        get { return HasComponent(GameComponentsLookup.Fruitful); }
        set {
            if (value != isFruitful) {
                var index = GameComponentsLookup.Fruitful;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : fruitfulComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherFruitful;

    public static Entitas.IMatcher<GameEntity> Fruitful {
        get {
            if (_matcherFruitful == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Fruitful);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFruitful = matcher;
            }

            return _matcherFruitful;
        }
    }
}
