using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class BatController : MonoBehaviour {

    Vector3 playerPos;
    Vector3 origPos;
    
    Quaternion playerRotation;
    Quaternion origRotation;

    float Speed = 0.15f;
    
    public Text BatInfo;

	// Use this for initialization
	void Start () {

        playerPos = transform.position;
        origPos = playerPos;

        playerRotation = transform.rotation;
        origRotation = playerRotation;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float BatSpeed = CrossPlatformInputManager.GetAxis("Horizontal") * Speed;
        float BatDir = CrossPlatformInputManager.GetAxis("Vertical") * Speed;

        BatInfo.text = "Bat Speed: " + BatSpeed + "/" + BatDir;

        if (BatSpeed != 0)
        {
            float zPos = transform.position.z + BatSpeed;

            playerPos = new Vector3(9f, 0.6f, Mathf.Clamp(zPos, -7f, 7f));

            transform.position = playerPos;
        }
        else
            transform.position = origPos;

        if (BatDir != 0)
        {
            float yRot = transform.rotation.eulerAngles.y + BatDir;
            
            playerRotation = Quaternion.Euler(0, Mathf.Clamp(yRot, 245, 295), 90);

            transform.rotation = playerRotation;
        }
        else
            transform.rotation = origRotation;
    }

    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "BALL")
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

            rb.AddForce(Vector3.left * 100);
        }
    }
}
