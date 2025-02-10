using UnityEngine;
using UnityEngine.UI;

public class ManiaUI : MonoBehaviour
{
    
    public bool isRotating = false;

    public GameObject keyText;

    public AudioSource mizAudioSource;
    public AudioClip mizTheme;

    public ManiaUIFunctions maniaFunctions;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mizAudioSource.clip = mizTheme;
        maniaFunctions.speed = 450f;
    }

    // Update is called once per frame
    void Update()
    {   
        if (isRotating == true)
        {
            keyText.SetActive(false);
            maniaFunctions.Spin();
            maniaFunctions.RotatingMiz();
            maniaFunctions.LightOn();
            maniaFunctions.TextMove();
        }
    }

    public void RotateButton()
    {
        isRotating = !isRotating;
    }

    public void PlayMizTheme()
    {
        if (isRotating == true)
        {
            mizAudioSource.Play();
        }

        if (isRotating == false)
        {
            mizAudioSource.Stop();
        }

    }
}
