using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public static Wave instance;

    public float amp = 1f;
    public float len = 2f;
    public float speed = 1f;
    public float offsetWaves = 0f;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }

    private void Update()
    {
        offsetWaves += Time.deltaTime * speed;
    }

    public float WaveHeight(float _x)
    {
        return amp * Mathf.Sin(_x / len + offsetWaves);
    }
}
