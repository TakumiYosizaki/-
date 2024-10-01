using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreChanger : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textMeshPro;

    [System.NonSerialized]
    public int numberOfItem;

    public void AddScore()
    {
        numberOfItem++;  
        UpdateScoreText(); 
    }

    private void UpdateScoreText()
    {
        
        textMeshPro.SetText("Score {0}", numberOfItem);
    }

    void Start()
    {
        numberOfItem = 0;  
        UpdateScoreText();  
    }
}
