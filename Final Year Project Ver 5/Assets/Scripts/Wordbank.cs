using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Wordbank : MonoBehaviour
{

    private List<string> originalWords = new List<string>()
    {
        "Pancakes", "Cupcakes", "Delicious","Sushi", "Milk", "Woah", "Ambrosial", "Grub" , "Umami" , "Gustatory" , "Piehole" , "Rice" , "Pasta", "Sweet" , "Savoury" , "Oats" , "Dessert",
        "Cheese", "Eggs", "Cereal", "Gummy" , "English Muffins", "Nice", "Tasty", "Candy", "Avocado", "Fish", "Watermelon", "Apple", "Scrumptious", "Olive Oil", "Yoghurt", "Bitter", "Fruits",
        "Vegetables", "White Bread", "Cookies", "Crackers", "Doughnut", "Pretzel", "Baguette", "Croissant", "Cake", "Waffle", "Noodles", "Dumpling"

    };

    private List<string> workingWords = new List<string>();


    private void Awake()
    {
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
        ConvertToLowercase(workingWords);
    }

    private void Shuffle(List<string> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random];
            list[random] = temporary;
        }

    }

    private void ConvertToLowercase(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
            list[i] = list[i].ToLower();
    }
    
    public string GetWord()
    {
        string newWord = string.Empty;

        if(workingWords.Count !=0)
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        } 
        return newWord;
    }

}
