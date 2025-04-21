using TMPro;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public int totalMisClicks;
    
    public GameObject winScreen;
    public TextMeshProUGUI misclicksText;

    public AudioSource audioSource;
    public AudioClip wrongClickSFX;
    public AudioClip correctClickSFX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.tag == "Psyduck")
                {
                    audioSource.PlayOneShot(correctClickSFX); //Play correct click sound
                    winScreen.SetActive(true); //Display Win screen
                    misclicksText.text = totalMisClicks.ToString(); //Win Screen displays number of misclicks.
                    Debug.Log("Psyduck Found");
                }
                else
                {
                    totalMisClicks++;
                    audioSource.PlayOneShot(wrongClickSFX); //Play wrong click sound
                    Debug.Log("Misclicks " + totalMisClicks);
                }
            }
            else
            {
                totalMisClicks++;
                audioSource.PlayOneShot(wrongClickSFX); //play wrong click sound
                Debug.Log("Misclicks " + totalMisClicks);
            }

        }
    }
}
