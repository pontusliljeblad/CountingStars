﻿namespace CountingStars;

public static class Maps
{
    /// <summary>
    /// Map with 2 stars
    /// </summary>
    public static string[] Map1 =
    {
        "....................",
        "....................",
        "....*...............",
        "....................",
        "....................",
        "....................",
        "....................",
        ".............**.....",
        "..............*.....",
        "...................."
    };

    /// <summary>
    /// Map with 4 stars
    /// </summary>
    public static string[] Map2 =
    {
        "...****.............",
        "....**...*..........",
        "....................",
        ".......**...........",
        "......**............",
        "....................",
        "....................",
        "...*................",
        "....................",
        "...................."
    };

    /// <summary>
    /// Map with 5 stars
    /// </summary>
    public static string[] Map3 =
    {
        "....................",
        "...............**...",
        ".....*.........**...",
        "...*****............",
        "..*******......**...",
        "...*****............",
        ".....*..............",
        "....................",
        ".............*.**...",
        "...................."
    };

    /// <summary>
    /// Map with 3 stars
    /// </summary>
    public static string[] Map4 =
    {
        "....................",
        "..*.................",
        "..*.....*............",
        "........*...........",
        "....................",
        "....................",
        "....................",
        "........*...........",
        "........*...........",
        "...................."
    };

    /// <summary>
    /// Map with 5 stars
    /// </summary>
    public static string[] Map5 =
    {
        "....................",
        "...*................",
        "...*..**............",
        "....................",
        ".....*..............",
        "....................",
        "....................",
        "...................*",
        "....................",
        "*..................."
    };

    public static Dictionary<string[], int> Answers = new()
    {
        [Map1] = 2,
        [Map2] = 4,
        [Map3] = 5,
        [Map4] = 3,
        [Map5] = 5
    };
}