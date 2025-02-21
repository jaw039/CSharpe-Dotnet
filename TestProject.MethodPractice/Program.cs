// There are currently three visiting schools
    // School A has six visiting groups (the default number)
    // School B has three visiting groups
    // School C has two visiting groups

// For each visiting school, perform the following tasks
    // Randomize the animals
    // Assign the animals to the correct number of groups
    // Print the school name
    // Print the animal groups


using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6) 
{
    RandomizeAnimals(); 
    string[,] group1 = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group1);
}

void RandomizeAnimals() 
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length); // generates a random integer between two values; first parameters; first parameters minimum value; second parameters maximum value 

        // Swap elements at positions i and r
        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

// [groups, pettingZoo.Length/groups] to define the array size. 
// groups represents the number of animal groups you want to create. 
// pettingZoo.Length/groups reflects how many animals are assigned to each group. 
// For example, since pettingZoo is a fixed array of 18 elements, the 2D array size for School A is [6,3].
string[,] AssignGroup(int groups = 6 ) 
{
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;

    // the outer for loop cycles through each group
    for (int i = 0; i < groups; i++)
    {
        // The inner for loop cycles for the number of animals the group should contain
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = pettingZoo[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i,j]}  ");
        }
        Console.WriteLine();
    }
}