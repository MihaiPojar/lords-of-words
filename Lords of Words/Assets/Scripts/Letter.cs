using UnityEngine;
using System.Collections;

public class Letter : MonoBehaviour {

	private int SCALE = 40;

	private SpriteRenderer spriteRenderer;
	private bool dark;
	private Color originalColor;
	private Color darkColor;
	private int specialEffect;

	void Start () {
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		originalColor = new Color (1.0f, 1.0f, 1.0f, 1.0f);
		darkColor = new Color (0.3f, 0.3f, 0.3f, 1.0f);
		dark = false;
	}

	public void SetSpecialEffect(int effect) {
		specialEffect = effect;
	}

	void Update() {
		switch (specialEffect) {
		case 1:
			RotateLeft ();
			break;
		case 2:
			RotateRight ();
			break;
		case 3:
			MirrorHorizontally ();
			break;
		case 4:
			MirrorVertically ();
			break;
		case 5:
			MakeSmaller ();
			break;
		}
	}

	public void RotateLeft() {
		transform.Rotate (SCALE * Vector3.forward * Time.deltaTime);
	}

	public void RotateRight() {
		transform.Rotate (-SCALE * Vector3.forward * Time.deltaTime);
	}

	public void MirrorHorizontally() {
		transform.Rotate (SCALE * Vector3.right * Time.deltaTime);
	}

	public void MirrorVertically() {
		transform.Rotate (SCALE * Vector3.up * Time.deltaTime);
	}

	public void MakeSmaller() {
		transform.localScale = new Vector3 (0.2f, 0.2f, 1f);
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
