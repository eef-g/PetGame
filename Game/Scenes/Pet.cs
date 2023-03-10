using Godot;
using System;

public partial class Pet : Node2D
{
	float t = 0.0f;

	[Export]
	private PathFollow2D follow;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		t += ( (float)delta / 1000f);
		follow.ProgressRatio += t;
		if (follow.ProgressRatio >= 1.00)
		{
			t = 0.00f;
		}
	}
}
