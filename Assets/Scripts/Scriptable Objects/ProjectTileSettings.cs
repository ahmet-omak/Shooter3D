﻿using UnityEngine;

[CreateAssetMenu(menuName = "TopDown Shooter/Project Tile Settings")]
public class ProjectTileSettings : ScriptableObject
{
    [Header("Bullet Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    [SerializeField] private float refreshRate;

    public float Speed { get => speed; }
    public float Damage { get => damage; }
    public float RefreshRate { get => refreshRate; }
}