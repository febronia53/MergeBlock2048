using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public static ScoreScript Instance;
    public Text Score;
    public Text HighScore;
    
    int s = 0;
    public int h = 0;


    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        h = PlayerPrefs.GetInt("highscore", 0);
        Score.text = "Score : " + s.ToString();
        HighScore.text = "HighScore : " + h.ToString();
        
    }

    // Update is called once per frame
    public void AddPoint()
    {
        s += 10;
        
        Score.text = "Score : " + s.ToString();
        if (h < s)
        {
            PlayerPrefs.SetInt("highscore", s);
        }
    }
}
