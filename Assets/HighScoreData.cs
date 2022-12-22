using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class HighScoreData : MonoBehaviour
{
    public Text playerNameTxt;
    public Text Score;
    public HighScoreElement highScore;
    // Start is called before the first frame update
    string jsonFilePath;
    private void Awake()
    {
        jsonFilePath = Application.streamingAssetsPath + "/highScoreData.json"; 
    }
    void Start()
    {
        DisplayHighScoreData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DisplayHighScoreData()
    {
        ReadingScoreData();

        playerNameTxt.text = highScore.playerName;
        Score.text = highScore.points.ToString();
    }

    private void SaveScoreData()
    {
        string HighScoreDataJson = JsonUtility.ToJson(highScore,true);
        File.WriteAllText(jsonFilePath, HighScoreDataJson);
    }

    private void ReadingScoreData()
    {
        if (!File.Exists(jsonFilePath))
        {
            SaveScoreData();
        }

        string fileContent = "";

        fileContent = File.ReadAllText(jsonFilePath);

        highScore = JsonUtility.FromJson<HighScoreElement>(fileContent);
    }
}
