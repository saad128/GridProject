using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSelected : MonoBehaviour
{

    public Camera pointedCamera;
    public float speed;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("key down");
            Ray ray = pointedCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                Debug.Log("raycast hit");
                if(hitInfo.collider.gameObject.CompareTag("Cells"))
                {
                    Debug.Log("move player");
                    var temp= hitInfo.collider.gameObject.GetComponent<TargetCell>().placeHolder;
                    transform.position = temp.position;
                }
            }
        }
    }
}
