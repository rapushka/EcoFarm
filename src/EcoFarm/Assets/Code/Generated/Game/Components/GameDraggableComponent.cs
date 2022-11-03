//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Code.ECS.Components.DraggableComponent draggableComponent = new Code.ECS.Components.DraggableComponent();

    public bool isDraggable {
        get { return HasComponent(GameComponentsLookup.Draggable); }
        set {
            if (value != isDraggable) {
                var index = GameComponentsLookup.Draggable;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : draggableComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherDraggable;

    public static Entitas.IMatcher<GameEntity> Draggable {
        get {
            if (_matcherDraggable == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Draggable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDraggable = matcher;
            }

            return _matcherDraggable;
        }
    }
}
