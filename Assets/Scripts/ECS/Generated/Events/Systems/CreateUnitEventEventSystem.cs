//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class CreateUnitEventEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<ICreateUnitEventListener> _listenerBuffer;

    public CreateUnitEventEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<ICreateUnitEventListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.CreateUnitEvent)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasCreateUnitEvent && entity.hasCreateUnitEventListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.createUnitEvent;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.createUnitEventListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnCreateUnitEvent(e, component.ID, component.Point);
            }
        }
    }
}
