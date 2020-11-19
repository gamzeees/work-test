using UnityEngine;

public class Task2 : MonoBehaviour
{
    [SerializeField]
    private bool onEnter = false;
    [SerializeField]
    private Color[] colors = new Color[] { Color.red, Color.blue };
    [SerializeField]
    private bool isRandom = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (onEnter) SwapColors();
    }

    private void OnTriggerExit(Collider other)
    {
        if (!onEnter) SwapColors();
    }

    private void SwapColors()
    {
        if (isRandom) RandomSwapColors();
        else LoopSwapColors();
    }

    /// <summary>
    /// This method swaps colors in array
    /// </summary>
    private void LoopSwapColors()
    {
        // Loop algorithm
        Color color = colors[0];
        for (int i = 0; i < colors.Length - 1; i++)
        {
            colors[i] = colors[i + 1];
        }
        colors[colors.Length - 1] = color;
    }

    /// <summary>
    /// This method sets a random color between two colors to first color in the array
    /// </summary>
    private void RandomSwapColors()
    {
        // Get a random color between two colors
        // Interpolate between two colors with a random number
        Color color = Color.Lerp(colors[0], colors[1], Random.Range(0f, 1f));
        colors[0] = color;
    }
}
