using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class WaveShower : MonoBehaviour
{
    private MeshFilter mesh;
    
    private void Awake()
    {
        mesh = GetComponent<MeshFilter>();
    }

    void Update()
    {
        Vector3[] vertices = mesh.mesh.vertices;
        for(int i = 0; i< vertices.Length; i++)
        {
            vertices[i].y = Wave.instance.WaveHeight(transform.position.x + vertices[i].x);
        }
        mesh.mesh.vertices = vertices;
        mesh.mesh.RecalculateNormals();
    }
}
