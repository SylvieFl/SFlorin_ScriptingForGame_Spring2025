using DG.Tweening;
using UnityEngine;

public class UITweenTest : MonoBehaviour
{
    public Transform beegYoshi;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //beegYoshi.DOMoveX(beegYoshi.position.x + 500f, 5f);
        //beegYoshi.DOMove(beegYoshi.position + (Vector3.right * 500), 5f);
        //beegYoshi.DORotate(beegYoshi.rotation.eulerAngles + new Vector3(0, 0, -180), 5f);

        Sequence s = DOTween.Sequence();
        s.Append(beegYoshi.DOMove(beegYoshi.position + (Vector3.right * 500), 5f));
        s.Insert(0f, beegYoshi.DORotate(beegYoshi.rotation.eulerAngles + new Vector3(0, 0, -180), 5f));
        s.Append(beegYoshi.DOMove(beegYoshi.position, 5f));
        s.Insert(5f, beegYoshi.DORotate(beegYoshi.rotation.eulerAngles, 5f));
        s.PlayForward();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            DOTween.CompleteAll();
        }
    }
}
