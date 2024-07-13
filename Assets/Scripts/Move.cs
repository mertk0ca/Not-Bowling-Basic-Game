using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 50f;

    private float xInput;

    Timer Timer;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Timer = GetComponent<Timer>();
    }

    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        //MoveFunc();
        MoveFuncMouse();
    }

    private void ProcessInputs()
    {
        xInput = Input.mousePosition.x / 100;
    }

    private void MoveFunc()
    {
        rb.AddForce(new Vector3(xInput, 0f, 0f) * moveSpeed);
    }

    private void MoveFuncMouse()
    {
        Vector3 playerScreenPos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 direction = (playerScreenPos - Input.mousePosition).normalized;
        rb.AddForce(-direction * moveSpeed);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ball")
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (collisionInfo.collider.tag == "Gun")
        {
            Debug.Log("Fire");
        }
    }
}
