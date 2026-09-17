using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeControl : MonoBehaviour
{
    [SerializeField] float speedMultiplier = 1;
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * Time.deltaTime * speedMultiplier;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * Time.deltaTime * speedMultiplier;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * speedMultiplier;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speedMultiplier;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * Time.deltaTime * speedMultiplier;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.position += Vector3.down * Time.deltaTime * speedMultiplier;
        }

    }
}
