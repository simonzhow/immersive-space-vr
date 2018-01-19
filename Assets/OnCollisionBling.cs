using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent( typeof( AudioSource ) )]
public class OnCollisionBling : MonoBehaviour {
	AudioSource audio;
	void Start() {
		audio = GetComponent<AudioSource>();
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.relativeVelocity.magnitude > 1) {
			audio.pitch = Random.Range (0.8f, 1.2f);
		}
		audio.Play();
	}
} 
