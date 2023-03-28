using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public TileState state { get; private set; }
    public TileCell cell { get; private set; }
    public int number { get; private set; }

    private Image background;
    private TextMeshProUGUI text;

    void Awake()
    {
        background = GetComponent<Image>();
        text = GetComponentInChildren<TextMeshProUGUI>();
    }
    public void SetState(TileState state, int number)
    {
        this.state = state;
        this.number = number;

        background.color = Color.black;
        text.color = Color.white;
        text.text = number.ToString();
    }
}
