using Godot;
using System;

public partial class ClickyButton : Button
{
	[Export]
	private string _txt = "Default";

	[Export]
	private Node2D _targetScene = null; 
	// Called when the node enters the scene tree for the first time.
	Node2D root_node;

	Random rand;
	public override void _Ready()
	{
		rand = new Random(OS.GetProcessId());
		this.Text = _txt;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	private void FarmButtonPressed()
	{
		GD.Print("The farm button was pressed.");
		SpawnFood();
	}

	private void SpawnFood()
	{
		var scene = GD.Load<PackedScene>("res://Scenes/food.tscn");
		var inst = scene.Instantiate<Node2D>();
		inst.Position = new Vector2(rand.Next(50, 1000), 0);
		GetParent().AddChild(inst);
	}
}
