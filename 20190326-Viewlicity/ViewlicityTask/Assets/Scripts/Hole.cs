﻿using UnityEngine;

public class Hole : MonoBehaviour
{
    public float[] Position { get; private set; }
    public bool IsDisplayed { get; set; }

    public Hole(bool isDeletable, int nr = -1)
    {
        if (isDeletable)
        {
            this.Position = GetRandomPosition();
        }
        else {
            if (nr >= 0)
            {
                this.Position = new float[] { INITIAL_HOLE_POSITIONS[nr, 0], INITIAL_HOLE_POSITIONS[nr, 1] };
            }
        }

        this.IsDisplayed = true;
    }

    // TODO: make unrepetitive positions
    private float[] GetRandomPosition()
    {
        float x = Random.Range(MIN_VALUE, MAX_VALUE);
        float y = Random.Range(MIN_VALUE, MAX_VALUE);
        float[] position = new float[] { x, y};
        return position;
    }

    private static float MAX_VALUE = (float)100.0;
    private static float MIN_VALUE = (float)1.0;
    private static float[,] INITIAL_HOLE_POSITIONS = new float[3, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 } };
}
