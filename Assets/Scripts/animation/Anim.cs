using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu (fileName = "Animation", menuName = "AnimatorV2/Animation")]
public class Anim : ScriptableObject
{
    [Min(1)] public float framesPerSecond = 1;
    public bool loopAnimation;
    public AnimationFrame[] frames = new AnimationFrame[0];

    public Anim()
    {
        foreach(AnimationFrame frame in frames)
        {
            if(frame.duration < 1)
            {
                frame.duration = 1;
            }
        }
    }

    public Anim(float framesPerSecond, bool loopAnimation, AnimationFrame[] frames)
    {
        this.framesPerSecond = framesPerSecond;
        this.loopAnimation = loopAnimation;
        this.frames = frames;
        foreach(AnimationFrame frame in this.frames)
        {
            if(frame.duration < 1)
            {
                frame.duration = 1;
            }
        }
    }
}
