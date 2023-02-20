//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.Roslyn.CodeGeneration.Plugins.CleanupSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameCleanupSystems : Feature {

    public GameCleanupSystems(Contexts contexts) {
        Add(new DestroyCameraShakeGameSystem(contexts));
        Add(new DestroyCameraFadeGameSystem(contexts));
        Add(new RemoveRestoredHealthGameSystem(contexts));
        Add(new RemoveEnergyReducedGameSystem(contexts));
        Add(new RemovePlayerTalkingWithNPCEventGameSystem(contexts));
        Add(new RemoveEnteredBossZoneGameSystem(contexts));
        Add(new DestroyDestroyedGameSystem(contexts));
        Add(new RemoveAttackingGameSystem(contexts));
        Add(new RemoveDamageTakenGameSystem(contexts));
        Add(new RemoveStoppedMovingGameSystem(contexts));
        Add(new RemoveCollidedGameSystem(contexts));
    }
}
