using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public new Rigidbody2D rigidbody2D;
    public Vector2 force = new Vector2(0, 10f);
    void Start()
    {
        print("Start");
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
        rigidbody2D.AddForce(force, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var knifeTr = transform;
        var tag = collision.gameObject.tag;
        switch (tag)
        {
            case "GameBoard":
                print(collision.contacts[0].point);
                knifeTr.position = collision.contacts[0].point;
                rigidbody2D.bodyType = RigidbodyType2D.Static;
                knifeTr.SetParent(collision.transform); // Į�� �θ� GameBoard�� ����.
                break;
            case "Apple":
                // ���忡 Į�� ������ ����
                // ���� ����.
                print("���� ����");
                GameManager.Instance.AddScore(1);
                Destroy(collision.gameObject); // ���
                break;
            case "Knife":
                // Į�� �ð� ������ �ϱ�
                break;
        }
    }
}
