using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawner : MonoBehaviour
{
    private void Start()
    {
        knife = FindObjectOfType<Knife>(); // ���� ����(��������),
                                           // �׽�Ʈ �뵵�� ����(�ν����Ϳ��� �巡�� �ϴ°� ��Ծ����� �ڵ����� �Ҵ���)
                                           // ���� : ���� Knife�� 2�� �̻��϶� ��� �Ҵ���� ��
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
