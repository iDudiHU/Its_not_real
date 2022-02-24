using System.Collections;
using UnityEngine;

namespace SojaExiles

{

	public class Drawer_Pull_X : MonoBehaviour
	{

		public Animator pull_01;
		public bool open;
		public Transform Player;
		public Activator _Activator;


		void Start()
		{
			open = false;
			_Activator = GetComponent<Activator>();
		}

		void Update()
		{
			{
				float dist = Vector3.Distance(Player.position, transform.position);
				if (dist < 4)
				{
					int i = 0;
					if (open == false && i < 1)
					{
						_Activator.Activate();
						StartCoroutine(opening());
						i++;
					}
					else
					{
						return;
					}

				}

			}

		}

		IEnumerator opening()
		{
			print("you are opening the door");
			pull_01.Play("openpull_01");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			pull_01.Play("closepush_01");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}