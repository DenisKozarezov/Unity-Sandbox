using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] private Animation animation;
    [SerializeField] private AnimationClip animClip;

    private void Awake()
    {
        animation.AddClip(animClip, "First");
        animation.Play("First");
    }
}
