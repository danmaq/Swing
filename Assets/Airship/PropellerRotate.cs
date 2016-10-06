using UnityEngine;

public class PropellerRotate : MonoBehaviour
{
	// Update is called once per frame
	private void Update ()
	{
		transform.eulerAngles += new Vector3(0, 0, 10f);
	}
}
