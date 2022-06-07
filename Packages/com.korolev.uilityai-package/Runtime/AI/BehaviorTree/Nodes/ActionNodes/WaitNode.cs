/*******************************************
 * Created by Pavel Korolev
 * Last Modified 19.04.2022
 *******************************************/

using UnityEngine;

namespace AI.BehaviorTree.Nodes.ActionNodes
{
    public class WaitNode : ActionNode
    {
        [HideInInspector] private float _currentTimeWait = 0;
        public float TimeWait;
     
        public override void OnStart() { }
        public override void OnStop() { }
        public override State OnUpdate()
        {
            if (_currentTimeWait >= TimeWait)
            {
                _currentTimeWait = 0;
                return State.Success;
            }
            _currentTimeWait += Time.deltaTime;
            return State.Running;
        }
    }
}