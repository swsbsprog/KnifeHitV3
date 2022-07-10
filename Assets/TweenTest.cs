using DG.Tweening;
using EasyButtons;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTest : MonoBehaviour
{

    public Ease ease;
    public LoopType loopType;
    //DG.Tweening.Core.TweenerCore<Vector3, Vector3, DG.Tweening.Plugins.Options.VectorOptions> result;

    public Vector3 endValue;
    public float duration;

    [Button]
    void Test()
    {
        //if(result != null)
        //    result.Kill();
        

        //result = transform.DOMove(endValue, duration)
        //    .SetEase(ease)
        //    .SetLoops(-1, loopType);
    }
}
