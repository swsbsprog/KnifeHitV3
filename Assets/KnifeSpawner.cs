using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawner : MonoBehaviour
{
    private void Start()
    {
        knife = FindObjectOfType<Knife>();
    }


    public Knife knife;
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Knife newKnife = Instantiate(knife);
            newKnife.enabled = true;
            newKnife.GetComponent<Collider2D>().enabled = true;
            //print($"old:{knife.transform.position} :new {newKnife.transform.position}" );
        }
    }
}
