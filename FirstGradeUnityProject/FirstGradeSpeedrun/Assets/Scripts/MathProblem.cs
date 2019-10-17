using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Eddie Brazier
 *Personal Project: Are you faster than a first grader?
 *10/3/2019
 */

public class MathProblem : MonoBehaviour
{
    //field for the text component of the current gameObject
    private Text problemText;

    //field for problem solution
    public int problemSolution;

    // Start is called before the first frame update
    void Start()
    {
        //get the text component of the game object
        problemText = gameObject.GetComponent<Text>();

        //roll a random number to determine if the problem will be addition or subtraction
        int problemInt = Random.Range(0, 2);

        if (problemInt == 0)
        {
            problemText.text = AdditionProblem();
        }
        else
        {
            problemText.text = SubtractionProblem();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// method that creates a random addition problem to solve 
    /// </summary>
    /// <returns> the string that will be displayed for the problem</returns>
    private string AdditionProblem()
    {
        //random numbers to generate addition string
        int numOne = Random.Range(0, 10);
        int numTwo = Random.Range(0, 10);

        //create string for the math problem
        string addProblem = numOne + " + " + numTwo + " = ";

        //get the solution to the problem
        AdditionSolution(numOne, numTwo);

        return addProblem;
    }

    /// <summary>
    /// method that sets this problem's answer value based on the numbers in the problem
    /// </summary>
    /// <param name="numOne"> the first number of the problem </param>
    /// <param name="numTwo"> the second number of the problem </param>
    private void AdditionSolution(int numOne, int numTwo)
    {
        //set problem solution to the sum of passed-in numbers
        problemSolution = numOne + numTwo;
    }

    /// <summary>
    /// method that creates a random subtraction problem to solve 
    /// </summary>
    /// <returns> the string that will be displayed for the problem</returns>
    private string SubtractionProblem()
    {
        //random numbers to generate addition string
        int numOne = Random.Range(0, 10);
        int numTwo = Random.Range(0, 10);

        //create string for the math problem
        string addProblem = numOne + " - " + numTwo + " = ";

        //get the solution to the problem
        SubtractionSolution(numOne, numTwo);

        return addProblem;
    }

    /// <summary>
    /// method that sets this problem's answer value based on the numbers in the problem
    /// </summary>
    /// <param name="numOne"> the first number of the problem </param>
    /// <param name="numTwo"> the second number of the problem </param>
    private void SubtractionSolution(int numOne, int numTwo)
    {
        //set problem solution to the sum of passed-in numbers
        problemSolution = numOne - numTwo;
    }
}
