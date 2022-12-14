/*******************************************
 * Created by Pavel Korolev
 * Last Modified 19.04.2022
 *******************************************/

using System;
using Leopotam.Ecs;

namespace AI.ECS.Components
{
    [Serializable]
    public struct BehaviorTreeComponent
    {
        public EntityReference EntityReference;
        public BehaviorTree.BehaviorTree BehaviorTree;
        [NonSerialized] public bool Initialized;
    
        public void Init() 
        {
            BehaviorTree = BehaviorTree.Clone();
            BehaviorTree.Init(EntityReference);
            Initialized = true;
        }
    }
}