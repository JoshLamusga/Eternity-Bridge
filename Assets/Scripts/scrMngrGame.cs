using UnityEngine;
using System.Collections;

/// <summary>
/// A persistent class to execute global code. Ensure that the game object it is attached to
/// is in the first scene.
/// </summary>
public class scrMngrGame : MonoBehaviour {
	/// <summary>
	/// Allows the object to persist across scenes.
	/// </summary>
	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}
}
