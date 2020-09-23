using UnityEngine;
using UnityEngine.SceneManagement;

public class TestAdditiveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Load", 1f);
    }

    void Load()
    {
        print("loading");
        SceneManager.LoadScene("Hello World");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
