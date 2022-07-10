using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    public float minAngle = 1000f;
    public float maxAngle = 1200f;
    public Ease ease = Ease.InOutQuint;


    void Start()
    {
        DOTween.To(
            () => transform.rotation.eulerAngles.z,
             x => transform.rotation = Quaternion.Euler(0.0f, 0.0f, x),
             Random.Range(minAngle, maxAngle),
             2f
            ).SetEase(ease)
            .SetLoops(-1, LoopType.Incremental);
    }
}
