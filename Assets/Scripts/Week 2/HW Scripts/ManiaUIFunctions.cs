using UnityEngine;

public class ManiaUIFunctions : MonoBehaviour
{
    public Transform rotateAxis;
    public Transform button;
    public float speed = 0f;

    public GameObject keyText;

    public GameObject Miz01;
    public GameObject Miz02;
    public GameObject Miz03;
    public GameObject Miz04;

    public GameObject light01;
    public GameObject light02;
    public GameObject light03;
    public GameObject light04;

    public Transform Text01;
    public Transform Text02;
    public Vector3 startPosition1;
    public Vector3 startPosition2;
    public Vector3 endPosition1;
    public Vector3 endPosition2;
    private bool moveText01 = true;
    private bool moveText02 = true;

    public void Spin()
    {
        button.RotateAround(rotateAxis.position, Vector3.back, speed * Time.deltaTime);
    }

    public void RotatingMiz()
    {
        Miz01.SetActive(true);
        Miz02.SetActive(true);
        Miz03.SetActive(true);
        Miz04.SetActive(true);

        Miz01.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        Miz04.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        Miz02.transform.Rotate(Vector3.back * speed * Time.deltaTime);
        Miz03.transform.Rotate(Vector3.back * speed * Time.deltaTime);
    }

    public void LightOn()
    {
        light01.SetActive(true);
        light02.SetActive(true);
        light03.SetActive(true);
        light04.SetActive(true);
    }
    public void TextMove()
    {
        if (Text01.position.y > endPosition1.y && moveText01 == true)
        {
            Text01.position += new Vector3(500f, -300f, 0f) * Time.deltaTime;
            if (Text01.position.y <= endPosition1.y)
            {
                moveText01 = false;
            }
        }

        if (Text01.position.y < startPosition1.y && moveText01 == false)
        {
            Text01.position -= new Vector3(500f, -300f, 0f) * Time.deltaTime;
            if (Text01.position.y >= startPosition1.y)
            {
                moveText01 = true;
            }
        }

        if (Text02.position.y < endPosition2.y && moveText02 == true)
        {
            Text02.position += new Vector3(500f, 300f, 0f) * Time.deltaTime;
            if (Text02.position.y >= endPosition2.y)
            {
                moveText02 = false;
            }
        }

        if (Text02.position.y > startPosition2.y && moveText02 == false)
        {
            Text02.position -= new Vector3(500f, 300f, 0f) * Time.deltaTime;
            if (Text02.position.y <= startPosition2.y)
            {
                moveText02 = true;
            }
        }


    }

}
