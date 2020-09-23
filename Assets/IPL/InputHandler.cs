using UnityEngine;

namespace IPL
{
    public class InputHandler : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump"))
                print("Jump");
            //afficher -1 si j'appuie à gauche, 0 si rien , 1 si à droite
            print(Input.GetAxis("Horizontal"));
        }
    }
}
