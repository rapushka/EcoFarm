//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.Roslyn.CodeGeneration.Plugins.CleanupSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;
using Entitas;

public sealed class RemovePolluteGameSystem : ICleanupSystem {

    readonly IGroup<GameEntity> _group;
    readonly List<GameEntity> _buffer = new List<GameEntity>();

    public RemovePolluteGameSystem(Contexts contexts) {
        _group = contexts.game.GetGroup(GameMatcher.Pollute);
    }

    public void Cleanup() {
        foreach (var e in _group.GetEntities(_buffer)) {
            e.RemovePollute();
        }
    }
}
