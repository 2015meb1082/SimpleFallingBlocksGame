
using UnityEngine;

public static class Difficulty
{
    private static float secondsToMaxDifficulty = 60.0f;
    public static float GetDifficultyPercent() {
        
        float difficulty= Mathf.Clamp01((Time.timeSinceLevelLoad / secondsToMaxDifficulty));
        return difficulty;
    }
}
