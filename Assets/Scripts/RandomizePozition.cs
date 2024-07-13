using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePozition : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        x = Random.Range(-2, 3);
        y = 5;
        z = 6;
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }
}
