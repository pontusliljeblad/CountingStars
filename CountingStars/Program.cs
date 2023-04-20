/* You will be given five maps of the starry sky,
 * encoded so that blackness is a dot, and light
 * is an asterisk.
 * Your job is to count the amount of stars in
 * each map.
 * Take care though - the images are blurry, and
 * a single star can occupy several cells in
 * the map.
 *
 * Note - only cardinal directions should be considered. Diagonal joints are separate stars
 *
 * You are free to read anything in this file.
 * When you understand how the test is performed,
 * edit the file StarCounter.cs until the program
 * no longer crashes.
 *
 * Good Luck!
 */

using CountingStars;

foreach(var answer in Maps.Answers)
{
    if (StarCounter.Count(answer.Key) != answer.Value)
        throw new Exception("Please try again!");
}

Console.CursorVisible = false;
Console.Write("You made it! I knew you could :D");
Console.ReadKey(true);
