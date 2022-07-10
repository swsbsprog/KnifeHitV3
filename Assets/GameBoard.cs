using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

        // 사과 랜덤하게 생성.
        MakeApples();
    }

    public Sprite apple;
    public int appleMin = 2;
    public int appleMax = 4;
    public float appleDistance = 1.8f;

    private void MakeApples()
    {
        var center = transform.position;
        int appleCount = Random.Range(appleMin, appleMax);

        for (int i = 0; i < appleCount; i++)
        {
            float rotation = Random.Range(0, 360);


            GameObject newApple = new GameObject("Apple");
            newApple.transform.rotation = Quaternion.Euler(0, 0, rotation);
            newApple.transform.position = center;
            //newApple.transform.SetPositionAndRotation(center, Quaternion.Euler(0, 0, rotation));
            newApple.transform.SetParent(transform);
            //newApple.transform.parent = transform; // 

            //newApple.transform.localPosition = new Vector3(0, 0, appleDistance); // 안되는 로직.
            newApple.transform.localPosition = newApple.transform.right * appleDistance;
            newApple.AddComponent<SpriteRenderer>().sprite = apple;
            newApple.tag = "Apple";
            CircleCollider2D circleCollider2D = newApple.AddComponent<CircleCollider2D>();
            circleCollider2D.radius = 0.3f;
            var direction = (newApple.transform.position - center);
            newApple.transform.right = direction;
            newApple.transform.Rotate(new Vector3(0, 0, -90), Space.Self);
        }
    }
}
