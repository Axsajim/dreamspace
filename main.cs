using Godot;
using System;

public class main : Control
{

	private string hello_world = "Hello World";

	public override void _Ready()
	{
		System.Diagnostics.Debug.WriteLine(hello_world);
	}

	public override void _Process(float delta)
	{
		
	}
}
