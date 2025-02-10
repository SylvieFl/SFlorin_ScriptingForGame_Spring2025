using UnityEngine;

public class ConditionalPractice : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    public Color go2Elsecolor;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ColorGameObjectByName();
        ColorGameObjectByTag();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ColorGameObjectByName()
    {
        Debug.Log("go is named " + go.name);
        Debug.Log("go2 is named " + go2.name);

        //If we create a local variable in the function that does the GetComponent call
        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.name == "Cube")
        {
            //Get Component will look fot the component on the gameObject it is being called on. If there is no component of the type you are trying to get, when
            //you use the dot operator after it, it will throw a null reference exception.
            //go.GetComponent<MeshRenderer>().material.color = Color.magenta; //Doing this way can become very expensive if you are doing it for a lot of objects.
            goMeshRenderer.material.color = Color.magenta;
            //Change the color to magenta.
        }
        else if (go.name == "Sphere")
        {
            goMeshRenderer.material.color = Color.cyan;
            //Change the color to cyan.
        }
        else if (go.name == "Cylinder")
        {
            goMeshRenderer.material.color = Color.black;
            //Change the color to black.
        }
        else
        {
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
            //Change the color to orange.
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.name == "Cube")
        {
            go2MeshRenderer.material.color = Color.gray;
            //Change the color to gray.
        }
        else if (go2.name == "Sphere")
        {
            go2MeshRenderer.material.color = Color.white;
            //Change the color to white.
        }
        else if (go2.name == "Cylinder")
        {
            go2MeshRenderer.material.color = Color.red;
            //Change the color to red.
        }
        else
        {
            go2MeshRenderer.material.color = go2Elsecolor;
            //Change the color to orange.
        }
    }

    void ColorGameObjectByTag()
    {
        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.tag == "Coolguy")
        {
            goMeshRenderer.material.color = Color.magenta;
            //Change the color to magenta.
        }
        else if (go.tag == "NotCoolguy")
        {
            goMeshRenderer.material.color = Color.cyan;
            //Change the color to cyan.
        }
        else if (go.tag == "Okayguy")
        {
            goMeshRenderer.material.color = Color.black;
            //Change the color to black.
        }
        else
        {
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
            //Change the color to orange.
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.tag == "Coolguy")
        {
            go2MeshRenderer.material.color = Color.gray;
            //Change the color to gray.
        }
        else if (go2.tag == "NotCoolguy")
        {
            go2MeshRenderer.material.color = Color.white;
            //Change the color to white.
        }
        else if (go2.tag == "Okayguy")
        {
            go2MeshRenderer.material.color = Color.red;
            //Change the color to red.
        }
        else
        {
            go2MeshRenderer.material.color = go2Elsecolor;
            //Change the color to orange.
        }
    }
}
