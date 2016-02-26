using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Block : MonoBehaviour {

    public Text score;

	// Use this for initialization
	void Start () {
	}

    void FixedUpdate()
    {
        Vector2 p = transform.position;
        p.x += Input.GetAxis("Mouse X");
        p.y += Input.GetAxis("Mouse Y");
        Pitpex.AddScore((int)(p - (Vector2)transform.position).magnitude);
        score.text = Pitpex.GetScore().ToString();
        transform.position = p;
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void GameOver()
    {
        Pitpex.GameOver();
    }
}
