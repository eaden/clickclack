using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour {

    private Rigidbody2D rigid;
    private Vector2 movedir = Vector2.zero;
    private Vector3 m_EulerAngleVelocity = new Vector3(0, 0, 100);

    float maxSpeed = 3.5f;
    float rotSpeed = 90f;

    // Use this for initialization
    void Start () {

        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        // set movement to -no movement-

        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
        //pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        float inverter = -1;
        if (Input.GetAxis("Vertical") > 0)
            inverter = 1;
        else
            inverter = -1;
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime * inverter;
        rot = Quaternion.Euler(0, 0, z);

        transform.rotation = rot;

        
        pos += rot * velocity;
        transform.position = pos;

        /*
        // keyboard input
        if (Input.GetKey(KeyCode.W))
            rigid.velocity = Vector2.
        if(Input.GetKey(KeyCode.S))
            movedir += new Vector2(0, -1);
        if (Input.GetKey(KeyCode.A))
            rigid.rotation += 5.0f;
        //transform.rotation = Quaternion.EulerAngles(0, 0, 10f);
        if (Input.GetKey(KeyCode.D))
            movedir += new Vector2(1, 0);
            */
        //rigid.velocity = movedir;
        /*
         if (Input.anyKey == false)
            rigid.velocity = Vector2.zero;
            */
        //print(rigid.rotation);
    }
}
