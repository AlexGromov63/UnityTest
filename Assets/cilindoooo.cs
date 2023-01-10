using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cilindoooo : MonoBehaviour
{
    manager mng = null;
    // Start is called befo
    // re the first frame update
    public Vector3 angle;
    public Vector2Int speed;
    public void Awake()
    {
        Debug.Log("Awake");
        mng = FindObjectOfType<manager>();
    }
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        mng.GetComponent<Transform>().Rotate(angle * speed, Space.World);
        //GetComponent<Transform>().rotation = new Quaternion(0,1,0,0);
        if (Input.GetButtonDown("Space"))
        {
            Destroy(gameObject);
        }
    }

    public void LateUpdate()
    {
        
    }
    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        
    }
    private void OnMouseDown()
    {
        //gameObject.SetActive(false);
        Destroy(gameObject);
    }
    public void OnDestroy()
    {
        Debug.Log("destroyed");
    }
}

