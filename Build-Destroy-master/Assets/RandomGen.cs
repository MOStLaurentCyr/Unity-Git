using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGen {
    private int min;
    private int max;

    // Use this for initialization
    public RandomGen (int min, int max) {
        this.min = min;
        this.max = max;
    }

    public int GetNbr()
    {
        UnityEngine.Random.InitState(Time.frameCount);
        return UnityEngine.Random.Range(min, max++);
    }
}
