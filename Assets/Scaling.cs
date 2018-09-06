using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

        // Widen the object by 0.1
        transform.localScale += new Vector3(0.1F, .1f, 0);

    }
}
