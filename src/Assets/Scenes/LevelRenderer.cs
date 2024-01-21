using UnityEngine;

public class LevelRenderer : MonoBehaviour
{

    public Texture2D map;
    public ColourToPrefab[] colourMap;

    // Start is called before the first frame update
    void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel() {
        for (int x = 0; x < map.width; x++) {
            for (int y = 0; y < map.width; y++) {
                GenerateTile(x, y);
            }
        }
    }

    void GenerateTile(int x, int y) {
        Color pixelColour = map.GetPixel(x, y);

        if (pixelColour.a == 0) {
            return;
        }

        Debug.Log(pixelColour);
        foreach (ColourToPrefab mapping in colourMap) {
            if (mapping.colour.Equals(pixelColour)) {
                Vector2 position = new Vector2(x, y);
                Instantiate(mapping.prefab, position, Quaternion.identity, transform);
            }
        }
    }
}
