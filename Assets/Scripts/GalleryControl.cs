using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryControl : MonoBehaviour
{
	//PSEUDO CODE: Declare(Create) a public variable for an array, Type: GameObject
	//FUNCTION: Can Populate(Initialize) in Inspector Box, change number of GameObjects in Array. 
	//and hold multiple Game Objects....
	public GameObject[] mecabrickItems;
	//PSEUDO CODE: Declare(Create) and Initialize a public variable for counting
	//FUNCTION: Starts at 0, used to access array items in sequence....
	public int current = 0;

    void Update()
    {
		//PSEUDO CODE: Check for Key input (RightArrow)
		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			//PSEUDO CODE: as long as there are still game objects in array, increase counter by one
			//FUNCTION: To move up the array
			if(current <= mecabrickItems.Length -1)
			{
				current++;
			}

			//PSEUDO CODE: if at the end of game objects, reset counter to go back to start of array
			//FUNCTION: to cycle the array
			if(current == mecabrickItems.Length)
			{
				current=0;
			}
		}
		//PSEUDO CODE: Check for Key input (LeftArrow)
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			//PSEUDO CODE: as long as there are still game objects in array, decrease counter by one
			//FUNCTION: To move down the array
			if(current >= 0)
			{
				current--;
			}
			//PSEUDO CODE: if at the beginning of game objects, reset counter to go back to end of array
			//FUNCTION: to cycle the array
			if(current == -1)
			{
				//TIP: Don't forget Arrays start at 0!
				current =  -1;
			}

		}

		//PSEUDO CODE: Print to Console log the vaue of the counter
		//FUNCTION: To check the keys work accurately
		Debug.Log("Current = "+current);

		//PSEUDO CODE: Using the counter, loop through the Array to turn the Game Objects on and off as needed
		//FUNCTION: This displays and hide the items as controlled by the keys
		//TIP: , Check if each array item matches the counter, Use the Renderer or MeshRenderer Component of GameObjects to display/hide as needed 
        for(int i =0; i<mecabrickItems.Length; i++)
		{
			if(i !=current)
            {
				mecabrickItems[i].SetActive(false);
            }
			else
            {
				mecabrickItems[current].SetActive(true);
            }
        }
	}
 }

