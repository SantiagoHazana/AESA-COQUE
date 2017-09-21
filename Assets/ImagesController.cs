using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImagesController : MonoBehaviour{
	public Sprite[] imagesToLoop;
	public int loopingTime = 20;
	public bool showImages = true;

	private Image image;
	private int imagesCount;

	void Start () {
		image = GetComponentInChildren<Image>();
		StartCoroutine(UpdateImages());
	}

	IEnumerator UpdateImages() {
		if(!showImages) yield return null;
		image.sprite = imagesToLoop[imagesCount];
		image.preserveAspect = true;
		image.gameObject.SetActive(true);
		yield return new WaitForSeconds(loopingTime);
		image.gameObject.SetActive(false);
		imagesCount++;
		
		if (imagesCount == imagesToLoop.Length)
			imagesCount = 0;
		yield return new WaitForSeconds(loopingTime);
		StartCoroutine(UpdateImages());
	}
}
