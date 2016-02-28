using UnityEngine;
using System.Collections;

public class FenceScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void OnCollisionEnter(Collision other)
    {
        //Instantiate(brickParticle, transform.position, Quaternion.identity);
        //GM.instance.DestroyBrick();

        if (other.gameObject.tag == "BALL")
            Destroy(other.gameObject);
    }
}
