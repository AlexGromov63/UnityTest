using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cilinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().Rotate(0, 1, 0);
        //GetComponent<Transform>().rotation = new Quaternion(0,1,0,0);
        if (Input.GetButtonDown("space"))
        {
            Destroy(gameObject);
        }
    }
    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}
