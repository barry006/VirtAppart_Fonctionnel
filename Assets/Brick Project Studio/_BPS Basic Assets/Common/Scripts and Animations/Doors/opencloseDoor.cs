using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public bool open;
		public Transform Player;

		public bool b = true;
		public bool b2 = true;


		void Start()
		{
			
			open = false;
		}
		/*
		 void Update()
		{
			if (Player)
			{
				Debug.Log("wazaaa");
				float dist = Vector3.Distance(Player.position, transform.position);
				Debug.Log(dist);
				if (dist < 6 && open == false)
				{
					StartCoroutine(opening());
				}
				else if (dist > 6 && open == true)
				{
					StartCoroutine(closing());
				}
			}
		}
		*/

		public void OpenCLoseDoors()
        {

			if (b2)
			{
				if (b)
				{
					b2 = false;
					StartCoroutine(opening());
					b = !b;
				}
				else
				{
					b2 = false;
					StartCoroutine(closing());
					b = !b;
				}

			}
		}




		IEnumerator opening()
		{
			print("you are opening the door");
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(.5f);
			b2 = true;

		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.5f);
			b2 = true;


		}


	}
}