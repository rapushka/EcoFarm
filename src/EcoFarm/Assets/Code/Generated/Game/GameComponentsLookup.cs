//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int DebugName = 0;
    public const int Growing = 1;
    public const int HasFruit = 2;
    public const int RequireTreeOnPosition = 3;
    public const int RequireView = 4;
    public const int SpawnPosition = 5;
    public const int Tree = 6;
    public const int View = 7;

    public const int TotalComponents = 8;

    public static readonly string[] componentNames = {
        "DebugName",
        "Growing",
        "HasFruit",
        "RequireTreeOnPosition",
        "RequireView",
        "SpawnPosition",
        "Tree",
        "View"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Code.ECS.Components.DebugNameComponent),
        typeof(Code.ECS.Components.GrowingComponent),
        typeof(Code.ECS.Components.HasFruitComponent),
        typeof(Code.ECS.Components.RequireTreeOnPositionComponent),
        typeof(Code.ECS.Components.RequireViewComponent),
        typeof(Code.ECS.Components.SpawnPositionComponent),
        typeof(Code.ECS.Components.TreeComponent),
        typeof(Code.ECS.Components.ViewComponent)
    };
}
