using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractKeyFunctions : MonoBehaviour
{
    public GameObject mizFight;
    public GameObject bryantFight;
    public GameObject actionStep1Position;

    public TextMeshProUGUI interactKeyText;

    public AudioSource bellAudioSource;
    public AudioClip bellClip;

    public void TranslateFight()
    { 
        mizFight.transform.position = actionStep1Position.transform.position;
        bryantFight.transform.Rotate(new Vector3(0, 0, 90));
        bellAudioSource.Play();
    }

}
