using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipemovescript : MonoBehaviour
{
    public float moveSpeed = 7;
    public float deadzone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =transform.position + (new Vector3(-2, 0, 0) * moveSpeed)* Time.deltaTime;
       if (transform.position.x<deadzone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
            
    }
}
