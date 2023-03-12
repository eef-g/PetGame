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
	public override void _Ready()
	{
		this.Text = _txt;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	private void FarmButtonPressed()
	{
		GD.Print("The farm button was pressed.");
		var scene = GD.Load<PackedScene>("res://Scenes/food.tscn");
		var inst = scene.Instantiate<Node2D>();
		inst.Position = new Vector2(872, 380);
		GetParent().AddChild(inst);
	}
}
