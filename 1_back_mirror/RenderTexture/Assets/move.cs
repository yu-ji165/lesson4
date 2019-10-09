using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    private GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(
            transform.position.x + Mathf.Cos(mainCamera.GetComponent<cameraMove>().ang * Mathf.Deg2Rad),
            transform.position.y,
            transform.position.z + Mathf.Sin(mainCamera.GetComponent<cameraMove>().ang * Mathf.Deg2Rad)));
        Vector3 move = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move.z -= speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move.z = speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move.x = speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move.x -= speed;
        }
        //transform.position += move;
        transform.Translate(move);
    }
}
