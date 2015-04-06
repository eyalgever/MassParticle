﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[AddComponentMenu("GPUParticle/CapsuleCollider")]
public class MPGPCapsuleCollider : MPGPColliderBase
{
    public enum Direction
    {
        X, Y, Z
    }

    public float m_radius = 0.5f;
    public float m_height = 2.0f;
    public Direction m_direction = Direction.Y;
    MPGPCapsuleColliderData m_collider_data;

    public override void ActualUpdate()
    {
        MPGPImpl.BuildCapsuleCollider(ref m_collider_data, m_trans, m_radius, m_height, (int)m_direction, m_id);
        EachTargets((t) => { t.AddCapsuleCollider(ref m_collider_data); });
    }

    void OnDrawGizmos()
    {
    }
}
