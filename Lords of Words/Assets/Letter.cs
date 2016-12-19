using UnityEngine;
using System.Collections;

public class Letter : MonoBehaviour {

	private SpriteRenderer spriteRenderer;
	private bool dark;
	private Color originalColor;
	private Color darkColor;

	void Start () {
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		originalColor = new Color (1.0f, 1.0f, 1.0f, 1.0f);
		darkColor = new Color (0.3f, 0.3f, 0.3f, 1.0f);
		dark = false;
	}

	public void SetArtworkSprite(Sprite art)
	{
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = art;
	}

	public void Brighten() {
		if (dark) {
			spriteRenderer.color = originalColor;
			dark = false;
		}
	}

	public void Darken() {
		if (!dark) {
			spriteRenderer.color = darkColor;
			dark = true;
		}
	}
}
