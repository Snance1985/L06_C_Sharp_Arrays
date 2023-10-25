//ARRAY
// Declare and Initialize an array with a size of 5, with no initial values
int[] array = new int[5];

// Declare and assign elements at the same time
int[] array2 = new int[5] { 1, 2, 3, 4, 5 };

// Initialize with 5 elements, indicating the size of the array
int[] array3 = new int[] { 1, 2, 3, 4, 5 };

// Another way to initialize an array with an implicit size
int[] array4 = { 1, 2, 3, 4, 5 };

// Declare and initialize the array separately
int[] array5;
array5 = new int[] { 1, 2, 3, 4, 5 };


//_________________________________________________________________
//ACCESSING ARRAY ELEMENTS
// Create and initialize a string array
// string[] nameList = { "Bob", "Will", "Joye", "Vali" };

// // Console.WriteLine(nameList[0]);
// // Console.WriteLine(nameList[3]);

// // Console.WriteLine(nameList[1]);
// // nameList[1] = "William";
// // Console.WriteLine(nameList[1]);

// //TRAVERSING AN ARRAY

// for (int idx = 0; idx < nameList.Length; idx++) {
//     nameList[idx] = nameList[idx] + " - Employee";
//     Console.WriteLine(nameList[idx]);
// }


//_________________________________________________________________
//FOREACH LOOP
// string[] nameList = { "Bob", "Will", "Joye", "Vali" };

// for (int idx = 0; idx < nameList.Length; idx++) {
//     nameList[idx] = nameList[idx] + " - Employee";
// }

// foreach (string name in nameList) {
//     Console.WriteLine(name);
// }


//_________________________________________________________________
//INDEXOF () METHOD
int foundIndex = Array.IndexOf(nameList, "Will");

if (foundIndex != -1) {
    Console.WriteLine("Found Will at index " + foundIndex);
} else {
    Console.WriteLine("Was not able to find Will");
}


//_________________________________________________________________
//SORT () METHOD
Array.Sort (nameList);

foreach (string name in nameList)
{
    Console.WriteLine(name);
}


//_________________________________________________________________
//MULTIDIMENSIONAL ARRAYS
string[,] dreamData = new string[4,2]{
    {"Will", "Rocket Scientist"}, 
    {"Bob", "Chef"},
    {"Joye", "Astronaut"}, 
    {"Vali", "Preacher"}
};
//FOREACH MULTIDIMENSIONAL ARRAY EXAMPLE
foreach (string item in dreamData){
    Console.WriteLine(item);
}
//FOR LOOP MULTIDIMENSIONAL ARRAY EXAMPLE
for (int row = 0; row < 4; row++)
{
    for (int col = 0; col < 2; col++)
    {
        Console.Write(dreamData[row,col] + " | ");
    }
    Console.WriteLine();
}


//_________________________________________________________________
//LISTS METHODS
List<string> nameList = new List<string>();

//ADD()
nameList.Add("Will");
nameList.Add("Ivan");
nameList.Add("Ben");
nameList.Add("Jan");

//ACCESSING LIST ELEMENTS
Console.WriteLine(nameList[1]);

//FINDING THE LENGTH OF A LIST (COUNT)
Console.WriteLine("Size of the List: " + nameList.Count);

//TAVERSING A LIST
//FOR LOOP TRAVERSE
for (int i = 0; i < nameList.Count; i++) {
    nameList[i] += " - Full-Stack";
}
//FOREACH LOOP TRAVERSE
foreach (string name in nameList) {
    Console.WriteLine(name);
}

//INDEX OF () METHOD
int foundIndex = nameList.IndexOf("Will");
if (foundIndex != -1) {
    Console.WriteLine("Found Will at index " + foundIndex);
} else {
    Console.WriteLine("Was not able to find Will");
}

//CONTAINS () METHOD
if (nameList.Contains("Jan")) {
    Console.WriteLine("The list contains Jan");
} else {
    Console.WriteLine("This list does not contain Jan");
}

if (nameList.Contains("Wade")) {
    Console.WriteLine("The list contains Wade");
} else {
    Console.WriteLine("This list does not contain Wade");
}

//REMOVING ELEMENTS FROM THE LIST

// Print the elements
foreach (string name in nameList)
{
    Console.WriteLine(name);
}

// Removing the element matching "Will"
Console.WriteLine("\nRemoving Will...\n");
nameList.Remove("Will");

// Loop to print the elements
foreach (string name in nameList)
{
    Console.WriteLine(name);
}

//INSERT () METHOD
foreach (string name in nameList)
{
    Console.WriteLine(name);
}

Console.WriteLine("\nInsert new item\n");
nameList.Insert(0, "Jamie");

foreach (string name in nameList) {
    Console.WriteLine(name);
}

//LISTSORT () METHOD
nameList.Sort();

foreach (string name in nameList) {
    Console.WriteLine(name);
}


//_________________________________________________________________
//DECLARING ARRAY LISTS
ArrayList arrList = new ArrayList();

//ADDING ELEMENTS TO ARRAYLISTS
var arrList = new ArrayList();
arrList.Add(1);
arrList.Add("Bob");
arrList.Add(true);
arrList.Add(3.14);
arrList.Add(null);

using System.Collections;

var arrList = new ArrayList();
arrList.Add(1);
arrList.Add("Fluffy");
arrList.Add(true);
arrList.Add(3.14);
arrList.Add(null);

//ACCESSING AN ARRAYLIST ELEMENT
// Using explicit casting
Console.WriteLine((string?) arrList[1]);

// Using `var`
var item = arrList[1];
Console.WriteLine(item);

//FINDING THE LENGTH OF THE ARRAYLIST
Console.WriteLine("Size of the ArrayList: " + arrList.Count);

//TRAVERSING AN ARRAYLIST
//FOR LOOP
for (int i = 0; i < arrList.Count; i++) {
    Console.WriteLine(arrList[i]);
}
//FOREACH LOOP
foreach (var element in arrList) {
    Console.WriteLine(element);
}
