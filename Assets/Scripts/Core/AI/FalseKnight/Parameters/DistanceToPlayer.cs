using System.Linq;
using UnityEngine;
using Leopotam.Ecs;
using BehaviourTree.Runtime.Nodes;
using Core.Units;
using Core.ECS.Components.Units;

namespace Core.AI.FalseKnight.Parameters
{
    //public class DistanceToPlayer : FloatNode
    //{
    //    private Transform _player;
    //    private Transform _transform;

    //    protected override void OnInit()
    //    {
    //        _transform = Agent.Get<SpriteRendererComponent>().Value.transform;
    //        _player = FindObjectsOfType<UnitView>().Where(i => i.gameObject.layer == Constants.PlayerLayer).First().transform;
    //    }
    //    protected override State OnUpdate() 
    //    {               
    //        if (_player != null && _transform != null)
    //        {
    //            Value = (_transform.position - _player.position).magnitude;
    //        }
    //        return State.Success; 
    //    }
    //}
}