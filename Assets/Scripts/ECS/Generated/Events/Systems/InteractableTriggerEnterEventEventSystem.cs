//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class InteractableTriggerEnterEventEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IInteractableTriggerEnterEventListener> _listenerBuffer;

    public InteractableTriggerEnterEventEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IInteractableTriggerEnterEventListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.InteractableTriggerEnterEvent)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasInteractableTriggerEnterEvent && entity.hasInteractableTriggerEnterEventListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.interactableTriggerEnterEvent;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.interactableTriggerEnterEventListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnInteractableTriggerEnterEvent(e, component.Position, component.InteractableEntity, component.InteractableComponent);
            }
        }
    }
}
