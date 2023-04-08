using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode : MonoBehaviour
{
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        SwitchSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchSprite()
    {
        switch(current)
        {
            case "left":
                sr.sprite = left;
                break;
            case "right":
                sr.sprite = right;
                break;
            default:
                sr.sprite = none;
                break;
        }
    }
}
