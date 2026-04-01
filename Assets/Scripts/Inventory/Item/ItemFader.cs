using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

// 一定要用在物品上，且物品必须有SpriteRenderer组件
[RequireComponent(typeof(SpriteRenderer))]
public class ItemFader : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// 物品透明度恢复原样
    /// </summary>
    public void FadeIn()
    {
        Color targetColor = new Color(1,1,1,1);
        spriteRenderer.DOColor(targetColor, Settings.fadeDuration);
    }
    /// <summary>
    /// 物品会变得完全不透明
    /// </summary>
    public void FadeOut()
    {
        Color targetColor = new Color(1, 1, 1, Settings.targetAlpha);
        spriteRenderer.DOColor(targetColor, Settings.fadeDuration);
    }
}
