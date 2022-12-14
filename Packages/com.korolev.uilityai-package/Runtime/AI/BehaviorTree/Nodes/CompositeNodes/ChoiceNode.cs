using System.Collections.Generic;
using UnityEngine;

namespace AI.BehaviourTree.Nodes.Composites
{
    public class ChoiceNode : CompositeNode
    {
        [HideInInspector] private bool _existZeroParameter = false;
        [HideInInspector] protected Node actualNode;
        [HideInInspector] protected float maxCost = 0;
        [HideInInspector] public List<ParameterNode> ParametersList = new List<ParameterNode>();

        protected override State OnUpdate()
        {
            _existZeroParameter = false;
            maxCost = 0f;
            actualNode = null;
            
            if (ChildNodes.Count > 0)
            {
                foreach (var node in ChildNodes)
                {
                    _existZeroParameter = false;
                    float currentCost = 0f;
                    if (ParametersList.Count > 0)
                    {
                        foreach (var parameter in ParametersList)
                        {
                            float cost = node.Cost(parameter);
                            if (cost == 0f || cost < 0.001f)
                                _existZeroParameter = true;
                            currentCost += cost;
                        }
                    }
                    else
                        currentCost = node.Cost();
                    
                    if (_existZeroParameter)
                        currentCost = 0;
                    
                    if (currentCost > maxCost && currentCost > 0) {
                        actualNode = node;
                        maxCost = currentCost;
                    }
                }
                
                if(actualNode != null)
                {
                    BehaviourTreeRef.SetCurrentNode(actualNode);
                    return State.Success;
                }
            }
            return State.Success;
        }
        public override void RemoveChild(Node child)
        {
            base.RemoveChild(child);
            if (child is ParameterNode parameter)
            {
                ParametersList.Remove(parameter);
            }
        }
        public override Node Clone()
        {
            ChoiceNode clone = base.Clone() as ChoiceNode;
            clone.ParametersList = new List<ParameterNode>();
            return clone;
        }
    }   
}