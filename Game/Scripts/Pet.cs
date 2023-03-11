using Godot;
using System;
using Pet_Core;

public partial class Pet : Node2D
{
	bool isMoving = true;

	[Export]
	private PathFollow2D follow;
	private PetObj pet;

	[Export]
	private string pet_type;
	private PetLibrary pl = new PetLibrary();
	
	[Export]
	Timer timer;

	Random rand = new Random(OS.GetProcessId());

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		pet = pl.CreatePet(pet_type);
		GD.Print(pet.type);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(isMoving)
		{
			follow.ProgressRatio += ( (float)delta / 10f);
		}
	}

	public void PetTimerTimeout()
	{
		isMoving = !isMoving;
		timer.WaitTime = (rand.NextDouble() * (5.0f - 1.0f) + 1.0f);
	}
}
