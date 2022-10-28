//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ProportionalScaleListenerComponent proportionalScaleListener { get { return (ProportionalScaleListenerComponent)GetComponent(GameComponentsLookup.ProportionalScaleListener); } }
    public bool hasProportionalScaleListener { get { return HasComponent(GameComponentsLookup.ProportionalScaleListener); } }

    public void AddProportionalScaleListener(System.Collections.Generic.List<IProportionalScaleListener> newValue) {
        var index = GameComponentsLookup.ProportionalScaleListener;
        var component = (ProportionalScaleListenerComponent)CreateComponent(index, typeof(ProportionalScaleListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceProportionalScaleListener(System.Collections.Generic.List<IProportionalScaleListener> newValue) {
        var index = GameComponentsLookup.ProportionalScaleListener;
        var component = (ProportionalScaleListenerComponent)CreateComponent(index, typeof(ProportionalScaleListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveProportionalScaleListener() {
        RemoveComponent(GameComponentsLookup.ProportionalScaleListener);
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

    static Entitas.IMatcher<GameEntity> _matcherProportionalScaleListener;

    public static Entitas.IMatcher<GameEntity> ProportionalScaleListener {
        get {
            if (_matcherProportionalScaleListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ProportionalScaleListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherProportionalScaleListener = matcher;
            }

            return _matcherProportionalScaleListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddProportionalScaleListener(IProportionalScaleListener value) {
        var listeners = hasProportionalScaleListener
            ? proportionalScaleListener.value
            : new System.Collections.Generic.List<IProportionalScaleListener>();
        listeners.Add(value);
        ReplaceProportionalScaleListener(listeners);
    }

    public void RemoveProportionalScaleListener(IProportionalScaleListener value, bool removeComponentWhenEmpty = true) {
        var listeners = proportionalScaleListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveProportionalScaleListener();
        } else {
            ReplaceProportionalScaleListener(listeners);
        }
    }
}