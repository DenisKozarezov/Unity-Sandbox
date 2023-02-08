//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Core.ECS.Events.FalseKnight.FalseKnightAttackEventComponent falseKnightAttackEventComponent = new Core.ECS.Events.FalseKnight.FalseKnightAttackEventComponent();

    public bool isFalseKnightAttackEvent {
        get { return HasComponent(GameComponentsLookup.FalseKnightAttackEvent); }
        set {
            if (value != isFalseKnightAttackEvent) {
                var index = GameComponentsLookup.FalseKnightAttackEvent;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : falseKnightAttackEventComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherFalseKnightAttackEvent;

    public static Entitas.IMatcher<GameEntity> FalseKnightAttackEvent {
        get {
            if (_matcherFalseKnightAttackEvent == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.FalseKnightAttackEvent);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFalseKnightAttackEvent = matcher;
            }

            return _matcherFalseKnightAttackEvent;
        }
    }
}
