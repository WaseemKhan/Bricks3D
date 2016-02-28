using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Rigidbody Ball;
    public Text SpeedInfo;
    public Text PointInfo;

    int PointsWon = 0;

	// Use this for initialization
	void Start () {
        GenerateBall();
	}

    public void GenerateBall()
    {
        if (Ball != null)
        {
            Rigidbody BallInst = (Rigidbody)Instantiate(Ball, new Vector3(7.7f,0.6f,0), Quaternion.Euler(0, 270, 90));
            BallInst.AddForce(Vector3.left * 800);
        }
    }
    
    // Update is called once per frame
	void Update () {
        if (Ball!=null)
        {
            SpeedInfo.text = "Ball Speed: " + Ball.velocity.magnitude.ToString();
        }

        PointInfo.text = "Points: " + PointsWon.ToString();
	}

    public void AddToPoints(int Point)
    {
        PointsWon += Point;
    }
}
