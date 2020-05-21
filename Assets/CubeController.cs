using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    [SerializeField] private AudioSource seAudio = null;
    [SerializeField] private AudioClip blockSE = null;

    private float speed = -12;

    private float deadLine = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BlockTag" || collision.gameObject.tag == "GroundTag")
        {
            seAudio.PlayOneShot(blockSE);
        }
    }
}
