using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager Instance;
    public GameObject knifeCountGo;
    public Sprite usedKnife;
    public int lifeCount = 5;
    public List<Image> lifeUI;
    private void Awake(){Instance = this;}
    private void OnDestroy() =>Instance = null;
    public void Start()
    {
        currentLife = lifeCount;
        for (int i = 1; i < lifeCount; i++)
        {
            Instantiate(knifeCountGo, knifeCountGo.transform);
        }
    }
    public int currentLife;
    public void UseLife()
    {
        currentLife--;
        lifeUI[currentLife - 1].sprite = usedKnife;
    }
}
