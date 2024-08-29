using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    //public float ObjectSpeed = 5f;
    public float force = 5f;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>(); // ����� ��������� ��������� ������ �� Addforce
            
    }

    private void Update()
    {
        //GetComponent<Rigidbody>().AddForce(Vector3.up * ObjectSpeed);

        float xdirection = 0.0f;
        float zdirection = 0.0f;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //transform.Translate(Vector3.up * ObjectSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.I))
        {
            zdirection = -1.0f;
        }
        
        else if (Input.GetKey(KeyCode.K))
        {
            zdirection = 1.0f;
        }

        if (Input.GetKey(KeyCode.J))
        {
            xdirection = 1.0f;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            xdirection = -1.0f;
        }

        //Vector3 directiom = new Vector3 (xdirection, 0, zdirection)* (ObjectSpeed * Time.deltaTime);
        Vector3 direction = new Vector3(xdirection, 0, zdirection) * force;

        //transform.Translate(direction);
        //_rigidbody.AddForce(direction);
        _rigidbody.velocity = direction;
    }
}
 