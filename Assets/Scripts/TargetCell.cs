using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCell : MonoBehaviour
{
    private Renderer rendererCell;
    public Transform placeHolder;
    // Start is called before the first frame update
    void Start()
    {
        rendererCell = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        rendererCell.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        rendererCell.material.color = Color.white;
    }
}
