using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawner : MonoBehaviour
{
    private void Start()
    {
        knife = FindObjectOfType<Knife>(); // 좋진 않음(부하있음),
                                           // 테스트 용도로 좋음(인스펙터에서 드래그 하는거 까먹었을때 자동으로 할당함)
                                           // 단점 : 씬에 Knife가 2개 이상일때 어떤게 할당될지 모름
    }


    public Knife knife;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Knife newKnife = Instantiate(knife);
            newKnife.enabled = true;
            newKnife.GetComponent<Collider2D>().enabled = true;
            //print($"old:{knife.transform.position} :new {newKnife.transform.position}" );
            GameManager.Instance.UseLife();
        }
    }
}
