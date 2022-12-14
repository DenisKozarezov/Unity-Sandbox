using Leopotam.Ecs;
using AI.BehaviourTree.Nodes;
using AI.BehaviourTree.Nodes.Parameters;
using Core.ECS.Components.Units;

namespace Core.AI.FalseKnight.Parameters
{
    public class Grounded : BooleanNode
    {
        protected override State OnUpdate()
        {
            Value = Agent.Has<OnGroundComponent>();
            return State.Success;
        }
        public override float Cost()
        {
            return Value ? 1f : 0f;
        }
    }
}