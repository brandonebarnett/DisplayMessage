/* Write a program that continuously asks the user to enter different names,
 * until the user presses Enter (with no name).  Depending on the number of
   names provided display a message based on the following pattern:

    - No names entered => Display Nothing
    - 1 name entered => Display [name] likes your post.
    - 2 names entered => Display [name] and [name] like your post.
    - 3 or more names entered => Display [name], [name] and [numberOfOthers] like your post.*/

string userInput = " ";
var names = new List<string>();

while (!string.IsNullOrEmpty(userInput))
{
    Console.WriteLine("Please enter a name and press Enter.");
    userInput = Console.ReadLine().Trim();
    if (!string.IsNullOrWhiteSpace(userInput))
        names.Add(userInput);
}

string[] enteredNames = names.ToArray();

if (enteredNames.Length == 0)
{
    Console.WriteLine();
}
else if (enteredNames.Length == 1)
{
    Console.WriteLine(@"{0} likes your post.", enteredNames[0]);
}
else if (enteredNames.Length == 2)
{
    Console.WriteLine(@"{0} and {1} like your post.", enteredNames[0], enteredNames[1]);
}
else
{
    Console.WriteLine(@"{0}, {1} and {2} other(s) like your post.", enteredNames[0], enteredNames[1], enteredNames.Length - 2);
}

