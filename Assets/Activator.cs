using UnityEngine;

public class Activator : MonoBehaviour
{
	public Transform oToActivate;

	public void Activate()
	{
		oToActivate.gameObject.SetActive(true);
	}

}
