using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class AnimatorV2 : MonoBehaviour
{
    SpriteRenderer sr;
    bool isAnimating = false;
    Sprite origSprite;

    public PlayMode playMode = PlayMode.OnAwake;
    public AnimCategory category;
    public Anim[] animations;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();

        AnimationManager.animators = Util.AddToArray<AnimatorV2>(AnimationManager.animators, this);

        origSprite = sr.sprite;

        if(animations == null)
        {
            Debug.LogWarning("No Animations set on AnimatorV2 (" + gameObject.name + "). It will not be able to animate and may cause errors.");
        }
        if(playMode == PlayMode.OnAwake)
        {
            Play(0);
        }
    }

    public void Play(int index)
    {
        if(animations[index] != null)
        {
            isAnimating = true;
            StartCoroutine(AnimateSprite(animations[index], origSprite));
        }
        else Debug.LogWarning("No Animation exists with the id: " + index);
    }

    public void Stop()
    {
        StopAllCoroutines();
        isAnimating = false;
        sr.sprite = origSprite;
    }

    IEnumerator AnimateSprite(Anim animation, Sprite origSprite)
    {
        if(animation.loopAnimation == true)
        {
            int frameIndex = 0;
            while(isAnimating)
            {
                if(!isAnimating) break;
                AnimationFrame frame = animation.frames[frameIndex];
                yield return new WaitForSeconds((1 / animation.framesPerSecond) * frame.duration);
                sr.sprite = frame.sprite;
                frameIndex++;
                if(frameIndex > animation.frames.Length - 1)
                {
                    frameIndex = 0;
                }
            }
            yield return null;
        }
        else
        {   
            if(isAnimating)
            {
                foreach (AnimationFrame frame in animation.frames)
                {
                    if(!isAnimating) break;
                    yield return new WaitForSeconds((1 / animation.framesPerSecond) * frame.duration);
                    sr.sprite = frame.sprite;
                }
            }
            isAnimating = false;
            yield return null;
        }
    }
}

public enum PlayMode
{
    ViaScript,
    OnAwake
}
