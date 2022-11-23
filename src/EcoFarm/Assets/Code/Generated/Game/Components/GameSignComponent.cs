//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Code.ECS.Components.Buildings.SignComponent signComponent = new Code.ECS.Components.Buildings.SignComponent();

    public bool isSign {
        get { return HasComponent(GameComponentsLookup.Sign); }
        set {
            if (value != isSign) {
                var index = GameComponentsLookup.Sign;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : signComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherSign;

    public static Entitas.IMatcher<GameEntity> Sign {
        get {
            if (_matcherSign == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Sign);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSign = matcher;
            }

            return _matcherSign;
        }
    }
}
