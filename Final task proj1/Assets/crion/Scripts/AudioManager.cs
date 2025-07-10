using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgMusic;
    public Slider volumeSlider;

    void Start()
    {
        volumeSlider.value = bgMusic.volume;
        volumeSlider.onValueChanged.AddListener(AdjustVolume);
    }

    public void AdjustVolume(float value)
    {
        
        
            bgMusic.volume = value;
        
    }
}
