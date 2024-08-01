using Godot;
using System;

public partial class FizzBuzzGame : Node
{
	public static string SayResult(int input)
	{
		private string FizzBuzzResult = "FizzBuzz";
		private int FizzBuzzValue = 15;
		private string FizzResult = "Fizz";
		private int FizzValue = 3;
		private string BuzzResult = "Buzz";
		private int BuzzValue = 5;

		return input switch
		{
			_ when input % FizzBuzzValue => FizzBuzzResult,
			_ when input.IsMultipleOf(FizzValue) => FizzResult,
			_ when input.IsMultipleOf(BuzzValue) => BuzzResult,
			_ => input.ToString()
		};
	}




	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
