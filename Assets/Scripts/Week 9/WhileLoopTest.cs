using UnityEngine;
using System.Collections;

public class WhileLoopTest : MonoBehaviour
{
    public float speed = 3f;

    Coroutine co;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //whle loop in the start function needs to be completed by the end of the first frame. That is why it moves to 7f instantly even though we have Time.deltaTime.
        /*while (this.transform.position.x < 7f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }*/

        co = StartCoroutine(MoveRightAndChangeColor());

        
    }

    // Update is called once per frame
    void Update()
    {
        /*while (this.transform.position.y < 10) //This while loop needs to finish before the end of the frame, but since the conditional will never become false, the while loop continues, trying to complete, be never will.
        { //This will freeze Unity
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(co);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            StopAllCoroutines();
        }
    }

    IEnumerator MoveRightAndChangeColor() //A good way to make things happen in order over time.
    {
        /*
        Debug.Log("Frame 1 Runs");
        yield return null; //This will pause the code until the next frame.
        Debug.Log("Frame 2 Runs");
        yield return new WaitForSeconds(2f); //This will wait 2 seconds before continuing the code.
        Debug.Log("Waited 2 seconds before posting this.");
        */

        while (this.transform.position.x < 7f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.blue;

        yield return new WaitForSeconds(2f);

        while (this.transform.position.x > -7f)
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
