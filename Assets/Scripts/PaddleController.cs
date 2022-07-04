using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode forwardKey;
    public KeyCode backwardKey;
    public KeyCode leftKey;
    public KeyCode rightKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    // Update is called once per frame
    void Update()
    {
    
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(forwardKey))
        {
            return Vector3.forward * speed;
        }
        else if (Input.GetKey(backwardKey))
        {
            return -Vector3.forward * speed;
        }
        else if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }
        else if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
            return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        transform.Translate(movement * Time.deltaTime);
    }
}
