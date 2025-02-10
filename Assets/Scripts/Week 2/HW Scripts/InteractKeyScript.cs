using UnityEngine;

public class InteractKeyScript : MonoBehaviour
{
    public InteractKeyFunctions keyFunctions;
    public GameObject maniaButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        keyFunctions.bellAudioSource.clip = keyFunctions.bellClip;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) 
        {

            keyFunctions.TranslateFight();
            keyFunctions.interactKeyText.text = "K.O.";
            maniaButton.SetActive(true);
            
        }
    }
}
