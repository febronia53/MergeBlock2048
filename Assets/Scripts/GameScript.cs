using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameScript : MonoBehaviour
{
    public GameObject[] randomBlocks = new GameObject[4];
    public Transform[] places = new Transform[8];
    public Transform[] newplaces = new Transform[4];

    public Transform[] columnPlaces = new Transform[4];
    public GameObject[] blocks = new GameObject[11];
    public GameObject[] recentBlocks;
    GameObject[] nodes;
    Blockmovement b;
    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
    
        spawn(false);

    }

    public void  spawn(bool cheek = false)
    {
        if (cheek == false)
        {
            for (int i = 0; i < 8; i++)
            {
                int randomIndex = Random.Range(0, randomBlocks.Length);
                Instantiate(randomBlocks[randomIndex], places[i].position, Quaternion.identity).transform.parent = places[i];
                // yield return new WaitForSeconds(0.1f);
            }
        }
        else
        {
            for (int i = 0; i < 4; i++)
            {
                int randomIndex = Random.Range(0, randomBlocks.Length);
                Instantiate(randomBlocks[randomIndex], newplaces[i].position, Quaternion.identity).transform.parent = newplaces[i];
                // yield return new WaitForSeconds(0.1f);
            }
        }
    }

    public void GameOverFunc()
    {
        GameOver.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void createNewBlocks()
    {
        for (int i = 0; i < 4; i++)
        {
            int randomIndex = Random.Range(0, randomBlocks.Length);
            Instantiate(randomBlocks[randomIndex], places[i].position, Quaternion.identity).transform.parent = places[i];
        }
    }


   
}
