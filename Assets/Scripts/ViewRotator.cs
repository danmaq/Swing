using UnityEngine;

/// <summary>
/// 飛行船本体を回転させるためのビヘイビア。
/// </summary>
public sealed class ViewRotator : MonoBehaviour
{
	/// <summary>
	/// Update is called once per frame.
	/// </summary>
	private void Update()
	{
		transform.localEulerAngles += Vector3.up * 0.01f;
	}
}
