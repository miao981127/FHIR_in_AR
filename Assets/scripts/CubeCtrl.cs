using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeCtrl : MonoBehaviour
{
    public Material red;
    public Material lightRed;
    private MeshRenderer myMesh;

    // Start is called before the first frame update
    void Start()
    {
        myMesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        myMesh.material = lightRed;
    }

    private void OnMouseExit()
    {
        myMesh.material = red;
    }

    private void OnMouseDown()
    {
        request.showImage = true;
    }
}
