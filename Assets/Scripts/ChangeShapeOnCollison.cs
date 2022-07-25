using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShapeOnCollison : MonoBehaviour
{
    Mesh mesh;

    private void Start()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        this.mesh = Instantiate(obj.GetComponent<MeshFilter>().mesh);
        Destroy(obj);
    }


    private void OnCollisionEnter()
    {


        var meshFilter = GetComponent<MeshFilter>();

        if (this.mesh)
        {
            meshFilter.mesh = this.mesh;
        }
        
    }
}
