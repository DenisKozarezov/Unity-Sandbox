/*******************************************
 * Created by Pavel Korolev
 * Last Modified 19.04.2022
 *******************************************/

using UnityEngine;

namespace AI.BehaviorTree.Nodes
{
    public abstract class DecoratorNode : Node
    {
        public AnimationCurve Curve; 
        [HideInInspector] public Node Child;

        public override Node Clone()
        {
            DecoratorNode clone = Instantiate(this);
            clone.Child = Child.Clone();
            return clone;
        }
    }   
}
