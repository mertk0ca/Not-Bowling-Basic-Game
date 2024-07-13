using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class BallThrow : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(0,0,-1f) * speed);
        
    }
    //Destroy(gameObject, 3);

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Remover")
        {
            Destroy(gameObject);
            //Debug.Log("remover");
        }
    }

}
