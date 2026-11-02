using System;

public class HelloWorld {
	static string[] tasks = new string[10];
	static int taskIndex = 0;
	public static void Main(string[] args) {

		while(true) {
			Console.WriteLine ("Please enter a valid number from 1 to 5");
			Console.WriteLine ("1 Add");
			Console.WriteLine ("2 View");
			Console.WriteLine ("3 Complete");
			Console.WriteLine ("4 Delete");
			Console.WriteLine ("5 Exit");

			string userChoice = Console.ReadLine();

			switch(userChoice) {
			case "1":
				// Add new task
				AddTask();
				break;
			case "2":
				// View all tasks
				ViewTasks();
				break;
			case "3":
				// Complete an existing task
				CompleteTask();
				break;
			case "4":
				// Delete task
				DeleteTask();
				break;
			case "5":
				// Exit
				Environment.Exit(0);
				break;
			default:
				Console.WriteLine("Invalid number please try again later.");
				break;
			}
		}
	}

	private static void AddTask() {
		Console.WriteLine("Please enter a new task.");
		string task = Console.ReadLine();
		tasks[taskIndex] = task;
		taskIndex++;
	}

	private static void ViewTasks() {
		Console.WriteLine("All tasks:");

		for(int i = 0; i < taskIndex; i++) {
			Console.WriteLine($"{i + 1}. Task title: {tasks[i]}");
		}
	}

	private static void CompleteTask() {
		Console.WriteLine("Please enter task id:");

		string ReadTaskLine = Console.ReadLine();

		int TaskId = Convert.ToInt32(ReadTaskLine);

		tasks[TaskId - 1] += "--Completed";

	}
	
	private static void DeleteTask(){
	    Console.WriteLine("Enter id you want to delete: ");
	    
	    string ReadTaskLine = Console.ReadLine();

		int TaskId = Convert.ToInt32(ReadTaskLine);
		
		tasks[TaskId] = string.Empty;
	}
}