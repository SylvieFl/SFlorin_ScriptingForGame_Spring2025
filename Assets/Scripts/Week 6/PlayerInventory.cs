using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool hasKey = false;
    public bool hasRedKey = false;
    public bool hasBlueKey = false;
    public bool hasYellowKey = false;
    public GameObject playerCamera;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Are we looking at the door?
            RaycastHit hitObject; //This variable contains the data of what will be hit by the Raycast we're able to make.
            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hitObject, 10f))
            {
                if (hitObject.collider.gameObject.tag == "Door")
                {
                    Door lookedAtDoor = hitObject.collider.gameObject.GetComponent<Door>();

                    if (lookedAtDoor.doorColor == KeyColor.Red && hasRedKey == true)
                    {
                        //OpenDoor
                        hitObject.collider.gameObject.GetComponent<Door>().OpenDoor();
                    }
                    else if (lookedAtDoor.doorColor == KeyColor.Blue && hasBlueKey == true)
                    {
                        hitObject.collider.gameObject.GetComponent<Door>().OpenDoor();
                    }
                    else if (lookedAtDoor.doorColor == KeyColor.Yellow && hasYellowKey == true)
                    {
                        hitObject.collider.gameObject.GetComponent<Door>().OpenDoor();
                    }

                    /*if (hasKey == true)
                    {
                        //OpenDoor
                        hitObject.collider.gameObject.GetComponent<Door>().OpenDoor();
                    }*/
                }
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            KeyColor pickedUpKeyColor = other.gameObject.GetComponent<Key>().color;

            if (pickedUpKeyColor == KeyColor.Red)
            {
                hasRedKey = true;
            }
            else if (pickedUpKeyColor == KeyColor.Blue)
            {
                hasBlueKey = true;
            }
            else if (pickedUpKeyColor == KeyColor.Yellow)
            {
                hasYellowKey = true;
            }

            Destroy(other.gameObject);
        }
    }
}
