using UnityEngine;
using System.Collections;

public class BrickGenerator : MonoBehaviour {

    public GameObject BrickPrefab;

	// Use this for initialization
	void Start () {
	    for (int row=0;row<5;row++)
        {
            for(int col=-6;col<=6;col++)
            {
                Instantiate(BrickPrefab, new Vector3((row*-1.15f), 0, (col*1.15f)), Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
