using Algorithms;

//https://www.linkedin.com/learning/c-sharp-algorithms/code-challenges/urn:li:la_assessmentV2:54665995?resume=false


//// 1. Reverse each word in a sentence
//string sentence = "sally is a great worker";
//string learnerResult = Algorithms.ReverseWord.ReverseEachWord(sentence);
////Console.WriteLine(learnerResult);
////Console.WriteLine("-----------------------------");

//// 2. BinarySearch implementation with assumption input array is sorted in ascending order.
//int[] array = { 1, 2, 3, 4, 5, 6 };

////Console.WriteLine(Algorithms.ArrayBinarySearchImpl.BinarySearch(array, 4));
////Console.WriteLine(Algorithms.ArrayBinarySearchImpl.BinarySearch(array, 8));
////Console.WriteLine("-----------------------------");

//// 3. Find even numbers in two int arrays
//int[] array2 = { 8, 10, 12, 24, 4, 6 };
//var evenNumbers = Algorithms
//    .FindEvenNumbersFromArraysImpl
//    .FindEvenNumbers(array, array2);

////Array.ForEach(evenNumbers, Console.WriteLine);
////Console.WriteLine("-----------------------------");

////4. Reverse array elements
//var reversedArray = Algorithms.ReverseArrayImpl.ReverseArrray(array);
////Array.ForEach(reversedArray, Console.WriteLine);
////Console.WriteLine("-----------------------------");

//var reversedArrayWithSwamp = Algorithms.ReverseArrayImpl.ReverseArrray(array);
////Array.ForEach(reversedArrayWithSwamp, Console.WriteLine);
//Console.WriteLine("-----------------------------");


////5. Rotate array by one position, assumption array will have atleast one element
//int[] numbers = { 1, 2, 3, 4, 5, 6 };
//int[] roratedArray = RotateArrayToLeft.RotateArrayByOnePosition(numbers);
////Array.ForEach(roratedArray, Console.WriteLine);
//Console.WriteLine("-----------------------------");

//// 6. Sum linkedList list contents
//LinkedListSum.ListNode head = new LinkedListSum.ListNode(7);
//head.next = new LinkedListSum.ListNode(5);
//head.next.next = new LinkedListSum.ListNode(3);
//head.next.next.next = new LinkedListSum.ListNode(4);
//head.next.next.next.next = new LinkedListSum.ListNode(1);
//int result = LinkedListSum.Sum(head);
//Console.WriteLine(result);
//Console.WriteLine("-----------------------------");

////7. Print a give number of binary numbers 
//GenerateBinaryNumber.PrintBinaryNumbers(5);
//Console.WriteLine("-----------------------------");

//GenerateBinaryNumber.PrintBinaryNumbers(-1);
//Console.WriteLine("-----------------------------");

//GenerateBinaryNumber.PrintBinaryNumbers(10);
//Console.WriteLine("-----------------------------");

//8. Retrive the next greater number on the right side if no element print -1
//int[] array2 = { 8, -10, 42, 12, 24, 4, 6 };

//NextGreaterElemenetImpl.PrintNextGreaterElement(array2);

//Console.WriteLine("-----------------------------");

//9. Check matching opening and closing parenthesis
//Console.WriteLine(MatchingParenthesisImpl.hasMatchingParenthesis("hello()"));
//Console.WriteLine(MatchingParenthesisImpl.hasMatchingParenthesis("hello"));
//Console.WriteLine(MatchingParenthesisImpl.hasMatchingParenthesis("(hello()"));
//Console.WriteLine(MatchingParenthesisImpl.hasMatchingParenthesis("hello())"));
//Console.WriteLine(MatchingParenthesisImpl.hasMatchingParenthesis("(hello())"));
//Console.WriteLine("-----------------------------");

// 10. Evaluate reverse polish notation (RPN), "3+4" in RPN will be written as "34+"
// Console.WriteLine(ReversePolishNotationImpl.EvaluateRPN("3 4 +"));
// Console.WriteLine("-----------------------------");

////11. Retrieve common elements available in two arrays.
//int[] array1 = { 8, 2, 34, 45, 56, 6, 4, 123};
//int[] array2 = { 8, -10, 42, 12, 24, 4, 6 };

//RetrieveSharedArrayElements.FindSharedElements(array1, array2);
//Console.WriteLine("-----------------------------");

// 12. Frequency of each elements in a give int arrays
//int[] array = { 8, 2, 8, 45, 56, 6, 56, 123, 56, 8, 6, 8, 123 };
//FrequenceOfArrayElementImpl.DispalceElementsFrequence(array);
// Console.WriteLine("-----------------------------");


// 13. Detect cyclic LinkedList
// This is how your code will be called.
// You can edit this code to try different testing cases.
//DetectCyclicLinkedListImpl.ListNode head = new DetectCyclicLinkedListImpl.ListNode(1);
//head.Next = new DetectCyclicLinkedListImpl.ListNode(2);
//head.Next.Next = new DetectCyclicLinkedListImpl.ListNode(3);
//head.Next.Next.Next = head;
//bool learnerResult = DetectCyclicLinkedListImpl.HasCycle(head);
//Console.WriteLine(learnerResult);
//Console.WriteLine("-----------------------------");

//Console.WriteLine("-----------------------------");

//// 14.Implement custom Binary search tree

//// 15. Binary Tree transverse Impl
////      4
////    1    3
////   8  9 6

//Node rootNode = new Node();
//rootNode.Data = 4;

//Node nodeOne = new Node();
//nodeOne.Data = 1;

//Node nodeTwo = new Node();
//nodeTwo.Data = 3;

//Node nodeThree = new Node();
//nodeThree.Data = 4;

//Node nodeFour = new Node();
//nodeFour.Data = 8;

//Node nodeFive = new Node();
//nodeFive.Data = 9;

//Node nodeSix = new Node() { };
//nodeSix.Data = 6;

//rootNode.Left = nodeOne;
//rootNode.Right = nodeThree;

//nodeOne.Left = nodeFour;
//nodeOne.Right = nodeFive;

//nodeTwo.Left = nodeSix;

// 15. Find height of a binay Tree
Console.WriteLine("-----------------------------");
