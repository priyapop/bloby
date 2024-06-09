using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bb : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public logicscript logic;
    public bool birdalive=true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true && birdalive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdalive = false;
    }
}
