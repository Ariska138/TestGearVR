using UnityEngine;
using System.Collections;

public class TextInfo : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Mouse X") < -0.5f)
        {
            //Code for action on mouse moving left
            transform.GetComponent<TextMesh>().text = ("swip left");
        }
        if (Input.GetAxis("Mouse X") > 0.5f)
        {
            //Code for action on mouse moving right
           transform.GetComponent<TextMesh>().text = ("swip right");
        }

        if (Input.GetAxis("Mouse Y") < -0.5f)
        {
            //Code for action on mouse moving left
            transform.GetComponent<TextMesh>().text = ("swip down");
        }
        if (Input.GetAxis("Mouse Y") > 0.5f)
        {
            //Code for action on mouse moving right
            transform.GetComponent<TextMesh>().text = ("swip up");
        }
        
        

    }
}
