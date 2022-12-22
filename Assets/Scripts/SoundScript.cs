using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundScript : MonoBehaviour
{

    private Sprite soundOnImage;

    public Button button;

    public Sprite soundOffImage;

    private musicScript2 music;


    // Start is called before the first frame update void Start()

    private void Start()
    {
        music = GameObject.FindObjectOfType<musicScript2>();
        soundOnImage = button.image.sprite;
        ButtonClicked();
    }

    public void PauseMusic()
    {
        music.ToggleSound();
        ButtonClicked();
    }
    // Update is called once per frame void Update()

    void ButtonClicked()
    {
        
            if (PlayerPrefs.GetFloat("musicVolume") == 0)
            {
                button.image.sprite = soundOffImage;
                AudioListener.volume = 1;
            }
            else
            {
                button.image.sprite = soundOnImage;
                
                AudioListener.volume = 0;
            }
       
        

    }
}