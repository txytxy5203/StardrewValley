using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class SwitchBounds : MonoBehaviour
{
    // TODO 切换场景的时候调用
    private void Start()
    {
        SwitchConfineShape();
    }
    public void SwitchConfineShape()
    {

        PolygonCollider2D confinerShape = GameObject.FindGameObjectWithTag("BoundsConfiner")
                                        .GetComponent<PolygonCollider2D>();
        CinemachineConfiner confiner = GetComponent<CinemachineConfiner>();
        confiner.m_BoundingShape2D = confinerShape;

        confiner.InvalidatePathCache();
    }
    
}
