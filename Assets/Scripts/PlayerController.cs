using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public bool right;

    // Start is called before the first frame update
    void Start()
    {
        if (!right)
        {
            transform.Rotate(Vector3.back * 180);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed);
        //transform.Rotate(Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        DirectionalNode dn = other.GetComponent<DirectionalNode>();
        Debug.Log(dn.current);

        Vector3 dir = Vector3.one;
        float rot = 90;

        switch(dn.current)
        {
            case "left":
                dir = Vector3.forward;
                break;
            case "right":
                dir = Vector3.back;
                break;
            default:
                rot = 0;
                break;
        }

        transform.Rotate(dir * rot);
    }
}
