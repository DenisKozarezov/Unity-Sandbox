//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Core.ECS.Components.Units.SpriteRendererComponent spriteRenderer { get { return (Core.ECS.Components.Units.SpriteRendererComponent)GetComponent(GameComponentsLookup.SpriteRenderer); } }
    public bool hasSpriteRenderer { get { return HasComponent(GameComponentsLookup.SpriteRenderer); } }

    public void AddSpriteRenderer(UnityEngine.SpriteRenderer newValue) {
        var index = GameComponentsLookup.SpriteRenderer;
        var component = (Core.ECS.Components.Units.SpriteRendererComponent)CreateComponent(index, typeof(Core.ECS.Components.Units.SpriteRendererComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSpriteRenderer(UnityEngine.SpriteRenderer newValue) {
        var index = GameComponentsLookup.SpriteRenderer;
        var component = (Core.ECS.Components.Units.SpriteRendererComponent)CreateComponent(index, typeof(Core.ECS.Components.Units.SpriteRendererComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSpriteRenderer() {
        RemoveComponent(GameComponentsLookup.SpriteRenderer);
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

    static Entitas.IMatcher<GameEntity> _matcherSpriteRenderer;

    public static Entitas.IMatcher<GameEntity> SpriteRenderer {
        get {
            if (_matcherSpriteRenderer == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpriteRenderer);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpriteRenderer = matcher;
            }

            return _matcherSpriteRenderer;
        }
    }
}
