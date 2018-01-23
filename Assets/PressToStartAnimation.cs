using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem { 

	[RequireComponent( typeof( Interactable ) )]

	public class PressToStartAnimation : MonoBehaviour {

		public Animator anim;

		void Start () {
			anim.enabled = false;
		}

		void OnHandHoverBegin( Hand hand )    {
			this.GetComponent<Renderer> ().material.SetColor("_Color", Color.green);
		}

		void HandHoverUpdate( Hand hand )    {
			//Trigger got pressed
			if ( hand.GetStandardInteractionButton() )
			{    
				this.GetComponent<Renderer> ().material.SetColor("_Color", Color.red);
				anim.enabled = true;
			}
		}

		void OnHandHoverEnd( Hand hand )    {
			this.GetComponent<Renderer> ().material.SetColor("_Color", Color.blue);
		}
	}
}
