﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour, IEntity
{
    [SerializeField] private new Tag tag;

    Tag IEntity.tag { get => tag; set => tag = value; }
}
