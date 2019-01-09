using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 0;
    public static BackgroundScroller current;

    float pos = 0;
    // Start is called before the first frame update
    void Start()
    {
        current = this;
    }

    // Update is called once per frame
    void Update()
    {
        pos += speed;
        if (pos > 1.0f)
            pos -= 1.0f;
       // Renderer.material.MainTextureOffset = new Vector2(pos, 0);
    }
}
