using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public float distance;
    public float rotaSpeed;
    public float ang;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            ang -= rotaSpeed;
        }
        if (Input.GetKey(KeyCode.RightShift))
        {
            ang += rotaSpeed;
        }
        transform.position = new Vector3(
            player.transform.position.x + distance * Mathf.Cos(ang * Mathf.Deg2Rad),
            player.transform.position.y + 2,
            player.transform.position.z + distance * Mathf.Sin(ang * Mathf.Deg2Rad));
        transform.LookAt(player.transform.position);
    }
}
