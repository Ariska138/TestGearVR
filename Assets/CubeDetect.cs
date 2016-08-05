using UnityEngine;
using UnityEngine.VR;
public class CubeDetect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    bool isCubeBig = false;

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) 
        {

          
                isCubeBig = !isCubeBig;
                if (isCubeBig)
                {
                    transform.localScale = new Vector3(3, 3, 3);
                }
                else
                {
                    transform.localScale = new Vector3(1, 1, 1);
                }
            

        }

        if (Input.GetButtonDown("Cancel"))
        {
            // ketika menekan tombol back
            Application.Quit();
        }
    }
}
