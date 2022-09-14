🔵 입력 바인딩의 기본

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Movement : MonoBehaviour
    {
        void Update()
        {
            ProcessThrust();
            ProcessRotation();
        }

        void ProcessThrust() 
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("Pressed SPACE - Thrusting");
            }
        }

        void ProcessRotation()
        {
            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("Rotate Left");
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("Rotate Right");
            }
        }
}

🔵 AddRelativeForce() 메소드

    void ProcessThrust() 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // rb.AddRelativeForce(0, 1, 0);
            rb.AddRelativeForce(Vector3.up);   // 위랑 같은 뜻 y축으로 올라감
        }
    }

🔵 transform.Rotate() 메소드

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]float mainThrust = 300f;
    [SerializeField]float rotationThrust = 100f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    private void ProcessThrust() 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }

    private void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            ApplyRotation(rotationThrust);      
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotationThrust);
        }
    }

    private void ApplyRotation(float rotationThisFrame)
    {
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);   
    }
}

🔵 rigidbody 제약 조건

    private void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true; // '수동 제어를 할 수 있도록 회전을 고정한다'
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false; // 물리 시스템이 적용되도록 회전 고정을 해제한다.
    }
    
    
    
    
