using UnityEngine;

/// <summary>
/// プロペラを回転させるためのビヘイビア。
/// </summary>
public sealed class PropellerRotate : MonoBehaviour
{
	/// <summary>
	/// Update is called once per frame.
	/// </summary>
	private void Update()
	{
		transform.localEulerAngles += Vector3.forward * 15f;
	}
}
