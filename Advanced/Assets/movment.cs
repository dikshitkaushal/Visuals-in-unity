using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class movment : MonoBehaviour
{
    private float speed=2f;
    float movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.Translate(0,0,speed * Time.deltaTime);*/
        movement += speed * Time.deltaTime;
        transform.position = new Vector3(0, 1, movement);
    }
}
