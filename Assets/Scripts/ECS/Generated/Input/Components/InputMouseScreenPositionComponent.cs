//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public Core.ECS.Events.Player.MouseScreenPosition mouseScreenPosition { get { return (Core.ECS.Events.Player.MouseScreenPosition)GetComponent(InputComponentsLookup.MouseScreenPosition); } }
    public bool hasMouseScreenPosition { get { return HasComponent(InputComponentsLookup.MouseScreenPosition); } }

    public void AddMouseScreenPosition(UnityEngine.Vector2 newValue) {
        var index = InputComponentsLookup.MouseScreenPosition;
        var component = (Core.ECS.Events.Player.MouseScreenPosition)CreateComponent(index, typeof(Core.ECS.Events.Player.MouseScreenPosition));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMouseScreenPosition(UnityEngine.Vector2 newValue) {
        var index = InputComponentsLookup.MouseScreenPosition;
        var component = (Core.ECS.Events.Player.MouseScreenPosition)CreateComponent(index, typeof(Core.ECS.Events.Player.MouseScreenPosition));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMouseScreenPosition() {
        RemoveComponent(InputComponentsLookup.MouseScreenPosition);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherMouseScreenPosition;

    public static Entitas.IMatcher<InputEntity> MouseScreenPosition {
        get {
            if (_matcherMouseScreenPosition == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.MouseScreenPosition);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherMouseScreenPosition = matcher;
            }

            return _matcherMouseScreenPosition;
        }
    }
}
