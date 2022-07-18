// HashSet
// Dictionary
// Hashtable

using HashStructures;


Employee emp1 = new Employee("Robby", 3827, "Technology");
Employee emp2 = new Employee("Bobby", 9416, "Marketing");
Employee emp3 = new Employee("Sally", 2519, "Sales");

Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
employees.Add(emp1.id, emp1);
employees.Add(emp2.id, emp2);
employees.Add(emp3.id, emp3);
// find employee
Employee e;
if (employees.TryGetValue(9415, out e))
{
    Console.WriteLine(e.name + " " + e.department);
}
if (employees.TryGetValue(2519, out e))
{
    Console.WriteLine(e.name + " " + e.department);
}// HashSet

HashSet<string> productCodes = new HashSet<string>();
productCodes.Add("A1234");
productCodes.Add("A1235");
productCodes.Add("A1236");

Console.WriteLine(productCodes.Contains("A1234"));
Console.WriteLine(productCodes.Contains("B12344"));

// HashSet tester
// Find items in the first array, but not the second array
int[] arr1 = { 3, 2, 8, 4, 5 };
int[] arr2 = { 5, 7, 3, 0, 2 };

//var result1 = HashSetSamples.FindMissingElements(arr1, arr2);
//// ans: 8,4
//foreach (var item in result1)
//{
//    Console.WriteLine(item + ", ");
//}

int[] arr3 = { 3, 2, 8, 4, 5, 5, 7, 3, 0, 2 };
// ans: 3->2, 2->2, 8->1, 4-> 1, 5->2, 7->1, 0-> 1
int[] arr4 = { 3, 0, 2, 4, 7, 3, 4, 5, 7, 6, 7 };

//DictionarySamples.CountElements(arr3);
//Console.WriteLine();
//DictionarySamples.CountElements(arr4);

// Linkedlist sample
//
Console.WriteLine("===========Linkedlist samples==========");
Console.WriteLine();
LinkedlistSamples noCycleList = new LinkedlistSamples();
Node firstNode = new Node(3);
Node secondNode = new Node(4);
Node thirdNode = new Node(5);
Node fourthNode = new Node(6);

noCycleList.head = firstNode;
firstNode.next = secondNode;
secondNode.next = thirdNode;
thirdNode.next = fourthNode;

Console.WriteLine("Has cycle? " + noCycleList.HasCycle());

LinkedlistSamples cycleList = new LinkedlistSamples();
cycleList.head = firstNode;
firstNode.next = secondNode;
secondNode.next = thirdNode;
thirdNode.next = fourthNode;
fourthNode.next = firstNode;


Console.WriteLine("Has cycle? " + cycleList.HasCycle());

