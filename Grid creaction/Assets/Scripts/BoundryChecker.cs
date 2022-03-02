using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundryChecker : MonoBehaviour
{

    public GameObject forward;
    public GameObject back;
    public GameObject left;
    public GameObject right;
    public bool forwardPlane = false;
    public bool backPlane = false;
    public bool leftPlane = false;
    public bool rightPlane = false;

    public float range = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ForwardCheck();
        BackCheck();
        LeftCheck();
        RightCheck();
    }
    private void ForwardCheck()
    {
        Vector3 direction = Vector3.down;
        Ray downRay = new Ray(forward.transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(forward.transform.position, transform.TransformDirection(direction * range), Color.red);
        if (Physics.Raycast(downRay, out RaycastHit hit, range))
        {
            if (hit.collider.CompareTag("Grid"))
            {
                Debug.Log("cube");
                forwardPlane = false;
            }
            else
            {
                Debug.Log("Hussain");
                forwardPlane = true;
            }


        }
    }
    private void BackCheck()
    {
        Vector3 direction = Vector3.down;
        Ray downRay = new Ray(back.transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(back.transform.position, transform.TransformDirection(direction * range), Color.red);
        if (Physics.Raycast(downRay, out RaycastHit hit, range))
        {
            if (hit.collider.CompareTag("Grid"))
            {
                Debug.Log("cube");
                backPlane = false;
            }
            else
            {
                Debug.Log("Plain");
                backPlane = true;
            }


        }
    }

    private void LeftCheck()
    {
        Vector3 direction = Vector3.down;
        Ray downRay = new Ray(left.transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(left.transform.position, transform.TransformDirection(direction * range), Color.red);
        if (Physics.Raycast(downRay, out RaycastHit hit, range))
        {
            if (hit.collider.CompareTag("Grid"))
            {
                Debug.Log("cube");
                leftPlane = false;
            }
            else
            {
                Debug.Log("Plain");
                leftPlane = true;
            }


        }
    }
    private void RightCheck()
    {
        Vector3 direction = Vector3.down;
        Ray downRay = new Ray(right.transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(right.transform.position, transform.TransformDirection(direction * range), Color.red);
        if (Physics.Raycast(downRay, out RaycastHit hit, range))
        {
            if (hit.collider.CompareTag("Grid"))
            {
                Debug.Log("cube");
                rightPlane = false;
            }
            else
            {
                Debug.Log("Plain");
                rightPlane = true;
            }


        }
    }
}
