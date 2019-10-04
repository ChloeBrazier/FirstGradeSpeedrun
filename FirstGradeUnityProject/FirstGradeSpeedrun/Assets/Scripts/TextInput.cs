using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Eddie Brazier
 *Personal Project: Are you faster than a first grader?
 *10/3/2019
 */

public class TextInput : MonoBehaviour
{
    //field for the textinput ui component of the GameObject
    private InputField mathInput;

    //field for the string being held in the input field and the int to parse it to
    private string inputString;
    private int answerInt;


    // Start is called before the first frame update
    void Start()
    {
        //get text input component
        mathInput = gameObject.GetComponent<InputField>();

        //
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
