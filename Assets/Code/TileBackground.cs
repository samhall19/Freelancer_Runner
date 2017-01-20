using UnityEngine;
using System.Collections;

public class TileBackground : MonoBehaviour {

    public int textureSize = 32;

	// Use this for initialization
	void Start ()
    {
        float newWidth = Mathf.Ceil(Screen.width / (textureSize * CameraThing.scale));
        float newHeight = Mathf.Ceil(Screen.height / (textureSize * CameraThing.scale));

        transform.localScale = new Vector3 (newWidth * textureSize, newHeight * textureSize, 1);

        GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidth, newHeight, 1);

     }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
