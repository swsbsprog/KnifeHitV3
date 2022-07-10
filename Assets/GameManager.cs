using DG.Tweening;
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
        lifeUI.Add(knifeCountGo.GetComponent<Image>());
        for (int i = 1; i < lifeCount; i++)
        {
            var newLifeGo = Instantiate(knifeCountGo, knifeCountGo.transform.parent);
            lifeUI.Add(newLifeGo.GetComponent<Image>());
        }
    }
    public CanvasGroup gameoverUICanvasGroup;
    public int currentLife;
    private float duration = 0.5f;

    public void UseLife()
    {
        currentLife--;
        lifeUI[lifeUI.Count - currentLife - 1].sprite = usedKnife;
        if (currentLife == 0)// GameOverUIÇ¥½Ã
        {
            gameoverUICanvasGroup.gameObject.SetActive(true);
            gameoverUICanvasGroup.alpha = 0;
            gameoverUICanvasGroup.DOFade(1, duration);
        }
    }


    public Text scoreText;
    public int score;
    public void AddScore(int addScore)
    {
        score += addScore;
        scoreText.text = score.ToString();
    }
}
