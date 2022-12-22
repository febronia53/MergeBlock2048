using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class musicScript2 : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    static musicScript2 instance = null;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save ()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    public void ToggleSound()
    {
        if(PlayerPrefs.GetFloat("musicVolume") == 0)
        {
            PlayerPrefs.SetFloat("musicVolume", 1.0f);
        }
        else
        {
            PlayerPrefs.SetFloat("musicVolume", 0.0f);
        }
    }
    // Update is called once per frame
   
}
