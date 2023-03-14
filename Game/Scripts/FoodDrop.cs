using Godot;
using System;

public partial class FoodDrop : PathFollow2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(ProgressRatio != 1.0f)
		{
			if(ProgressRatio + (float)delta >= 1.0f)
			{
				ProgressRatio = 1.0f;
			}
			else
			{
				ProgressRatio += (float)delta;
			}
		}
	}
}
