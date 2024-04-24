using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed;
    public float xDicrection;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xDicrection = Input.GetAxisRaw("Horizontal");
        float moveStep = moveSpeed * Time.deltaTime * xDicrection;
        if((transform.position.x <= -5.7 && xDicrection < 0) || (transform.position.x >= 5.7 && xDicrection > 0))
        {
            return;
        }
        transform.position = transform.position + new Vector3(moveStep, 0, 0);
    }
}
