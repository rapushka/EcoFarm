//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class PlayerComponentsLookup {

    public const int Text = 0;
    public const int View = 1;
    public const int LevelRelatedEntity = 2;
    public const int UnlockedLevelsCount = 3;
    public const int CompletedLevelsCount = 4;
    public const int CurrentPlayer = 5;
    public const int Destroy = 6;
    public const int Nickname = 7;
    public const int Player = 8;
    public const int SelectedLevel = 9;
    public const int SessionResult = 10;
    public const int PlayerTextListener = 11;
    public const int UnlockedLevelsCountListener = 12;

    public const int TotalComponents = 13;

    public static readonly string[] componentNames = {
        "Text",
        "View",
        "LevelRelatedEntity",
        "UnlockedLevelsCount",
        "CompletedLevelsCount",
        "CurrentPlayer",
        "Destroy",
        "Nickname",
        "Player",
        "SelectedLevel",
        "SessionResult",
        "PlayerTextListener",
        "UnlockedLevelsCountListener"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Code.ECS.Components.TextComponent),
        typeof(Code.ECS.Components.ViewComponent),
        typeof(Code.Global.LevelChoice.LevelRelatedEntityComponent),
        typeof(Code.Global.LevelChoice.UnlockedLevelsCountComponent),
        typeof(Code.Global.PlayerContexts.Components.CompletedLevelsCountComponent),
        typeof(Code.Global.PlayerContexts.Components.CurrentPlayerComponent),
        typeof(Code.Global.PlayerContexts.Components.DestroyComponent),
        typeof(Code.Global.PlayerContexts.Components.NicknameComponent),
        typeof(Code.Global.PlayerContexts.Components.PlayerComponent),
        typeof(Code.Global.PlayerContexts.Components.SelectedLevelComponent),
        typeof(Code.Global.PlayerContexts.Components.SessionResultComponent),
        typeof(PlayerTextListenerComponent),
        typeof(UnlockedLevelsCountListenerComponent)
    };
}
