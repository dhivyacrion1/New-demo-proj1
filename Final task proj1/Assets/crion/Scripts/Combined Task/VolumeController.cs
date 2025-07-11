using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider;
    private AudioSource backgroundMusic;

    void Start()
    {
        backgroundMusic = backgroundMusic = FindObjectOfType<AudioSource>();


        float savedVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
        backgroundMusic.volume = savedVolume;
        volumeSlider.value = savedVolume;

        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        backgroundMusic.volume = volume;
        PlayerPrefs.SetFloat("MusicVolume", volume);
        PlayerPrefs.Save();
    }
}
