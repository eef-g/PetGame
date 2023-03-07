using Godot;
using System;

public partial class ClickyButton : Button
{
	[Export]
	private string _txt = "Default";

	[Export]
	private Node2D _targetScene = null; 
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.Text = _txt;
		this.Pressed += Button_Pressed; 
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	private void Button_Pressed()
	{
		if(_targetScene != null)
		{
			GD.Print("We have a node attached to the button!");
		}
		GD.Print("Hello world!");
	}
}
