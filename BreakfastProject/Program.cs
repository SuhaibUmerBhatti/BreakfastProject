using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncBreakfast
{
	// These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
	internal class Bacon { }
	internal class Coffee { }
	internal class Egg { }
	internal class Juice { }
	internal class Toast { }

	internal class Program
	{
		private static async Task Main(string[] args)
		{
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
			sw.Start();
			Coffee cup = PourCoffee();
			Console.Write("coffee is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Task<Egg> eggsTask = FryEggsAsync(2);
			var baconTask = FryBaconAsync(3);
			var toastTask = MakeToastWithButterAndJamAsync(2);

			var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
			while (breakfastTasks.Count > 0)
			{
				Task finishedTask = await Task.WhenAny(breakfastTasks);
				if (finishedTask == eggsTask)
				{
					Console.WriteLine("eggs are ready");
					Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');
				}
				else if (finishedTask == baconTask)
				{
					Console.WriteLine("bacon is ready");
					Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');
				}
				else if (finishedTask == toastTask)
				{
					Console.WriteLine("toast is ready");
					Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');
				}
				await finishedTask;
				breakfastTasks.Remove(finishedTask);
			}

			Juice oj = PourOJ();
			Console.Write("oj is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Console.Write("Breakfast is ready!");
			sw.Stop();
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');
			Console.ReadKey();
		}
		private static async Task Main5(string[] args)
		{
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
			sw.Start();
			Coffee cup = PourCoffee();
			Console.Write("coffee is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Task<Egg> eggsTask = FryEggsAsync(2);
			Task<Bacon> baconTask = FryBaconAsync(3);
			Task<Toast> toastTask = MakeToastWithButterAndJamAsync(2);

			Egg egg = await eggsTask;
			Console.Write("eggs are ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Bacon bacon = await baconTask;
			Console.Write("bacon is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Toast toast = await toastTask;
			Console.Write("toast is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Juice oj = PourOJ();
			Console.Write("oj is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Console.Write("Breakfast is ready!");
			sw.Stop();
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');
			Console.ReadKey();
		}
		private static async Task Main4(string[] args)
		{
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
			sw.Start();
			Coffee cup = PourCoffee();
			Console.Write("coffee is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Task<Egg> eggsTask = FryEggsAsync(2);
			Task<Bacon> baconTask = FryBaconAsync(3);
			Task<Toast> toastTask = ToastBreadAsync(2);

			Toast toast = await toastTask;
			ApplyButter(toast);
			ApplyJam(toast);
			Console.Write("toast is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Juice oj = PourOJ();
			Console.Write("oj is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Egg egg = await eggsTask;
			Console.Write("eggs are ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Bacon bacon = await baconTask;
			Console.Write("bacon is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Console.Write("Breakfast is ready!");
			sw.Stop();
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');
			Console.ReadKey();
		}
		private static async Task Main3(string[] args)
		{
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
			sw.Start();
			Coffee cup = PourCoffee();
			Console.Write("coffee is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Task<Egg> eggsTask = FryEggsAsync(2);
			Egg egg = await eggsTask;
			Console.Write("eggs are ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Task<Bacon> baconTask = FryBaconAsync(3);
			Bacon bacon = await baconTask;
			Console.Write("bacon is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Task<Toast> toastTask = ToastBreadAsync(2);
			Toast toast = await toastTask;
			ApplyButter(toast);
			ApplyJam(toast);
			Console.Write("toast is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Juice oj = PourOJ();
			Console.Write("oj is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Console.Write("Breakfast is ready!");
			sw.Stop();
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');
			Console.ReadKey();
		}
		private static async Task Main2(string[] args)
		{
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
			sw.Start();
			Coffee cup = PourCoffee();
			Console.Write("coffee is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Egg eggs = await FryEggsAsync(2);
			Console.Write("eggs are ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Bacon bacon = await FryBaconAsync(3);
			Console.Write("bacon is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Toast toast = await ToastBreadAsync(2);
			ApplyButter(toast);
			ApplyJam(toast);
			Console.Write("toast is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Juice oj = PourOJ();
			Console.Write("oj is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Console.Write("Breakfast is ready!");
			sw.Stop();
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');
			Console.ReadKey();
		}
		private static void Main1(string[] args)
		{
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
			sw.Start();
			Coffee cup = PourCoffee();
			Console.Write("coffee is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Egg eggs = FryEggs(2);
			Console.Write("eggs are ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Bacon bacon = FryBacon(3);
			Console.Write("bacon is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Toast toast = ToastBread(2);
			ApplyButter(toast);
			ApplyJam(toast);
			Console.Write("toast is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Juice oj = PourOJ();
			Console.Write("oj is ready");
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');

			Console.Write("Breakfast is ready!");
			sw.Stop();
			Console.WriteLine(" - " + sw.Elapsed.ToString() + '\n');
			Console.ReadKey();
		}

		#region Asynchronous Code

		private static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
		{
			var toast = await ToastBreadAsync(number);
			ApplyButter(toast);
			ApplyJam(toast);

			return toast;
		}
		private static async Task<Toast> MakeToastWithButterAndJamAsync2(int number)
		{
			var toast = await ToastBreadAsync2(number);
			ApplyButter(toast);
			ApplyJam(toast);

			return toast;
		}

		private static async Task<Toast> ToastBreadAsync(int slices)
		{
			for (int slice = 0; slice < slices; slice++)
			{
				Console.WriteLine("Putting a slice of bread in the toaster");
			}
			Console.WriteLine("Start toasting...");
			await Task.Delay(4000);
			//Console.WriteLine("Fire! Toast is ruined!");
			//throw new InvalidOperationException("The toaster is on fire");
			await Task.Delay(4000);
			Console.WriteLine("Remove toast from toaster");

			return new Toast();
		}
		private static async Task<Toast> ToastBreadAsync2(int slices)
		{
			for (int slice = 0; slice < slices; slice++)
			{
				Console.WriteLine("Putting a slice of bread in the toaster");
			}
			Console.WriteLine("Start toasting...");
			await Task.Delay(3000);
			Console.WriteLine("Remove toast from toaster");

			return new Toast();
		}

		private static async Task<Bacon> FryBaconAsync(int slices)
		{
			Console.WriteLine($"putting {slices} slices of bacon in the pan");
			Console.WriteLine("cooking first side of bacon...");
			await Task.Delay(3000);
			for (int slice = 0; slice < slices; slice++)
			{
				Console.WriteLine("flipping a slice of bacon");
			}
			Console.WriteLine("cooking the second side of bacon...");
			await Task.Delay(2000);
			Console.WriteLine("Put bacon on plate");

			return new Bacon();
		}

		private static async Task<Egg> FryEggsAsync(int howMany)
		{
			Console.WriteLine("Warming the egg pan...");
			await Task.Delay(3000);
			Console.WriteLine($"cracking {howMany} eggs");
			Console.WriteLine("cooking the eggs ...");
			await Task.Delay(3000);
			Console.WriteLine("Put eggs on plate");

			return new Egg();
		}

		#endregion

		#region Synchronous Code

		private static Juice PourOJ()
		{
			Task.Delay(1000).Wait();
			Console.WriteLine("Pouring orange juice");
			return new Juice();
		}

		private static void ApplyJam(Toast toast) =>
			Console.WriteLine("Putting jam on the toast");

		private static void ApplyButter(Toast toast) =>
			Console.WriteLine("Putting butter on the toast");

		private static Toast ToastBread(int slices)
		{
			for (int slice = 0; slice < slices; slice++)
			{
				Console.WriteLine("Putting a slice of bread in the toaster");
			}
			Console.WriteLine("Start toasting...");
			Task.Delay(3000).Wait();
			Console.WriteLine("Remove toast from toaster");

			return new Toast();
		}

		private static Bacon FryBacon(int slices)
		{
			Console.WriteLine($"putting {slices} slices of bacon in the pan");
			Console.WriteLine("cooking first side of bacon...");
			Task.Delay(3000).Wait();
			for (int slice = 0; slice < slices; slice++)
			{
				Console.WriteLine("flipping a slice of bacon");
			}
			Console.WriteLine("cooking the second side of bacon...");
			Task.Delay(3000).Wait();
			Console.WriteLine("Put bacon on plate");

			return new Bacon();
		}

		private static Egg FryEggs(int howMany)
		{
			Console.WriteLine("Warming the egg pan...");
			Task.Delay(3000).Wait();
			Console.WriteLine($"cracking {howMany} eggs");
			Console.WriteLine("cooking the eggs ...");
			Task.Delay(3000).Wait();
			Console.WriteLine("Put eggs on plate");

			return new Egg();
		}

		private static Coffee PourCoffee()
		{
			Task.Delay(1000).Wait();
			Console.WriteLine("Pouring coffee");
			return new Coffee();
		}

		#endregion
	}
}