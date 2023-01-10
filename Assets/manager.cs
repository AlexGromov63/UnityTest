using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public void RotateGameObject(GameObject go, float x, float y, float z)
    {
        /*
         
        многа кода  
         
         */ 
        go.GetComponent<Transform>().Rotate(x,y,z);
    }
    // Start is called before the first frame update
    public void Awake()
    {
        Debug.Log("Awake");
        
    }
    void Start()
    {
        
    }
    public void OnDestroy()
    {
        Debug.Log("destroyed");
    }
    // Update is called once per frame
    void Update()
    {
        FindObjectOfType<manager>().RotateGameObject(gameObject, 1, 0, 0);

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
}
