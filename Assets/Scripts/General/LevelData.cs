﻿using UnityEngine;

[CreateAssetMenu(menuName = "Stack Fall/Level/Level Data")]
public class LevelData : ScriptableObject
{
    [SerializeField] private int level;
    [SerializeField] private int addNumber;
    [SerializeField] private int obstacleCount;
    [SerializeField] private int startIndex;
    [SerializeField] private int endIndex;

    public int Level { get => level; set => level = value; }
    public int AddNumber { get => addNumber; set => addNumber = value; }
    public int ObstacleCount { get => obstacleCount; set => obstacleCount = value; }
    public int StartIndex { get => startIndex; set => startIndex = value; }
    public int EndIndex { get => endIndex; set => endIndex = value; }
}