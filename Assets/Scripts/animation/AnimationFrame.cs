using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AnimationFrame
{
    public Sprite sprite;
    [Min(1)] public int duration = 1;
}
