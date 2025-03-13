using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{
    public Text[] texts;
    public Image background;
    public Image cursorGradient;
    public Palette[] palettes;

    [System.Serializable]
    public class Palette
    {
        public Color textColor;
        public Color bgColor;
        public Color gradientColor;
    }

    private void Start()
    {
        int paletteIndex = Random.Range(0, palettes.Length);
        SetPalette(paletteIndex);
    }

    private void SetPalette(int paletteIndex)
    {
        Palette palette = palettes[paletteIndex];

        foreach (Text text in texts)
        {
            text.color = palette.textColor;
        }

        background.color = palette.bgColor;
        cursorGradient.color = palette.gradientColor;
    }
}
