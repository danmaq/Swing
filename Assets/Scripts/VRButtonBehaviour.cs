using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// VR モード変更ボタンの挙動定義。
/// </summary>
public sealed class VRButtonBehaviour : MonoBehaviour
{
	/// <summary>
	/// Google VR ビューアのインスタンス。
	/// </summary>
	public GvrViewer gvrViewer;

	/// <summary>
	/// ボタンが押下された際に呼び出されます。
	/// </summary>
	public void OnClick()
	{
		ChangeColor(gvrViewer != null && (gvrViewer.VRModeEnabled = !gvrViewer.VRModeEnabled));
	}

	/// <summary>
	/// Use this for initialization.
	/// </summary>
	private void Start()
	{
		ChangeColor(gvrViewer != null && gvrViewer.VRModeEnabled);
	}

	/// <summary>
	/// ボタンの色を変更します。
	/// </summary>
	/// <param name="enabled">VR モードが有効である場合、<c>true</c>。</param>
	private void ChangeColor(bool enabled)
	{
		var image = GetComponent<Image>();
		if (image != null)
		{
			image.color = enabled ? Color.cyan : Color.white;
		}
	}
}
