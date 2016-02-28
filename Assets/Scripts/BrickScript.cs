using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour {

    public int Lives = 1;
    public int Points = 5;

    GameObject GC;

	// Use this for initialization
	void Start () {
        GC = GameObject.Find("GameController");    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "BALL")
        {
            if (GC != null)
            {
                GameController GCObject = GC.GetComponent<GameController>();

                GCObject.AddToPoints(Points);
            }

            Destroy(gameObject);
        }
    }
}
