using UnityEngine;
using System.Collections;

public class AguacateCollider : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private AudioSource[] _audioSources;
    private AudioSource _friendSound;
    private AudioSource _enemySound;

    //PUBLIC INSTANCE VARIABLES
    public GameController gameContoller;

	// Use this for initialization
	void Start () {
        // Initialize the audioSources array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._enemySound = this._audioSources[1];
        this._friendSound = this._audioSources[2];
        

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Enables Player Collission with friends and enemies
    public void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Friend"))
        {
            this._friendSound.Play();
            this.gameContoller.ScoreValue += 100;

        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            this._enemySound.Play();
            this.gameContoller.LivesValue -= 1;

        }
    }

}

