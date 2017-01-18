using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

    // public AudioSource clickAudio;
    private AudioSource audioSource;
    public AudioClip scored;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("RollerBall"))

        {
            Debug.Log("start");
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = scored;
            audioSource.Play();
            Debug.Log("start");
        }
           // clickAudio.Play();



    }
    // Update is called once per frame
    void Update () {

        transform.Rotate(new Vector3(15, 30, 45) *Time.deltaTime);
	}
}
