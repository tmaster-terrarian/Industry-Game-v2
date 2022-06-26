using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public static AnimatorV2[] animators = new AnimatorV2[0];
    public static AnimationManager instance;

    void Awake()
    {
        instance = this;
    }
    
    public static void SyncAnimators(AnimCategory category, int index)
    {
        AnimatorV2[] ans = GetAnimatorsInCategory(category);
        for (int i = 0; i < ans.Length; i++)
        {
            if(ans[i] != null)
            {
                ans[i].Stop();
                ans[i].Play(index);
            }
        }
    }

    static AnimatorV2[] GetAnimatorsInCategory(AnimCategory category)
    {
        AnimatorV2[] ans = new AnimatorV2[0];
        foreach(AnimatorV2 animator in animators)
        {
            if(animator != null)
            {
                if(animator.category == category)
                {
                    ans = Util.AddToArray(ans, animator);
                }
            }
        }
        return ans;
    }
}

public enum AnimCategory
{
    Belts
}
