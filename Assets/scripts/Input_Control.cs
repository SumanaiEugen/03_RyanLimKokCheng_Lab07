using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Control : MonoBehaviour
{
    public GameObject leftCube;
    public GameObject rightCube;
    public GameObject upCube;
    public GameObject downCube;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        //up arrow
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            upCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            upCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
        //W key
        if (Input.GetKeyDown(KeyCode.W))
        {
            upCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            upCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
        //down arrow
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            downCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
        //S key
        if (Input.GetKeyDown(KeyCode.S))
        {
            downCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            downCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
        //left arrow
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
        //A key
        if (Input.GetKeyDown(KeyCode.A))
        {
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
        //right arrow
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
        //D key
        if (Input.GetKeyDown(KeyCode.D))
        {
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }
}
