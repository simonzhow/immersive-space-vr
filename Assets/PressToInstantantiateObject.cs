using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem {
	[RequireComponent( typeof( Interactable ) )]
	public class PressToInstantantiateObject : MonoBehaviour {
		float timer = 0;
		float waitTime = 0.3f;
		public GameObject objectToInstantiate;
		void OnHandHoverBegin( Hand hand )    {
			this.GetComponent<Renderer> ().material.SetColor("_Color", Color.green);
		}
		void HandHoverUpdate( Hand hand )    {
			//Trigger got pressed
			if ( hand.GetStandardInteractionButton() )
			{    
				this.GetComponent<Renderer> ().material.SetColor("_Color", Color.red);
				if (timer >= waitTime) {
					Instantiate (objectToInstantiate, this.transform.position + Vector3.up, Quaternion.identity);
					timer = 0;
				}
			}
			timer += Time.deltaTime;
		}
		void OnHandHoverEnd( Hand hand )    {
			this.GetComponent<Renderer> ().material.SetColor("_Color", Color.blue);
		}
	}
} 