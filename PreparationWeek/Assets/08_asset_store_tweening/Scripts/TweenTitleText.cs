using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTitleText : MonoBehaviour {

    TextMesh textMesh;

	void Start () {
        textMesh = GetComponent<TextMesh>();

        // Create tween objects
        Tween tweenMove = transform.DOMoveZ(-2f, 1f).SetEase(Ease.InExpo);
        Tween tweenOpacity = DOTween.To(() => textMesh.color, x => textMesh.color = x, new Color(1f, 1f, 1f, 1f), 1);

        // Launch tweens relative to each other
        Sequence seq = DOTween.Sequence();
        seq.Insert(0.5f, tweenOpacity);
        seq.Insert(1f, tweenMove);
    }

}
